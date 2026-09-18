USE HelpDeskDB
GO


CREATE OR ALTER PROCEDURE sp_LogErrores_Insertar
    @mensajeError VARCHAR(MAX),
    @numeroError INT,
    @procedimiento VARCHAR(150),
    @usuarioApp VARCHAR(25),
    @lineaError INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO tblLogErrores (mensajeError, numeroError, procedimiento, usuarioApp, lineaError)
    VALUES (
        @mensajeError,
        @numeroError,
        @procedimiento,
        @usuarioApp,
        @lineaError
    );
END
GO