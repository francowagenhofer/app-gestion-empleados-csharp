

-- STORED PROCEDURE - Creacion de stored procedure para las distintas funciones y consultas requeridas.

------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------

-- EMPLEADOS

-- Listar empleado
ALTER PROCEDURE [dbo].[ListarEmpleados] -- Mejorado ...
AS
BEGIN
    SELECT 
        E.Id,
        E.Nombre,
        E.Apellido,
        E.FechaNacimiento,
        E.DNI,
        E.Imagen,
        E.FechaIngreso,
        E.IsActive,
        C.Nombre AS NombreCategoria,   -- Devuelve el nombre de la categoría en lugar del IdCategoria
        S.Monto AS MontoSalario         -- Devuelve el monto del salario desde la tabla Salarios
    FROM Empleados E
    LEFT JOIN Categorias C ON E.IdCategoria = C.Id    -- Relación con Categorias
    LEFT JOIN Salarios S ON E.IdSalario = S.Id        -- Relación con Salarios
END


-- Agregar empleado 
ALTER PROCEDURE AgregarEmpleado
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @FechaNacimiento DATE,
    @DNI VARCHAR(20),
    @Imagen VARCHAR(MAX) = NULL,
    @FechaIngreso DATE,
    @IdCategoria INT,
    @IdSalario INT = NULL,
    @IsActive BIT
AS
BEGIN
    INSERT INTO Empleados
    (Nombre, Apellido, FechaNacimiento, DNI, Imagen, FechaIngreso, IdCategoria, IdSalario, IsActive)
    VALUES
    (@Nombre, @Apellido, @FechaNacimiento, @DNI, @Imagen, @FechaIngreso, @IdCategoria, @IdSalario, @IsActive);
END


-- Modificar empleado
Alter PROCEDURE ModificarEmpleado
    @Id INT,
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @FechaNacimiento DATE,
    @DNI VARCHAR(20),
    @Imagen VARCHAR(MAX) = NULL,
    @FechaIngreso DATE,
    @IdCategoria INT,
    @IdSalario INT = NULL,
    @IsActive BIT
AS
BEGIN
    UPDATE Empleados
    SET 
        Nombre = @Nombre,
        Apellido = @Apellido,
        FechaNacimiento = @FechaNacimiento,
        DNI = @DNI,
        Imagen = @Imagen,
        FechaIngreso = @FechaIngreso,
        IdCategoria = @IdCategoria,
        IdSalario = @IdSalario,
        IsActive = @IsActive
    WHERE Id = @Id;
END



-- Eliminar empleado
CREATE PROCEDURE EliminarEmpleado
    @Id INT
AS
BEGIN
    DELETE FROM Empleados
    WHERE Id = @Id;
END;


-- desasignar empleado de todos los proyectos para eliminar 
alter PROCEDURE DesasignarEmpleadoDeTodosLosProyectos
    @IdEmpleado INT
AS
BEGIN
    -- Elimina todas las asignaciones de proyectos para el empleado dad<<so
    DELETE FROM AsignacionProyectos WHERE IdEmpleado = @IdEmpleado;
END;


-- Actualizar Estado Activo-Inactivo
CREATE PROCEDURE ActualizarEstadoEmpleado
    @Id INT,
    @IsActive BIT
AS
BEGIN
    UPDATE Empleados
    SET IsActive = @IsActive
    WHERE Id = @Id;
END


------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------
------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------
------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------

-- SALARIOS 

CREATE PROCEDURE ListarSalarios
AS
BEGIN
    SELECT Id, IdCategoria, Monto
    FROM Salarios;
END

Alter PROCEDURE ListarSalarios
AS
BEGIN
    SELECT S.Id, S.IdCategoria, S.Monto, C.Nombre AS NombreCategoria
    FROM Salarios S
    JOIN Categorias C ON S.IdCategoria = C.Id;
END




CREATE PROCEDURE AgregarSalario
    @IdCategoria INT,
    @Monto DECIMAL(18,2)
AS
BEGIN
    INSERT INTO Salarios (IdCategoria, Monto)
    VALUES (@IdCategoria, @Monto);
END


CREATE PROCEDURE ModificarSalario
    @Id INT,
    @IdCategoria INT,
    @Monto DECIMAL(18,2)
AS
BEGIN
    UPDATE Salarios
    SET IdCategoria = @IdCategoria,
        Monto = @Monto
    WHERE Id = @Id;
END


CREATE PROCEDURE EliminarSalario
    @Id INT
AS
BEGIN
    DELETE FROM Salarios
    WHERE Id = @Id;
END


------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------
------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------
------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------

-- BONOS 

-- listar bonos
CREATE PROCEDURE ListarBonos
AS
BEGIN
    SELECT Id, Nombre, Monto
    FROM TipoBonos;
END

-- modificar bonos 
CREATE PROCEDURE ModificarBono
    @Id INT,
    @Monto DECIMAL(18, 2)
AS
BEGIN
    UPDATE TipoBonos
    SET Monto = @Monto
    WHERE Id = @Id;
END

-- agregar bono 
CREATE PROCEDURE AgregarBono
    @Nombre VARCHAR(100),
    @Monto DECIMAL(18, 2)
AS
BEGIN
    INSERT INTO TipoBonos (Nombre, Monto)
    VALUES (@Nombre, @Monto);
END

-- eliminar bono
CREATE PROCEDURE EliminarBono
    @Id INT
AS
BEGIN
    DELETE FROM TipoBonos
    WHERE Id = @Id;
END

-- asignar bono 
CREATE PROCEDURE AsignarBonoAEmpleado
    @IdEmpleado INT,
    @IdTipoBono INT,
    @FechaAsignacion DATE
AS
BEGIN
    INSERT INTO AsignacionBonos (IdEmpleado, IdTipoBono, FechaAsignacion)
    VALUES (@IdEmpleado, @IdTipoBono, @FechaAsignacion);
END

-- desasignar bono
CREATE PROCEDURE DesasignarBonoDeEmpleado
    @IdEmpleado INT,
    @IdTipoBono INT
AS
BEGIN
    DELETE FROM AsignacionBonos
    WHERE IdEmpleado = @IdEmpleado AND IdTipoBono = @IdTipoBono;
END


-- listar asignaciones de bonos
alter PROCEDURE ListarBonosAsignadosEmpleado
    @IdEmpleado INT
AS
BEGIN
    -- Seleccionamos los bonos asignados a un empleado específico
    SELECT 
        ab.Id AS AsignacionId,          -- ID de la asignación
        tb.Id AS BonoId,                -- ID del tipo de bono
        tb.Nombre,        -- Nombre del bono
        tb.Monto,                       -- Monto del bono
        ab.FechaAsignacion              -- Fecha de asignación del bono
    FROM AsignacionBonos ab
    INNER JOIN TipoBonos tb ON ab.IdTipoBono = tb.Id      -- Relación con la tabla de TipoBonos
    INNER JOIN Empleados e ON ab.IdEmpleado = e.Id        -- Relación con la tabla de Empleados
    WHERE ab.IdEmpleado = @IdEmpleado
    ORDER BY ab.FechaAsignacion DESC;  -- Opcional, para ordenar por la fecha más reciente
END


------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------
------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------
------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------

-- PROYECTOS

-- Listar Poryectos
CREATE PROCEDURE ListarProyectos
AS
BEGIN
    SELECT 
        Id,
        Nombre,
        Descripcion,
        FechaInicio,
        FechaFin,
        Presupuesto,
        EstadoProyecto,
        IsActive
    FROM 
        Proyectos
END


-- Agregar Proyectos
CREATE PROCEDURE AgregarProyecto
    @Nombre VARCHAR(100),
    @Descripcion VARCHAR(255),
    @FechaInicio DATE,
    @FechaFin DATE,
    @Presupuesto DECIMAL(18,2),
    @EstadoProyecto VARCHAR(50)
AS
BEGIN
    INSERT INTO Proyectos (Nombre, Descripcion, FechaInicio, FechaFin, Presupuesto, EstadoProyecto, IsActive)
    VALUES (
        @Nombre,
        @Descripcion,
        @FechaInicio,
        @FechaFin,
        @Presupuesto,
        @EstadoProyecto,
        1 -- El proyecto se agrega como activo por defecto
    )
END


-- Modificar Proyectos
CREATE PROCEDURE ModificarProyecto
    @Id INT,
    @Nombre VARCHAR(100),
    @Descripcion VARCHAR(255),
    @FechaInicio DATE,
    @FechaFin DATE,
    @Presupuesto DECIMAL(18,2),
    @EstadoProyecto VARCHAR(50),
    @IsActive BIT
AS
BEGIN
    UPDATE Proyectos
    SET 
        Nombre = @Nombre,
        Descripcion = @Descripcion,
        FechaInicio = @FechaInicio,
        FechaFin = @FechaFin,
        Presupuesto = @Presupuesto,
        EstadoProyecto = @EstadoProyecto,
        IsActive = @IsActive
    WHERE 
        Id = @Id
END

-- Eliminar Poryecto
Alter PROCEDURE EliminarProyecto
    @Id INT
AS
BEGIN
    Delete from Proyectos
    WHERE Id = @Id;
END
--CREATE PROCEDURE EliminarProyecto
--    @Id INT
--AS
--BEGIN
--    UPDATE Proyectos
--    SET IsActive = 0
--    WHERE Id = @Id
--END ----------------------- este es para desactivar un proyecto (eliminar logico)


-- Actualizar Estado Proyecto
CREATE PROCEDURE ActualizarEstadoProyecto
    @Id INT,
    @IsActive BIT
AS
BEGIN
    UPDATE Proyectos
    SET IsActive = @IsActive
    WHERE Id = @Id
END

-- Asignar Proyecto
CREATE PROCEDURE AsignarEmpleadoAProyecto
    @IdEmpleado INT,
    @IdProyecto INT
AS
BEGIN
    INSERT INTO AsignacionProyectos (
        IdEmpleado,
        IdProyecto
    )
    VALUES (
        @IdEmpleado,
        @IdProyecto
    )
END

-- Desasignar Proyectos
CREATE PROCEDURE DesasignarEmpleadoDeProyecto
    @IdEmpleado INT,
    @IdProyecto INT
AS
BEGIN
    DELETE FROM AsignacionProyectos
    WHERE IdEmpleado = @IdEmpleado
    AND IdProyecto = @IdProyecto
END


 -- Lista de empleados asignados a x proyecto 
CREATE PROCEDURE ListarEmpleadosAsignadosAlProyecto
    @IdProyecto INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        e.Id,
        e.Nombre,
        e.Apellido,
        e.DNI,
        e.FechaIngreso,
        e.IsActive AS EmpleadoActivo
    FROM 
        AsignacionProyectos ap
    INNER JOIN 
        Empleados e ON ap.IdEmpleado = e.Id
    WHERE 
        ap.IdProyecto = @IdProyecto;
END;

-- Lista de proyectos asignados a X empleado

CREATE PROCEDURE ListarProyectosAsignadosEmpleado
    @IdEmpleado INT
AS
BEGIN
    SELECT 
        p.Id AS ProyectoId, 
        p.Nombre,
        p.Descripcion
    FROM AsignacionProyectos ap
    INNER JOIN Proyectos p ON ap.IdProyecto = p.Id
    WHERE ap.IdEmpleado = @IdEmpleado;
END



------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------
------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------
------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------

--ROLES 

-- lista de roles

CREATE PROCEDURE ListarTodosLosRoles
AS
BEGIN
    SELECT Id, Nombre, Descripcion
    FROM Roles;
END


-- lista de roles de empleados asignados en un proyecto

CREATE PROCEDURE ListarRolesDeEmpleadosEnProyecto
    @IdProyecto INT
AS
BEGIN
    SELECT DISTINCT r.Id AS IdRol, r.Nombre, r.Descripcion
    FROM Roles r
    INNER JOIN AsignacionRolesProyecto ar ON r.Id = ar.IdRol
    WHERE ar.IdProyecto = @IdProyecto;
END;


-- crear rol 
CREATE PROCEDURE CrearRol
@Nombre VARCHAR(50),
@Descripcion VARCHAR(255)
AS
BEGIN
INSERT INTO Roles(Nombre, Descripcion)
VALUES(@Nombre, @Descripcion);
END;


-- modificar rol 
alter PROCEDURE ModificarRol
@Id INT,
@Nombre VARCHAR(50),
@Descripcion VARCHAR(255)
AS
BEGIN
UPDATE Roles
SET Nombre = @Nombre, Descripcion = @Descripcion
WHERE Id = @Id;
END;



-- eliminar rol
CREATE PROCEDURE EliminarRol
    @IdRol INT
AS
BEGIN
    -- Eliminar asignaciones de empleados a este rol en proyectos
    DELETE FROM AsignacionRolesProyecto
    WHERE IdRol = @IdRol;

    -- Finalmente, eliminar el rol
    DELETE FROM Roles
    WHERE Id = @IdRol;
END;


-- asignar rol 
CREATE PROCEDURE AsignarRolAEmpleadoEnProyecto
    @IdEmpleado INT,
    @IdRol INT,
    @IdProyecto INT,
    @FechaAsignacion DATE
AS
BEGIN
    INSERT INTO AsignacionRolesProyecto (IdEmpleado, IdRol, IdProyecto, FechaAsignacion)
    VALUES (@IdEmpleado, @IdRol, @IdProyecto, @FechaAsignacion);
END


-- desasignar rol 
CREATE PROCEDURE DesasignarRolDeEmpleadoEnProyecto
    @IdEmpleado INT,
    @IdProyecto INT
AS
BEGIN
    DELETE FROM AsignacionRolesProyecto
    WHERE IdEmpleado = @IdEmpleado AND IdProyecto = @IdProyecto;
END

-- Informacion Rol
CREATE PROCEDURE ObtenerInformacionRol
    @IdRol INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        r.Id AS RolId,
        r.Nombre AS RolNombre,
        r.Descripcion AS RolDescripcion,
        p.Id AS ProyectoId,
        p.Nombre AS ProyectoNombre,
        e.Id AS EmpleadoId,
        e.Nombre AS EmpleadoNombre,
        e.Apellido AS EmpleadoApellido
    FROM 
        Roles r
    LEFT JOIN 
        AsignacionRolesProyecto arp ON r.Id = arp.IdRol
    LEFT JOIN 
        Proyectos p ON arp.IdProyecto = p.Id
    LEFT JOIN 
        Empleados e ON arp.IdEmpleado = e.Id
    WHERE 
        r.Id = @IdRol;
END


------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------
------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------
------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------

-- TAREAS 

-- listar tareas
CREATE PROCEDURE ListarTodasLasTareas
AS
BEGIN
    SELECT * 
    FROM Tareas;
END;


-- listar tareas de un proyecto

CREATE PROCEDURE ObtenerInformacionTarea
    @IdTarea INT
AS
BEGIN
    SELECT *
    FROM Tareas
    WHERE Id = @IdTarea;
END;


-- listar tareas asignadas a un proyecto
alter PROCEDURE ListarTareasAsignadasAProyecto
    @IdProyecto INT
AS
BEGIN
    SELECT T.Id AS IdTarea, T.Nombre, T.Descripcion, T.FechaInicio, T.FechaFin, T.Estado
    FROM Tareas T
    INNER JOIN TareasProyectos TP ON T.Id = TP.IdTarea
    WHERE TP.IdProyecto = @IdProyecto;
END


-- listar empleado asignados a tarea 
CREATE PROCEDURE ListarEmpleadosAsignadosATarea
    @IdTarea INT,
    @IdProyecto INT
AS
BEGIN
    SELECT E.Id, E.Nombre, E.Apellido
    FROM Empleados E
    INNER JOIN AsignacionTareas AT ON E.Id = AT.IdEmpleado
    INNER JOIN TareasProyectos TP ON AT.IdTareaProyecto = TP.Id
    WHERE TP.IdTarea = @IdTarea AND TP.IdProyecto = @IdProyecto;
END



--Informacion tarea

ALTER PROCEDURE ObtenerInformacionTarea
    @IdTarea INT
AS
BEGIN
    SELECT 
        t.Id AS TareaId,
        t.Nombre AS TareaNombre,
        t.Descripcion AS TareaDescripcion,
        p.Id AS ProyectoId,
        p.Nombre AS ProyectoNombre,
        e.Id AS EmpleadoId,
        e.Nombre AS EmpleadoNombre,
        e.Apellido AS EmpleadoApellido
    FROM 
        Tareas t
    LEFT JOIN 
        TareasProyectos tp ON t.Id = tp.IdTarea
    LEFT JOIN 
        Proyectos p ON tp.IdProyecto = p.Id
    LEFT JOIN 
        AsignacionTareas at ON tp.Id = at.IdTareaProyecto
    LEFT JOIN 
        Empleados e ON at.IdEmpleado = e.Id
    WHERE 
        t.Id = @IdTarea
END


-- agregar tarea 
CREATE PROCEDURE AgregarTarea
    @Nombre VARCHAR(100),
    @Descripcion VARCHAR(255),
    @FechaInicio DATE,
    @FechaFin DATE,
    @Estado VARCHAR(50)
AS
BEGIN
    INSERT INTO Tareas (Nombre, Descripcion, FechaInicio, FechaFin, Estado)
    VALUES (@Nombre, @Descripcion, @FechaInicio, @FechaFin, @Estado);
END;

-- modificar tarea 
CREATE PROCEDURE ModificarTarea
    @IdTarea INT,
    @Nombre VARCHAR(100),
    @Descripcion VARCHAR(255),
    @FechaInicio DATE,
    @FechaFin DATE,
    @Estado VARCHAR(50)
AS
BEGIN
    UPDATE Tareas
    SET Nombre = @Nombre, 
        Descripcion = @Descripcion, 
        FechaInicio = @FechaInicio, 
        FechaFin = @FechaFin, 
        Estado = @Estado
    WHERE Id = @IdTarea;
END;


-- eliminar tarea 
CREATE PROCEDURE EliminarTarea
    @IdTarea INT
AS
BEGIN
    DELETE FROM AsignacionTareas
    WHERE IdTareaProyecto = @IdTarea;

    DELETE FROM Tareas
    WHERE Id = @IdTarea;
END;


-- asignar tarea a proyecto
CREATE PROCEDURE AsignarTareaAProyecto
    @IdTarea INT,
    @IdProyecto INT
AS
BEGIN
    INSERT INTO TareasProyectos (IdTarea, IdProyecto)
    VALUES (@IdTarea, @IdProyecto);
END



-- asignar tarea 
alter PROCEDURE AsignarTareaAEmpleadoEnProyecto
    @IdTareaProyecto INT,
    @IdEmpleado INT,
	@IdProyecto INT,
    @FechaAsignacion DATE
AS
BEGIN
    INSERT INTO AsignacionTareas (IdTareaProyecto, IdEmpleado, IdProyecto, FechaAsignacion)
    VALUES (@IdTareaProyecto, @IdEmpleado, @IdProyecto, @FechaAsignacion);
END

-- verifica las tareas
CREATE PROCEDURE VerificarAsignacionTareaEmpleado
    @IdTarea INT,
    @IdEmpleado INT
AS
BEGIN
    SELECT 1
    FROM AsignacionTareas
    WHERE IdTareaProyecto = @IdTarea AND IdEmpleado = @IdEmpleado
END



-- desasignar tarea a empleado
alter PROCEDURE DesasignarTareaDeEmpleadoEnProyecto
    @IdTareaProyecto INT,
    @IdEmpleado INT
AS
BEGIN
    DELETE FROM AsignacionTareas
    WHERE IdTareaProyecto = @IdTareaProyecto AND IdEmpleado = @IdEmpleado;
END



-- desasignar tarea de proyecto
create PROCEDURE DesasignarTareaDeProyecto
    @IdTarea INT,
    @IdProyecto INT
AS
BEGIN
    DELETE FROM TareasProyectos
    WHERE IdTarea = @IdTarea AND IdProyecto = @IdProyecto;
END


------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------
------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------
------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------

-- REPORTES: reporte de empleado, de proyecto y de finanzas.

-- Reporte Empelados

-- obtener reporte de empleado
CREATE PROCEDURE ObtenerReportesEmpleados
AS
BEGIN
    SELECT 
        Id,
        IdEmpleado,
        NombreEmpleado,
        Categoria,
        SalarioActual,
        TotalBonos,
        ProyectosAsignados,
        RolesAsignados,
        TareasAsignadas,
        FechaGeneracion
    FROM 
        ReportesEmpleados;
END


-- generar reporte de empleado
create PROCEDURE GenerarReporteEmpleado
    @IdEmpleado INT
AS
BEGIN
    INSERT INTO ReportesEmpleados (IdEmpleado, NombreEmpleado, Categoria, SalarioActual, TotalBonos, ProyectosAsignados, RolesAsignados, TareasAsignadas, FechaGeneracion)
    SELECT 
        e.Id,
        CONCAT(e.Nombre, ' ', e.Apellido) AS NombreEmpleado,
        c.Nombre AS Categoria,
        s.Monto AS SalarioActual,
        ISNULL(SUM(tb.Monto), 0) AS TotalBonos,
        (SELECT STRING_AGG(p.Nombre, ', ') 
         FROM AsignacionProyectos ap 
         JOIN Proyectos p ON ap.IdProyecto = p.Id 
         WHERE ap.IdEmpleado = e.Id) AS ProyectosAsignados,
        (SELECT STRING_AGG(r.Nombre, ', ') 
         FROM AsignacionRolesProyecto arp 
         JOIN Roles r ON arp.IdRol = r.Id 
         WHERE arp.IdEmpleado = e.Id) AS RolesAsignados,
        (SELECT STRING_AGG(t.Nombre, ', ') 
         FROM AsignacionTareas at 
         JOIN Tareas t ON at.IdTareaProyecto = t.Id 
         WHERE at.IdEmpleado = e.Id) AS TareasAsignadas,
        GETDATE() AS FechaGeneracion
    FROM Empleados e
    JOIN Categorias c ON e.IdCategoria = c.Id
    LEFT JOIN Salarios s ON e.IdSalario = s.Id
    LEFT JOIN AsignacionBonos ab ON e.Id = ab.IdEmpleado
    LEFT JOIN TipoBonos tb ON ab.IdTipoBono = tb.Id
    WHERE e.Id = @IdEmpleado
    GROUP BY e.Id, e.Nombre, e.Apellido, c.Nombre, s.Monto;
END;



-- modificar reporte de empleado

CREATE PROCEDURE ModificarReporteEmpleados
    @Id INT,
    @IdEmpleado INT,
    @NombreEmpleado VARCHAR(100),
    @Categoria VARCHAR(50),
    @SalarioActual DECIMAL(18, 2),
    @TotalBonos DECIMAL(18, 2),
    @ProyectosAsignados VARCHAR(MAX),
    @RolesAsignados VARCHAR(MAX),
    @TareasAsignadas VARCHAR(MAX),
    @FechaGeneracion DATE
AS
BEGIN
    UPDATE ReportesEmpleados
    SET 
        IdEmpleado = @IdEmpleado,
        NombreEmpleado = @NombreEmpleado,
        Categoria = @Categoria,
        SalarioActual = @SalarioActual,
        TotalBonos = @TotalBonos,
        ProyectosAsignados = @ProyectosAsignados,
        RolesAsignados = @RolesAsignados,
        TareasAsignadas = @TareasAsignadas,
        FechaGeneracion = @FechaGeneracion
    WHERE Id = @Id;
END



-- eliminar reporte de empleado
CREATE PROCEDURE EliminarReporteEmpleados
    @Id INT
AS
BEGIN
    DELETE FROM ReportesEmpleados
    WHERE Id = @Id;
END


------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------

-- Reporte Proyectos

-- obtener reporte de proyecto
CREATE PROCEDURE ObtenerReportesProyectos
AS
BEGIN
    SELECT 
        Id,
        IdProyecto,
        NombreProyecto,
        Presupuesto,
        EstadoProyecto,
        AsignacionesEmpleados,
        TareasAsignadas,
        RolesAsignados,
        TiempoEstimado,
        FechaGeneracion
    FROM 
        ReportesProyectos;
END


-- generar reporte de proyecto
CREATE PROCEDURE GenerarReporteProyecto
    @IdProyecto INT
AS
BEGIN
    INSERT INTO ReportesProyectos (IdProyecto, NombreProyecto, Presupuesto, EstadoProyecto, TiempoEstimado, AsignacionesEmpleados, RolesAsignados, TareasAsignadas, FechaGeneracion)
    SELECT 
        p.Id,
        p.Nombre,
        p.Presupuesto,
        p.EstadoProyecto,
        SUM(s.Monto) AS TiempoEstimado, -- Cambia a TiempoEstimado si es lo que deseas
        STRING_AGG(CONCAT(e.Nombre, ' ', e.Apellido), ', ') AS AsignacionesEmpleados,
        STRING_AGG(r.Nombre, ', ') AS RolesAsignados,
        STRING_AGG(t.Nombre, ', ') AS TareasAsignadas,
        GETDATE() AS FechaGeneracion
    FROM Proyectos p
    LEFT JOIN AsignacionProyectos ap ON p.Id = ap.IdProyecto
    LEFT JOIN Empleados e ON ap.IdEmpleado = e.Id
    LEFT JOIN AsignacionRolesProyecto arp ON p.Id = arp.IdProyecto
    LEFT JOIN Roles r ON arp.IdRol = r.Id
    LEFT JOIN AsignacionTareas at ON at.IdEmpleado = e.Id
    LEFT JOIN Tareas t ON at.IdTareaProyecto = t.Id
    LEFT JOIN Salarios s ON e.IdSalario = s.Id
    WHERE p.Id = @IdProyecto
    GROUP BY p.Id, p.Nombre, p.Presupuesto, p.EstadoProyecto;
END



-- modificar reporte de proyecto
CREATE PROCEDURE ModificarReporteProyectos
    @Id INT,
    @IdProyecto INT,
    @NombreProyecto VARCHAR(100),
    @Presupuesto DECIMAL(18, 2),
    @EstadoProyecto VARCHAR(50),
    @AsignacionesEmpleados VARCHAR(MAX),
    @TareasAsignadas VARCHAR(MAX),
    @RolesAsignados VARCHAR(MAX),
    @TiempoEstimado DECIMAL(18, 2),
    @FechaGeneracion DATE
AS
BEGIN
    UPDATE ReportesProyectos
    SET 
        IdProyecto = @IdProyecto,
        NombreProyecto = @NombreProyecto,
        Presupuesto = @Presupuesto,
        EstadoProyecto = @EstadoProyecto,
        AsignacionesEmpleados = @AsignacionesEmpleados,
        TareasAsignadas = @TareasAsignadas,
        RolesAsignados = @RolesAsignados,
        TiempoEstimado = @TiempoEstimado,
        FechaGeneracion = @FechaGeneracion
    WHERE Id = @Id;
END


-- eliminar reporte de proyecto

CREATE PROCEDURE EliminarReporteProyectos
    @Id INT
AS
BEGIN
    DELETE FROM ReportesProyectos
    WHERE Id = @Id;
END

------ ### ------- ### ------ #### -------------- ### ------- ### ------ #### -------------- ### ------- ### ------ #### --------
-- Reporte Finanzas

-- obtener reporte de finanzas
CREATE PROCEDURE ObtenerReportesFinanzas
AS
BEGIN
    SELECT 
        Id,
        TotalSalarios,
        TotalBonos,
        TotalPresupuestosProyectos,
        TotalGastos,
        FechaGeneracion
    FROM 
        ReportesFinanzas;
END

-- generar reporte de finanzas
CREATE PROCEDURE GenerarReporteFinanzas
AS
BEGIN
    INSERT INTO ReportesFinanzas (TotalSalarios, TotalBonos, TotalPresupuestosProyectos, TotalGastos, FechaGeneracion)
    SELECT 
        SUM(s.Monto) AS TotalSalarios,
        SUM(tb.Monto) AS TotalBonos,
        SUM(p.Presupuesto) AS TotalPresupuestosProyectos,
        (SUM(s.Monto) + SUM(tb.Monto) + SUM(p.Presupuesto)) AS TotalGastos,
        GETDATE() AS FechaGeneracion
    FROM Empleados e
    LEFT JOIN Salarios s ON e.IdSalario = s.Id
    LEFT JOIN AsignacionBonos ab ON e.Id = ab.IdEmpleado
    LEFT JOIN TipoBonos tb ON ab.IdTipoBono = tb.Id
    LEFT JOIN Proyectos p ON p.Id = e.Id; -- Proyectos asignados a empleados
END

-- modificar reporte de finanzas

CREATE PROCEDURE ModificarReporteFinanzas
    @Id INT,
    @TotalSalarios DECIMAL(18, 2),
    @TotalBonos DECIMAL(18, 2),
    @TotalPresupuestosProyectos DECIMAL(18, 2),
    @FechaGeneracion DATE
AS
BEGIN
    UPDATE ReportesFinanzas
    SET 
        TotalSalarios = @TotalSalarios,
        TotalBonos = @TotalBonos,
        TotalPresupuestosProyectos = @TotalPresupuestosProyectos,
        TotalGastos = @TotalSalarios + @TotalBonos + @TotalPresupuestosProyectos, 
        FechaGeneracion = @FechaGeneracion
    WHERE Id = @Id;
END



-- eliminar reporte de finanzas

CREATE PROCEDURE EliminarReporteFinanzas
    @Id INT
AS
BEGIN
    DELETE FROM ReportesFinanzas
    WHERE Id = @Id;
END
