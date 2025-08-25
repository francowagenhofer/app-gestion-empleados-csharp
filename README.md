# 💼 Sistema de Gestión de Empleados - App Consola + Escritorio (C# + SQL Server)

![Gestión Pyme]

Aplicación para la gestión de **empleados, proyectos, tareas, roles, salarios y reportes**, desarrollada en **C# con .NET**.  
Incluye **interfaz de consola** y **opcional interfaz de escritorio (WinForms)**, conectada a **SQL Server**.

---

## 🚀 Características principales
- Gestión de empleados: agregar, modificar, ver detalles, eliminar y asignar a proyectos, roles y tareas.  
- Gestión de proyectos: agregar, modificar, ver detalles, eliminar y asignar empleados, roles y tareas.  
- Gestión de roles y tareas: agregar, modificar, ver detalles y eliminar.  
- Gestión de salarios y bonos: administrar sueldos y extras.  
- Reportes: visualizar y generar reportes.  
- Todos los formularios y pantallas incluyen listados para facilitar la navegación y gestión.

---

## 📂 Estructura del proyecto
- `AppConsola-GestionDeEmpleados/` → Consola  
- `AppEscritorio_GestionDeEmpleados/` → Formularios WinForms  
- `Negocio/` → Lógica de negocio  
- `Dominio/` → Clases y entidades  
- `AccesoDatos/` → Scripts de la base de datos  
- `Imagenes/` → Recursos gráficos (logo, screenshots)  
- `SistemaDeGestiónDeEmpleados.sln` → Solución de Visual Studio

---

## 🗄️ Base de datos
- Utiliza **SQL Server Express**.  
- **Cadena de conexión** (en `AccesoDatos.cs`):

`public AccesoDatos()
{
    conexion = new SqlConnection("server=.\\SQLEXPRESS; database=GestionEmpleadosDB; integrated security=true");
    comando = new SqlCommand();
}
`
Incluye **script de creación de base de datos** y datos iniciales (`.sql`).  

Los **procedimientos almacenados** no están implementados.  

> Antes de ejecutar la app, crear la base de datos ejecutando el script en SQL Server Management Studio o similar.

---

## ⚙️ Requisitos
- Windows 10/11  
- [.NET Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)  
- SQL Server Express (o instancia local de SQL Server)

---

## ▶️ Ejecución

### Consola
1. Abrir la solución en Visual Studio.  
2. Establecer `AppConsola-GestionDeEmpleados` como proyecto de inicio.  
3. Compilar y ejecutar.

### Escritori
1. Abrir la solución en Visual Studio.  
2. Establecer `AppEscritorio_GestionDeEmpleados` como proyecto de inicio.  
3. Compilar y ejecutar.

---

## 📝 Notas
- La aplicación está diseñada para **uso local**, conectada a SQL Server.  
- La base de datos puede crearse en cualquier instancia local siguiendo el script proporcionado.  
- Se puede ampliar con **procedimientos almacenados**, mejoras en **reportes** y nuevas funcionalidades en la UI.
