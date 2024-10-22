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
                    Console.Clear();
                    Console.WriteLine("\nMenú Principal\n");
                    Console.WriteLine("1. Empleados");
                    Console.WriteLine("2. Proyectos");
                    Console.WriteLine("3. Operaciones");
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
                        case "5": return;
                        default:
                            Negocio.MetodosAuxiliares.MostrarMensaje("\nOpción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
                }
            }
        }

        public static void MenuGestionEmpleados()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n Administrar Empleados\n");
                    Console.WriteLine("1. Lista de Empleados");
                    Console.WriteLine("2. Buscar Empleado");
                    Console.WriteLine("3. Añadir Empleado");
                    Console.WriteLine("4. Modificar información de Empleado");
                    Console.WriteLine("5. Cambiar estado del Empleado");
                    Console.WriteLine("6. Eliminar Empleado");
                    Console.WriteLine("\n7. Volver al Menú Principal");
                    Console.Write("\nSelecciona una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            LogicaEmpleados.ListaEmpleadosConsola();
                            LogicaEmpleados.ResumenEmpleadosConsola();
                            break;
                        case "2":
                            LogicaEmpleados.InformacionEmpleadoConsola();
                            break;
                        case "3":
                            LogicaEmpleados.AgregarEmpleadoConsola();
                            break;
                        case "4":
                            LogicaEmpleados.ModificarEmpleadoConsola();
                            break;
                        case "5":
                            LogicaEmpleados.CambiarEstadoEmpleadoConsola();
                            break;
                        case "6":
                            LogicaEmpleados.EliminarEmpleadoConsola();
                            break;
                        case "7":
                            return;
                        default:
                            Negocio.MetodosAuxiliares.MostrarMensaje("\nOpción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
                }
            }
        }

        public static void MenuGestionDeProyectos()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n Proyectos\n");
                    Console.WriteLine("1. Gestion de Proyectos");
                    Console.WriteLine("2. Gestion de Roles");
                    Console.WriteLine("3. Gestion de tareas");
                    Console.WriteLine("\n4. Volver al Menú Principal");
                    Console.Write("\nSeleccione una opción: ");


                    switch (Console.ReadLine())
                    {
                        case "1":
                            LogicaProyectos.MenuProyectos();
                            break;
                        case "2":
                            LogicaProyectos.MenuRoles();
                            break;
                        case "3":
                            LogicaTareas.MenuTareas();
                            break;
                        case "4":
                            return;
                        default:
                            Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
                }
            }
        }

        public static void MenuOperaciones()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n Operaciones\n");
                    Console.WriteLine("1. Gestión de Salarios");
                    Console.WriteLine("2. Gestión Bonos");
                    Console.WriteLine("\n3. Volver al Menú Principal\n");
                    Console.Write("Seleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            LogicaOperaciones.Salarios();
                            break;
                        case "2":
                            LogicaOperaciones.Bonos();
                            break;
                        case "3":
                            return;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
                }
            }
        }

        public static void MenuReportes()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n Reportes\n");
                    Console.WriteLine("1. Reporte de Empleados");
                    Console.WriteLine("2. Reporte de Proyectos");
                    Console.WriteLine("3. Reporte Financiero");
                    Console.WriteLine("\n4. Volver al Menú Principal");
                    Console.Write("\nSeleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            LogicaReportes.ReporteEmpleadosConsola(empleados, proyectos); 
                            break;

                        case "2":
                            LogicaReportes.ReporteProyectosConsola(proyectos);
                            break;

                        case "3":
                            LogicaReportes.ReporteFinancieroConsola(empleados, proyectos);
                            break;

                        case "4":
                            return;

                        default:
                            Negocio.MetodosAuxiliares.MostrarMensaje("\nOpción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
                }

            }
        }

    }
}
