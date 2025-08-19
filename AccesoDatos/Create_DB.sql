USE master;
GO

 -- Crear la base de datos
CREATE DATABASE GestionEmpleadosDB;
GO

-- Usar la base de datos creada
USE GestionEmpleadosDB;
GO

-- Tablas con Id autoincrementales

CREATE TABLE Categorias (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  Nombre VARCHAR(50) NULL,
  Descripcion VARCHAR(255) NULL
);

CREATE TABLE Empleados (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  Nombre VARCHAR(50) NULL,
  Apellido VARCHAR(50) NULL,
  FechaNacimiento DATE NULL,
  DNI VARCHAR(20) UNIQUE NULL,
  Imagen VARCHAR(MAX) NULL,
  FechaIngreso DATE NULL,
  IdCategoria INT NOT NULL,
  IdSalario INT NULL,  
  IsActive BIT NULL DEFAULT 1,
  CONSTRAINT FK_Empleados_Categorias FOREIGN KEY (IdCategoria) REFERENCES Categorias(Id),
  CONSTRAINT FK_Empleados_Salarios FOREIGN KEY (IdSalario) REFERENCES Salarios(Id) 
);

CREATE TABLE Salarios (
  Id INT IDENTITY(1,1) PRIMARY KEY, 
  IdCategoria INT NOT NULL,         
  Monto DECIMAL(18,2) NOT NULL,      
  CONSTRAINT FK_Salarios_Categorias  
  FOREIGN KEY (IdCategoria) REFERENCES Categorias(Id)
);

CREATE TABLE TipoBonos (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  Nombre VARCHAR(100) NULL
);
ALTER TABLE TipoBonos
ADD Monto DECIMAL(18, 2) NULL DEFAULT 0;

CREATE TABLE AsignacionBonos (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  IdEmpleado INT NOT NULL,
  IdTipoBono INT NOT NULL,
  FechaAsignacion DATE NULL,
  CONSTRAINT FK_AsignacionBonos_Empleados FOREIGN KEY (IdEmpleado) REFERENCES Empleados(Id),
  CONSTRAINT FK_AsignacionBonos_TipoBonos FOREIGN KEY (IdTipoBono) REFERENCES TipoBonos(Id)
);
ALTER TABLE AsignacionBonos
ADD CONSTRAINT UQ_Empleado_TipoBono UNIQUE (IdEmpleado, IdTipoBono);


CREATE TABLE Proyectos (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  Nombre VARCHAR(100) NULL,
  Descripcion VARCHAR(255) NULL,
  FechaInicio DATE NULL,
  FechaFin DATE NULL,
  Presupuesto DECIMAL(18,2) NULL,
  EstadoProyecto VARCHAR(50) NULL,
  IsActive BIT NULL DEFAULT 1
);

CREATE TABLE AsignacionProyectos (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  IdEmpleado INT NOT NULL,
  IdProyecto INT NOT NULL,
  CONSTRAINT FK_AsignacionProyectos_Empleados FOREIGN KEY (IdEmpleado) REFERENCES Empleados(Id),
  CONSTRAINT FK_AsignacionProyectos_Proyectos FOREIGN KEY (IdProyecto) REFERENCES Proyectos(Id)
);

CREATE TABLE Tareas (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  Nombre VARCHAR(100) NULL,
  Descripcion VARCHAR(255) NULL,
  FechaInicio DATE NULL,
  FechaFin DATE NULL,
  Estado VARCHAR(50) NULL
);

CREATE TABLE TareasProyectos (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  IdTarea INT NOT NULL,
  IdProyecto INT NOT NULL,
  CONSTRAINT FK_TareasProyectos_Tareas FOREIGN KEY (IdTarea) REFERENCES Tareas(Id),
  CONSTRAINT FK_TareasProyectos_Proyectos FOREIGN KEY (IdProyecto) REFERENCES Proyectos(Id),
  CONSTRAINT UQ_TareaProyecto UNIQUE (IdTarea, IdProyecto)
);

CREATE TABLE AsignacionTareas (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  IdTareaProyecto INT NOT NULL, 
  IdEmpleado INT NOT NULL,
  FechaAsignacion DATE NULL,
  CONSTRAINT FK_AsignacionTareas_TareasProyectos FOREIGN KEY (IdTareaProyecto) REFERENCES TareasProyectos(Id),
  CONSTRAINT FK_AsignacionTareas_Empleados FOREIGN KEY (IdEmpleado) REFERENCES Empleados(Id),
  CONSTRAINT UQ_EmpleadoTareaProyecto UNIQUE (IdTareaProyecto, IdEmpleado)
);


CREATE TABLE Roles (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  Nombre VARCHAR(50) NULL,
  Descripcion VARCHAR(255) NULL
);

CREATE TABLE [dbo].[AsignacionRolesProyecto](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [IdEmpleado] [int] NOT NULL,
    [IdRol] [int] NOT NULL,
    [IdProyecto] [int] NOT NULL,
    [FechaAsignacion] [date] NULL,
PRIMARY KEY CLUSTERED ([Id] ASC),
CONSTRAINT [UQ_EmpleadoProyecto] UNIQUE NONCLUSTERED ([IdEmpleado], [IdProyecto]),
CONSTRAINT [FK_AsignacionRolesProyecto_Empleados] FOREIGN KEY([IdEmpleado]) REFERENCES [dbo].[Empleados]([Id]),
CONSTRAINT [FK_AsignacionRolesProyecto_Proyectos] FOREIGN KEY([IdProyecto]) REFERENCES [dbo].[Proyectos]([Id]),
CONSTRAINT [FK_AsignacionRolesProyecto_Roles] FOREIGN KEY([IdRol]) REFERENCES [dbo].[Roles]([Id])
);


CREATE TABLE ReportesFinanzas (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  TotalSalarios DECIMAL(18,2) NULL,
  TotalBonos DECIMAL(18,2) NULL,
  TotalPresupuestosProyectos DECIMAL(18,2) NULL,
  TotalGastos DECIMAL(18,2) NULL,
  FechaGeneracion DATE NULL
);


CREATE TABLE ReportesProyectos (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  IdProyecto INT NOT NULL,
  NombreProyecto VARCHAR(100) NULL,
  Presupuesto DECIMAL(18,2) NULL,
  EstadoProyecto VARCHAR(50) NULL,
  AsignacionesEmpleados VARCHAR(MAX) NULL,
  TareasAsignadas VARCHAR(MAX) NULL,
  RolesAsignados VARCHAR(MAX) NULL,
  TiempoEstimado DECIMAL(18,2) NULL, 
  FechaGeneracion DATE NULL,
  CONSTRAINT FK_ReportesProyectos_Proyectos FOREIGN KEY (IdProyecto) REFERENCES Proyectos(Id)
);


CREATE TABLE ReportesEmpleados (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  IdEmpleado INT NOT NULL,
  NombreEmpleado VARCHAR(100) NULL,
  Categoria VARCHAR(50) NULL,
  SalarioActual DECIMAL(18,2) NULL, 
  TotalBonos DECIMAL(18,2) NULL,
  ProyectosAsignados VARCHAR(MAX) NULL, 
  RolesAsignados VARCHAR(MAX) NULL, 
  TareasAsignadas VARCHAR(MAX) NULL,
  FechaGeneracion DATE NULL,
  CONSTRAINT FK_ReportesEmpleados_Empleados FOREIGN KEY (IdEmpleado) REFERENCES Empleados(Id)
);


CREATE TABLE Usuarios (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  Email VARCHAR(100) UNIQUE NOT NULL,
  PasswordHash VARCHAR(255) NOT NULL,
  Nombre VARCHAR(50) NULL,
  Apellido VARCHAR(50) NULL,
  ImagenPerfil VARCHAR(MAX) NULL,
  Admin BIT NOT NULL DEFAULT 0
);


CREATE TABLE Clientes (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  Nombre VARCHAR(100) NULL,
  Email VARCHAR(100) UNIQUE NULL,
  Telefono VARCHAR(20) NULL,
  Direccion VARCHAR(255) NULL
);

CREATE TABLE AsignacionClientesProyectos (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  IdCliente INT NOT NULL,
  IdProyecto INT NOT NULL,
  FechaAsignacion DATE NULL,
  CONSTRAINT FK_AsignacionClientesProyectos_Clientes FOREIGN KEY (IdCliente) REFERENCES Clientes(Id),
  CONSTRAINT FK_AsignacionClientesProyectos_Proyectos FOREIGN KEY (IdProyecto) REFERENCES Proyectos(Id)
);
