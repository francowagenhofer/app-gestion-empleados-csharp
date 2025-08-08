using System;
using System.Collections.Generic;
using AppConsola;
using AppConsola.LogicaAppConsola;
using Dominio;
using Dominio.Entidades;
using Dominio.Entidades.Dominio.Entidades;
using negocio;
using Negocio;

namespace AppDeConsola
{
    public class InterfazAppConsola
    {
        public static List<Empleado> empleados = new List<Empleado>();
        public static List<Proyectos> proyectos = new List<Proyectos>();

        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    MostrarEncabezado("Menú Principal");

                    Console.WriteLine("1. Gestión de Empleados");
                    Console.WriteLine("2. Gestión de Proyectos");
                    Console.WriteLine("3. Gestión de Operaciones");
                    Console.WriteLine("4. Reportes");
                    Console.WriteLine("\n5. Salir");

                    Console.Write("\nSelecciona una opción: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            MenuGestionEmpleados();
                            break;
                        case "2":
                            MenuGestionDeProyectos();
                            break;
                        case "3":
                            MenuOperaciones();
                            break;
                        case "4":
                            MenuReportes();
                            break;
                        case "5":
                            return;
                        default:
                            MostrarError("Opción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MostrarError($"Error inesperado: {ex.Message}");
                }
            }
        }

        public static void MenuGestionEmpleados()
        {
            while (true)
            {
                try
                {
                    MostrarEncabezado("Gestión de Empleados");

                    Console.WriteLine("1. Ver lista de empleados registrados");
                    Console.WriteLine("2. Buscar detalles de un empleado específico");
                    Console.WriteLine("3. Registrar un nuevo empleado");
                    Console.WriteLine("4. Editar los datos de un empleado");
                    Console.WriteLine("5. Cambiar el estado de un empleado");
                    Console.WriteLine("6. Eliminar un empleado del sistema");
                    Console.WriteLine("\n7. Volver al menú principal");

                    Console.Write("\nSelecciona una opción: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            LogicaEmpleados.ListaEmpleadosConsola();
                            LogicaEmpleados.ResumenEmpleadosConsola();
                            Pausar();
                            break;
                        case "2":
                            LogicaEmpleados.InformacionEmpleadoConsola();
                            Pausar();
                            break;
                        case "3":
                            LogicaEmpleados.AgregarEmpleadoConsola();
                            Pausar();
                            break;
                        case "4":
                            LogicaEmpleados.ModificarEmpleadoConsola();
                            Pausar();
                            break;
                        case "5":
                            LogicaEmpleados.CambiarEstadoEmpleadoConsola();
                            Pausar();
                            break;
                        case "6":
                            LogicaEmpleados.EliminarEmpleadoConsola();
                            Pausar();
                            break;
                        case "7":
                            return;
                        default:
                            MostrarError("Opción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MostrarError($"Error inesperado: {ex.Message}");
                }
            }
        }

        public static void MenuGestionDeProyectos()
        {
            while (true)
            {
                try
                {
                    MostrarEncabezado("Gestión de Proyectos");

                    Console.WriteLine("1. Proyectos");
                    Console.WriteLine("2. Roles");
                    Console.WriteLine("3. Tareas");
                    Console.WriteLine("\n4. Volver al menú principal");

                    Console.Write("\nSelecciona una opción: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            LogicaProyectos.MenuProyectos();
                            Pausar();
                            break;
                        case "2":
                            LogicaRoles.MenuRoles();
                            Pausar();
                            break;
                        case "3":
                            LogicaTareas.MenuTareas();
                            Pausar();
                            break;
                        case "4":
                            return;
                        default:
                            MostrarError("Opción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MostrarError($"Error inesperado: {ex.Message}");
                }
            }
        }

        public static void MenuOperaciones()
        {
            while (true)
            {
                try
                {
                    MostrarEncabezado("Gestión de Operaciones");

                    Console.WriteLine("1. Salarios");
                    Console.WriteLine("2. Bonos");
                    Console.WriteLine("\n3. Volver al menú principal");

                    Console.Write("\nSelecciona una opción: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            LogicaOperaciones.MenuSalarios();
                            Pausar();
                            break;
                        case "2":
                            LogicaOperaciones.MenuBonos();
                            Pausar();
                            break;
                        case "3":
                            return;
                        default:
                            MostrarError("Opción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MostrarError($"Error inesperado: {ex.Message}");
                }
            }
        }

        public static void MenuReportes()
        {
            while (true)
            {
                try
                {
                    MostrarEncabezado("Reportes");

                    Console.WriteLine("1. Reporte de Empleados");
                    Console.WriteLine("2. Reporte de Proyectos");
                    Console.WriteLine("3. Reporte Financiero");
                    Console.WriteLine("\n4. Volver al menú principal");

                    Console.Write("\nSelecciona una opción: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            LogicaReportes.MenuReporteEmpleados();
                            Pausar();
                            break;
                        case "2":
                            LogicaReportes.MenuReporteProyectos();
                            Pausar();
                            break;
                        case "3":
                            LogicaReportes.MenuReporteFinanzas();
                            Pausar();
                            break;
                        case "4":
                            return;
                        default:
                            MostrarError("Opción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MostrarError($"Error inesperado: {ex.Message}");
                }
            }
        }


        // MÉTODOS AUXILIARES ESTÉTICOS
        public static void MostrarEncabezado(string titulo)
        {
            Console.Clear();
            Console.WriteLine("*----------------------------*");
            Console.WriteLine($"     {titulo.ToUpper()}");
            Console.WriteLine("*----------------------------*\n");
        }

        public static void MostrarError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{mensaje}");
            Console.ResetColor();
            Pausar();
        }

        public static void Pausar()
        {
            Console.Write("\nPresiona una tecla para continuar... ");
            Console.ReadKey();
        }

    }
}
