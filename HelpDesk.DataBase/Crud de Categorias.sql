USE HelpDeskDB
GO


CREATE OR ALTER PROC sp_MostrarCategoriasActivas
AS
BEGIN
	SET NOCOUNT ON;	

	SELECT Id, nombreCategoria
	FROM tblCategorias
	WHERE activo = 1
	ORDER BY nombreCategoria
END
GO

CREATE OR ALTER PROC sp_MostrarCategorias
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

	SELECT Id, nombreCategoria, descripcion,activo
	FROM tblCategorias
	WHERE 
		ISNULL(@buscar, '') = '' 
		OR nombreCategoria LIKE '%' + @buscar + '%'
	ORDER BY nombreCategoria
	OFFSET (@pagina - 1) * @tamPagina ROWS
	FETCH NEXT @tamPagina ROWS ONLY;
END
GO


CREATE OR ALTER PROC sp_ContarCategorias
(
    @buscar NVARCHAR(50) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

	SET @buscar = TRIM(@buscar);

    SELECT COUNT(*) AS Total
    FROM tblCategorias
	WHERE 
		ISNULL(@buscar, '') = '' 
		OR nombreCategoria LIKE '%' + @buscar + '%'
END
GO


CREATE OR ALTER PROC sp_ObtenerCategoriaPorId
(
	@Id INT
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id, nombreCategoria, descripcion, activo
	FROM tblCategorias
	WHERE Id = @Id
END
GO


CREATE OR ALTER PROC sp_AgregarCategoria
(
	@nombreCategoria NVARCHAR(50),
	@descripcion NVARCHAR(250),
	@usuarioApp NVARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	SET @nombreCategoria = TRIM(@nombreCategoria);
	SET @descripcion = TRIM(@descripcion);
	SET @usuarioApp = TRIM(@usuarioApp);

	BEGIN TRY
		BEGIN TRANSACTION;

			IF EXISTS (
				SELECT 1 
				FROM tblCategorias 
				WHERE nombreCategoria = @nombreCategoria
			)
				THROW 52001, 'La categoria ya existe', 1;
			
			INSERT INTO tblCategorias (nombreCategoria, descripcion)
			VALUES (@nombreCategoria, 
				    @descripcion);

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


CREATE OR ALTER PROC sp_ActualizarCategoria
(
	@Id INT,
	@nombreCategoria NVARCHAR(50),
	@descripcion NVARCHAR(250),
	@usuarioApp NVARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	SET @nombreCategoria = TRIM(@nombreCategoria);
	SET @descripcion = TRIM(@descripcion);
	SET @usuarioApp = TRIM(@usuarioApp);

	BEGIN TRY
		BEGIN TRANSACTION;

			IF NOT EXISTS (
				SELECT 1 
				FROM tblCategorias 
				WHERE Id = @Id
			)
				THROW 52002, 'La categoria no xiste', 1;

			IF EXISTS (
				SELECT 1 
				FROM tblCategorias 
				WHERE nombreCategoria = @nombreCategoria 
					AND Id <> @Id
			)
				THROW 52001, 'La categoria ya existe', 1;

			UPDATE tblCategorias
			SET nombreCategoria = @nombreCategoria,
				descripcion = @descripcion
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


CREATE OR ALTER PROC sp_CambiarEstadoCategoria
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
				FROM tblCategorias 
				WHERE Id = @Id
			)
				THROW 52002, 'La categoria no exite', 1;

			UPDATE tblCategorias
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