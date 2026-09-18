USE [master];
GO


--> 1. Validar si la base de datos existe 
IF DB_ID('HelpDeskDB') IS NOT NULL
BEGIN
	ALTER DATABASE HelpDeskDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	DROP DATABASE HelpDeskDB
END
GO


--> 2. Crear la base de datos
CREATE DATABASE HelpDeskDB
GO


--> 3. Usar la base de datos
USE HelpDeskDB
GO


--> 4. Crear tablas

-- Roles
CREATE TABLE tblRoles (
	id INT IDENTITY(1,1) NOT NULL,
	nombreRol NVARCHAR(50) NOT NULL,
	activo BIT NOT NULL DEFAULT 1,

	CONSTRAINT PK_tblRoles PRIMARY KEY (id),
	CONSTRAINT CK_tblRoles_nombreRol CHECK(nombreRol IN ('Administrador', 'Usuario', 'Técnico')),
	CONSTRAINT UQ_tblRoles_nombreRol UNIQUE (nombreRol)
)
GO


-- Usuarios
CREATE TABLE tblUsuarios
(
	id INT IDENTITY(1,1) NOT NULL,
	nombreCompleto NVARCHAR(75) NOT NULL,
	nombreUsuario NVARCHAR(25) NOT NULL,
	correoElectronico NVARCHAR(100) NOT NULL,
	idRol INT NOT NULL,
	clave VARBINARY(MAX) NOT NULL,
	activo BIT NOT NULL DEFAULT 1,
	fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),

	CONSTRAINT PK_tblUsuarios PRIMARY KEY (id),
	CONSTRAINT UQ_tblUsuarios_nombreUsuario UNIQUE (nombreUsuario),
	CONSTRAINT UQ_tblUsuarios_correoElectronico UNIQUE (correoElectronico),
	CONSTRAINT FK_tblUsuarios_tblRoles FOREIGN KEY (idRol) REFERENCES tblRoles(id)
)
GO

CREATE INDEX IX_tblUsuarios_idRol ON tblUsuarios(idRol) WITH (FILLFACTOR = 80);
GO


-- Categorías
CREATE TABLE tblCategorias (
	id INT IDENTITY(1,1) NOT NULL,
	nombreCategoria NVARCHAR(100) NOT NULL,
	descripcion NVARCHAR(250) NULL,
	activo BIT NOT NULL DEFAULT 1,

	CONSTRAINT PK_tblCategorias PRIMARY KEY (id),
	CONSTRAINT UQ_tblCategorias_nombreCategoria	UNIQUE(nombreCategoria)
)
GO


-- Tickets
CREATE TABLE tblTickets (
	id INT IDENTITY(1,1) NOT NULL,
	numeroTicket NVARCHAR(20) NOT NULL,
	fechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
	fechaUltimaActualizacion DATETIME NULL,
	asunto NVARCHAR(200) NOT NULL,
	descripcion NVARCHAR(MAX) NOT NULL,

	idUsuarioSolicitante INT NOT NULL,
	idTecnicoAsignado INT NULL,

	idCategoria INT NOT NULL,
	prioridad NVARCHAR(20) NOT NULL,
	estado NVARCHAR(20) NOT NULL,

	fechaCierre DATETIME NULL,

	CONSTRAINT PK_tblTickets PRIMARY KEY (id),
	CONSTRAINT UQ_tblTickets_numeroTicket UNIQUE (numeroTicket),
	CONSTRAINT FK_tblTickets_tblUsuarios_Solicitante FOREIGN KEY (idUsuarioSolicitante) REFERENCES tblUsuarios(id),
	CONSTRAINT FK_tblTickets_tblUsuarios_Tecnico FOREIGN KEY (idTecnicoAsignado) REFERENCES tblUsuarios(id),
	CONSTRAINT FK_tblTickets_tblCategorias FOREIGN KEY (idCategoria) REFERENCES tblCategorias(id),
	CONSTRAINT CHK_tblTickets_prioridad CHECK (prioridad IN ('Baja', 'Media', 'Alta', 'Crítica')),
	CONSTRAINT CHK_tblTickets_estado CHECK (estado IN ('Abierto', 'En proceso', 'Cerrado', 'Cancelado'))
)
GO

CREATE INDEX IX_tblTickets_idUsuarioSolicitante ON tblTickets(idUsuarioSolicitante) WITH (FILLFACTOR = 80);
CREATE INDEX IX_tblTickets_idTecnicoAsignado ON tblTickets(idTecnicoAsignado) WITH (FILLFACTOR = 80);
CREATE INDEX IX_tblTickets_idCategoria ON tblTickets(idCategoria) WITH (FILLFACTOR = 80);
CREATE INDEX IX_tblTickets_prioridad ON tblTickets(prioridad) WITH (FILLFACTOR = 80);
CREATE INDEX IX_tblTickets_estado ON tblTickets(estado) WITH (FILLFACTOR = 80);
GO


-- Errores
CREATE TABLE tblLogErrores(
    idLog INT IDENTITY(1,1) NOT NULL,
    mensajeError NVARCHAR(MAX) NOT NULL,
    numeroError INT,
    procedimiento NVARCHAR(100),
    lineaError INT,
    usuarioApp NVARCHAR(25) NOT NULL,
    fechaError DATETIME DEFAULT GETDATE(),

    CONSTRAINT [PK_tblLogErrores] PRIMARY KEY(idLog)
);
GO