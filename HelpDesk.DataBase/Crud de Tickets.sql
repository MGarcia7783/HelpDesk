USE HelpDeskDB
GO


CREATE OR ALTER PROC sp_MostrarTickets
(
	@buscar NVARCHAR(100) = NULL,
	@idUsuarioSolicitante INT = NULL,
    @modoAdmin BIT = 0,
	@pagina INT  = 1,
	@tamPagina INT = 10
)
AS
BEGIN
	SET NOCOUNT ON;
	
	IF @pagina < 1 SET @pagina = 1;
    IF @tamPagina < 1 SET @tamPagina = 10;

	SET @buscar = TRIM(@buscar);
	
	SELECT t.id AS idTicket,
		   t.numeroTicket,
		   t.fechaCreacion,
		   t.asunto,
		   u.nombreCompleto AS solicitante,
		   te.nombreCompleto AS tecnico,
		   t.idCategoria,
		   c.nombreCategoria,
		   t.prioridad,
		   t.estado
	FROM tblTickets t
		INNER JOIN tblUsuarios u ON t.idUsuarioSolicitante = u.id
		LEFT JOIN tblUsuarios te ON te.id=t.idTecnicoAsignado
		INNER JOIN tblCategorias c ON t.idCategoria = c.id

	WHERE 
	(	
		@modoAdmin = 1 
		OR t.idUsuarioSolicitante = @idUsuarioSolicitante
	) 
	AND
	(	
		ISNULL(@buscar, '') = ''
		OR t.numeroTicket LIKE '%' + @buscar + '%'
		OR t.asunto LIKE '%' + @buscar + '%'
		OR u.nombreCompleto LIKE '%' + @buscar + '%'
		OR c.nombreCategoria LIKE '%' + @buscar + '%'
		OR t.prioridad LIKE '%' + @buscar + '%'
		OR T.estado LIKE '%' + @buscar + '%'
	)
	ORDER BY

	CASE t.estado
		WHEN 'Abierto' THEN 1
		WHEN 'En proceso' THEN 2
		WHEN 'Cerrado' THEN 3
		WHEN 'Cancelado' THEN 4
	END,

	CASE
		WHEN t.estado IN ('Abierto','En proceso') THEN
			CASE t.prioridad
				WHEN 'Crítica' THEN 1
				WHEN 'Alta' THEN 2
				WHEN 'Media' THEN 3
				WHEN 'Baja' THEN 4
			END
		ELSE 0
	END,

	t.fechaCreacion DESC,

	t.id DESC

	OFFSET (@pagina - 1) * @tamPagina ROWS
	FETCH NEXT @tamPagina ROWS ONLY;
END
GO


CREATE OR ALTER PROC sp_ContarTickets
(
    @buscar NVARCHAR(100) = NULL,
	@idUsuarioSolicitante INT=NULL,
    @modoAdmin BIT = 0
	
)
AS
BEGIN
    SET NOCOUNT ON;

	SET @buscar = TRIM(@buscar);

    SELECT COUNT(*) AS Total
    FROM tblTickets t
		INNER JOIN tblUsuarios u ON t.idUsuarioSolicitante = u.id
		LEFT JOIN tblUsuarios te ON te.id=t.idTecnicoAsignado
		INNER JOIN tblCategorias c ON t.idCategoria = c.id

    WHERE 
	(
		@modoAdmin = 1 
		OR t.idUsuarioSolicitante = @idUsuarioSolicitante
	) 
	AND
	(
		ISNULL(@buscar,'') = ''
        OR t.numeroTicket LIKE '%' + @buscar + '%'
        OR t.asunto LIKE '%' + @buscar + '%'
        OR u.nombreCompleto LIKE '%' + @buscar + '%'
        OR c.nombreCategoria LIKE '%' + @buscar + '%'
        OR t.estado LIKE '%' + @buscar + '%'
	)
END
GO


CREATE OR ALTER PROC sp_ObtenerTicketPorId
(
    @id INT
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
    t.id AS idTicket,
    t.numeroTicket,
    t.fechaCreacion,
    t.fechaUltimaActualizacion,
    t.asunto,
    t.descripcion,

    t.idUsuarioSolicitante,
    u.nombreCompleto AS nombreSolicitante,

    t.idTecnicoAsignado,
    te.nombreCompleto AS nombreTecnico,

    t.idCategoria,
    c.nombreCategoria,

    t.prioridad,
    t.estado,
    t.fechaCierre

FROM tblTickets t
	INNER JOIN tblUsuarios u ON u.id=t.idUsuarioSolicitante
	LEFT JOIN tblUsuarios te ON te.id=t.idTecnicoAsignado
	INNER JOIN tblCategorias c ON c.id=t.idCategoria

WHERE t.id=@id;
END
GO


CREATE OR ALTER PROC sp_AgregarTicket
(
	@asunto NVARCHAR(200),
	@descripcion NVARCHAR(MAX),
	@idUsuarioSolicitante INT,
	@idCategoria INT,
	@prioridad NVARCHAR(20),
	@usuarioApp NVARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @numeroTicket NVARCHAR(20);
	DECLARE @siguiente INT;

	SET @asunto = TRIM(@asunto);
	SET @descripcion = TRIM(@descripcion);
	SET @prioridad = TRIM(@prioridad);
	SET @usuarioApp = TRIM (@usuarioApp);

	BEGIN TRY
		BEGIN TRANSACTION

			IF NOT EXISTS (
				SELECT 1 
				FROM tblUsuarios 
				WHERE id = @idUsuarioSolicitante
			)
				THROW 53001, 'El usuario solicitante no existe', 1;

			IF NOT EXISTS (
				SELECT 1 
				FROM tblCategorias 
				WHERE id = @idCategoria
			)
				THROW 52002, 'La categoría no existe o está inactiva', 1;

			IF @prioridad NOT IN ('Baja','Media','Alta','Crítica')
				THROW 52003,'La prioridad no es válida.',1;

			SELECT @siguiente = 
				ISNULL(MAX(TRY_CAST(REPLACE(numeroTicket, 'TK-','') AS INT)), 0) + 1 
			FROM tblTickets;

			SET @numeroTicket = 
				'TK-' + 
				RIGHT('000000' + CAST(@siguiente AS NVARCHAR(6)), 6);

			INSERT INTO tblTickets(numeroTicket, asunto, descripcion, idUsuarioSolicitante, idCategoria, prioridad, estado)
			VALUES(@numeroTicket,
				   @asunto,
				   @descripcion,
				   @idUsuarioSolicitante,
				   @idCategoria,
				   @prioridad,
				   'Abierto');

			COMMIT TRANSACTION;

			SELECT @numeroTicket AS NumeroTicket;
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;

		DECLARE
			@msg NVARCHAR(MAX) = ERROR_MESSAGE(),
			@num INT = ERROR_NUMBER(),
			@proc NVARCHAR(150) = ERROR_PROCEDURE(),
			@line INT = ERROR_LINE();

		EXEC sp_LogErrores_Insertar @msg, @num, @proc, @usuarioApp, @line;

		THROW;
	END CATCH
END
GO



--- ADMNISTRACIÓN ---

CREATE OR ALTER PROC sp_GestionarTicket
(
    @id INT,
    @idTecnicoAsignado INT = NULL,
    @estado NVARCHAR(20),
    @usuarioApp NVARCHAR(25)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

            IF NOT EXISTS
            (
                SELECT 1
                FROM tblTickets
                WHERE id = @id
            )
                THROW 53002,'El ticket no existe.',1;

            IF @estado NOT IN
            (
                'Abierto',
                'En proceso',
                'Cerrado',
                'Cancelado'
            )
                THROW 53003,'El estado seleccionado no es válido.',1;

            DECLARE @estadoActual NVARCHAR(20);

            SELECT @estadoActual = estado
            FROM tblTickets
            WHERE id = @id;

            IF @estadoActual = 'Abierto'
            BEGIN
                IF @estado NOT IN ('Abierto','En proceso','Cancelado')
                    THROW 53004,'No es posible realizar esa transición de estado.',1;
            END

            IF @estadoActual = 'En proceso'
            BEGIN
                IF @estado NOT IN ('En proceso','Cerrado','Cancelado')
                    THROW 53004,'No es posible realizar esa transición de estado.',1;
            END

            IF @estadoActual = 'Cerrado'
            BEGIN
                IF @estado <> 'Cerrado'
                    THROW 53004,'Un ticket cerrado no puede modificarse.',1;
            END

            IF @estadoActual = 'Cancelado'
            BEGIN
                IF @estado <> 'Cancelado'
                    THROW 53004,'Un ticket cancelado no puede modificarse.',1;
            END

            IF @idTecnicoAsignado IS NOT NULL
            BEGIN

                IF NOT EXISTS
                (
                    SELECT 1
                    FROM tblUsuarios u
                        INNER JOIN tblRoles r
                            ON u.idRol = r.id
                    WHERE
                        u.id = @idTecnicoAsignado
                        AND u.activo = 1
                        AND r.activo = 1
                        AND r.nombreRol = 'Técnico'
                )
                    THROW 53005,'El técnico seleccionado no es válido.',1;

            END

            IF @estado IN ('En proceso','Cerrado') AND @idTecnicoAsignado IS NULL
                THROW 53006, 'Debe asignar un técnico para este estado.', 1;

            UPDATE tblTickets
            SET idTecnicoAsignado = @idTecnicoAsignado,
                estado = @estado,
                fechaUltimaActualizacion = GETDATE(),
                fechaCierre =
                    CASE
                        WHEN @estado = 'Cerrado'
                            THEN GETDATE()
                        ELSE NULL
                    END
            WHERE id = @id;

        COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;

		DECLARE
			@msg NVARCHAR(MAX) = ERROR_MESSAGE(),
			@num INT = ERROR_NUMBER(),
			@proc NVARCHAR(150) = ERROR_PROCEDURE(),
			@line INT = ERROR_LINE();

		EXEC sp_LogErrores_Insertar @msg, @num, @proc, @usuarioApp, @line;

		THROW;
	END CATCH

END
GO



CREATE OR ALTER PROC sp_DashboardAdmin
AS
BEGIN
    SET NOCOUNT ON;

    --> 1. Tickets por Estado
    SELECT
        estado,
        COUNT(*) AS total
    FROM tblTickets
    GROUP BY estado
    ORDER BY estado;

    --> 2. Tickets por Técnico
    SELECT TOP (4)
        ISNULL(u.nombreCompleto, 'Sin asignar') AS tecnico,
        COUNT(t.id) AS totalTickets
    FROM tblTickets t
    LEFT JOIN tblUsuarios u ON t.idTecnicoAsignado = u.id
    WHERE t.estado IN('Abierto', 'En proceso')
    GROUP BY ISNULL (u.nombreCompleto, 'Sin asignar')
    ORDER BY totalTickets DESC;

    --> 3. Tickets Críticos Pendientes
    SELECT TOP (10)
        t.numeroTicket,
        t.asunto,
        c.nombreCategoria AS categoria,
        ISNULL(u.nombreCompleto, 'Sin asignar') AS tecnico,
        t.estado,
        t.fechaCreacion,

        CASE
            -- Menos de 1 hora
            WHEN DATEDIFF(MINUTE, t.fechaCreacion, GETDATE()) < 60 THEN
                CONCAT(
                    DATEDIFF(MINUTE, t.fechaCreacion, GETDATE()),
                    ' min'
                )

            -- Menos de 1 día
            WHEN DATEDIFF(HOUR, t.fechaCreacion, GETDATE()) < 24 THEN
                CONCAT(
                    DATEDIFF(HOUR, t.fechaCreacion, GETDATE()),
                    ' h',
                    CASE
                        WHEN DATEDIFF(MINUTE, t.fechaCreacion, GETDATE()) % 60 > 0
                            THEN CONCAT(' ', DATEDIFF(MINUTE, t.fechaCreacion, GETDATE()) % 60, ' min')
                        ELSE ''
                    END
                )

            -- 1 día o más
            ELSE
                CONCAT(
                    DATEDIFF(DAY, t.fechaCreacion, GETDATE()),
                    ' d',
                    CASE
                        WHEN DATEDIFF(HOUR, t.fechaCreacion, GETDATE()) % 24 > 0
                            THEN CONCAT(' ', DATEDIFF(HOUR, t.fechaCreacion, GETDATE()) % 24, ' h')
                        ELSE ''
                    END
                )
        END AS tiempoPendiente

    FROM tblTickets t
        INNER JOIN tblCategorias c
            ON t.idCategoria = c.id
        LEFT JOIN tblUsuarios u
            ON t.idTecnicoAsignado = u.id

    WHERE
        t.prioridad = 'Crítica'
        AND t.estado IN ('Abierto', 'En proceso')

    ORDER BY
        t.fechaCreacion ASC;

    --> 4. Resumen del día
    
    -- Tickets creados hoy
    SELECT
    (
        SELECT COUNT(*)
        FROM tblTickets
        WHERE CAST(fechaCreacion AS DATE) = CAST(GETDATE() AS DATE)
    ) AS ticketsCreadosHoy,

    -- Tickets sin asignar
    (
        SELECT COUNT(*)
        FROM tblTickets
        WHERE idTecnicoAsignado IS NULL
          AND estado IN ('Abierto','En proceso')
    ) AS ticketsSinAsignar,

    -- Tickets críticos pendientes
    (
        SELECT COUNT(*)
        FROM tblTickets
        WHERE prioridad = 'Crítica'
          AND estado IN ('Abierto','En proceso')
    ) AS ticketsCriticos,

    -- Tickets cerrados hoy
    (
        SELECT COUNT(*)
        FROM tblTickets
        WHERE estado = 'Cerrado'
          AND CAST(fechaCierre AS DATE)=CAST(GETDATE() AS DATE)
    ) AS ticketsCerradosHoy;

END
GO

EXEC sp_DashboardAdmin