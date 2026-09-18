USE HelpDeskDB
GO


CREATE OR ALTER PROC sp_MostrarRolesActivos
AS
BEGIN
	SET NOCOUNT ON;	

	SELECT Id, nombreRol
	FROM tblRoles
	WHERE activo = 1
	ORDER BY nombreRol
END
GO


CREATE OR ALTER PROC sp_MostrarRoles
(
	@buscar NVARCHAR(50) = NULL,
	@pagina INT  = 1,
	@tamPagina INT = 10
)
AS
BEGIN
	SET NOCOUNT ON;

	IF @pagina < 1 SET @pagina = 1;
    IF @tamPagina < 1 SET @tamPagina = 10;
	SET @buscar = TRIM(@buscar);

	SELECT Id, nombreRol, activo
	FROM tblRoles
	WHERE 
		ISNULL(@buscar, '') = '' 
		OR nombreRol LIKE '%' + @buscar + '%'
	ORDER BY nombreRol
	OFFSET (@pagina - 1) * @tamPagina ROWS
	FETCH NEXT @tamPagina ROWS ONLY;
END
GO


CREATE OR ALTER PROC sp_ContarRoles
(
    @buscar NVARCHAR(50) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

	SET @buscar = TRIM(@buscar);

    SELECT COUNT(*) AS Total
    FROM tblRoles
	WHERE 
		ISNULL(@buscar, '') = '' 
		OR nombreRol LIKE '%' + @buscar + '%'
END
GO


CREATE OR ALTER PROC sp_ObtenerRolPorId
(
	@Id INT
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id, nombreRol, activo
	FROM tblRoles
	WHERE Id = @Id
END
GO


CREATE OR ALTER PROC sp_AgregarRol
(
	@nombreRol NVARCHAR(50),
	@usuarioApp NVARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	SET @nombreRol = TRIM(@nombreRol);
	SET @usuarioApp = TRIM(@usuarioApp);

	BEGIN TRY
		BEGIN TRANSACTION;

			IF EXISTS (
				SELECT 1 
				FROM tblRoles 
				WHERE nombreRol = @nombreRol
			)
				THROW 50001, 'El rol ya existe', 1;
			
			INSERT INTO tblRoles (nombreRol)
			VALUES (@nombreRol);

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


CREATE OR ALTER PROC sp_ActualizarRol
(
	@Id INT,
	@nombreRol NVARCHAR(50),
	@usuarioApp NVARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	SET @nombreRol = TRIM(@nombreRol);
	SET @usuarioApp = TRIM(@usuarioApp);

	BEGIN TRY
		BEGIN TRANSACTION;

			IF NOT EXISTS (
				SELECT 1 
				FROM tblRoles 
				WHERE Id = @Id
			)
				THROW 50002, 'El rol no xiste', 1;

			IF EXISTS (
				SELECT 1 
				FROM tblRoles 
				WHERE nombreRol = @nombreRol 
					AND Id <> @Id
			)
				THROW 50001, 'El rol ya existe', 1;

			UPDATE tblRoles
			SET nombreRol = @nombreRol
			WHERE Id = @Id;

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


CREATE OR ALTER PROC sp_CambiarEstadoRol
(
	@Id INT,
	@activo BIT,
	@usuarioApp NVARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	SET @usuarioApp = TRIM(@usuarioApp);

	BEGIN TRY
		BEGIN TRANSACTION;

			IF NOT EXISTS (
				SELECT 1 
				FROM tblRoles 
				WHERE Id = @Id
			)
				THROW 50002, 'El rol no exite', 1;


			IF (@activo = 0 
				AND EXISTS (
					SELECT 1 
					FROM tblUsuarios 
					WHERE IdRol = @id
					))
				THROW 50003, 'El rol tiene usuarios asignados', 1;

			UPDATE tblRoles
			SET activo = @activo
			WHERE Id = @Id;

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