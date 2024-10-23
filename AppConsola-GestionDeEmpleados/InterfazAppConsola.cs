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
                    Console.WriteLine("1. Empleados\n");
                    Console.WriteLine("2. Proyectos\n");
                    Console.WriteLine("3. Operaciones\n");
                    Console.WriteLine("4. Reportes\n");
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
                    Console.WriteLine("\nGestión de Empleados\n");
                    //Console.WriteLine("1. Lista de Empleados");
                    //Console.WriteLine("2. Buscar Empleado");
                    //Console.WriteLine("3. Añadir Empleado");
                    //Console.WriteLine("4. Modificar información de Empleado");
                    //Console.WriteLine("5. Cambiar estado del Empleado");
                    //Console.WriteLine("6. Eliminar Empleado");
                    //Console.WriteLine("\n7. Regresar al menú principal");
                    Console.WriteLine("1. Ver lista de empleados registrados\n");
                    Console.WriteLine("2. Buscar detalles de un empleado específico\n");
                    Console.WriteLine("3. Registrar un nuevo empleado\n");
                    Console.WriteLine("4. Editar los datos de un empleado\n");
                    Console.WriteLine("5. Cambiar el estado de un empleado\n");
                    Console.WriteLine("6. Eliminar un empleado del sistema\n");
                    Console.WriteLine("\n7. Volver al menú principal");
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
                    Console.WriteLine("\nGestión de Proyectos\n");
                    Console.WriteLine("1. Proyectos\n");
                    Console.WriteLine("2. Roles\n");
                    Console.WriteLine("3. Tareas\n");
                    Console.WriteLine("\n4. Volver al menú principal");
                    Console.Write("\nSeleccione una opción: ");


                    switch (Console.ReadLine())
                    {
                        case "1":
                            LogicaProyectos.MenuProyectos();
                            break;
                        case "2":
                            LogicaRoles.MenuRoles();
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
                    Console.WriteLine("\nGestión de Operaciones\n");
                    Console.WriteLine("1. Salarios\n");
                    Console.WriteLine("2. Bonos\n");
                    Console.WriteLine("\n3. Volver al menú principal");
                    Console.Write("\nSeleccione una opción: ");

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
                    Console.WriteLine("\nReportes\n");
                    Console.WriteLine("1. Reporte de Empleados\n");
                    Console.WriteLine("2. Reporte de Proyectos\n");
                    Console.WriteLine("3. Reporte Financiero\n");
                    Console.WriteLine("\n4. Volver al menú principal");
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
