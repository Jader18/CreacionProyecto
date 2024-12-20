USE master
CREATE DATABASE Inventario
GO
USE Inventario
GO
CREATE TABLE Roles(
IdRol SMALLINT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Rol VARCHAR(50) NOT NULL,
Activo BIT DEFAULT(1) NOT NULL,
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)
GO
CREATE TABLE Usuarios
(
IdUsuario INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
NombreCompleto VARCHAR(200) NOT NULL,
Correo VARCHAR(200) NOT NULL,
UserName VARCHAR(50) NOT NULL,
Password VARBINARY(MAX) NOT NULL,
Bloqueado BIT NOT NULL,
IntentosFallidos TINYINT NOT NULL DEFAULT(0),
IdRol SMALLINT FOREIGN KEY REFERENCES Roles(IdRol),
Activo BIT DEFAULT(1) NOT NULL,
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)
GO
CREATE TABLE Formularios(
IdFormulario INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Formulario VARCHAR(50) NOT NULL,
Activo BIT DEFAULT(1) NOT NULL,
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)
GO
CREATE TABLE Permisos(
IdPermiso INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Permiso VARCHAR(50) NOT NULL,
Activo BIT DEFAULT(1) NOT NULL,
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)
CREATE TABLE RolFormularios
(
IdRolFormulario INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
IdRol SMALLINT FOREIGN KEY REFERENCES Roles(IdRol) NOT NULL,
IdFormulario INT FOREIGN KEY REFERENCES Formularios(IdFormulario) NOT NULL,
Activo BIT DEFAULT(1) NOT NULL,
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)
GO
CREATE TABLE RolPermisos
(
IdRolPermiso INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
IdRol SMALLINT FOREIGN KEY REFERENCES Roles(IdRol) NOT NULL,
IdPermiso INT FOREIGN KEY REFERENCES Permisos(IdPermiso) NOT NULL,
IdRolForumulario INT FOREIGN KEY REFERENCES RolFormularios(IdRolFormulario) NOT NULL,
Activo BIT DEFAULT(1) NOT NULL,
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)
GO
CREATE TABLE Clientes(
IdCliente INT PRIMARY KEY IDENTITY(1,1),
NombreCliente VARCHAR(200),
Numero VARCHAR(10),
Correo	VARCHAR(200),
Activo BIT DEFAULT(1) NOT NULL,
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)
GO
CREATE TABLE Productos(
IdProducto INT PRIMARY KEY IDENTITY(1,1),
Descripcion VARCHAR(200),
--agregar cantidad de cada item
Cantidad VARCHAR(8) NOT NULL,
Activo BIT DEFAULT(1) NOT NULL,
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)

--agregar una nueva tabla para proveedores 
CREATE TABLE Proveedores(
IdProveedor INT PRIMARY KEY IDENTITY(1,1),
NombreProveedor VARCHAR(200),
Numero VARCHAR(10),
Correo	VARCHAR(200),
Direccion VARCHAR(200),
Activo BIT DEFAULT(1) NOT NULL,
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)


-- Modificar la tabla Productos para agregar la relaci�n con Proveedores
ALTER TABLE Productos
ADD IdProveedor INT FOREIGN KEY REFERENCES Proveedores(IdProveedor) NOT NULL;

