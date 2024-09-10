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
                    Console.WriteLine("1. Gestión de Empleados");
                    Console.WriteLine("2. Gestión de Proyectos");
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
                            MenuOperaciones(empleados, proyectos);
                            break;
                        case "4":
                            MenuReportes(empleados, proyectos);
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
                    Console.WriteLine("\nAdministrar Empleados\n");
                    Console.WriteLine("1. Lista de Empleados");
                    Console.WriteLine("2. Buscar Empleado");
                    Console.WriteLine("3. Añadir Empleado");
                    Console.WriteLine("4. Modificar Empleado");
                    Console.WriteLine("5. Eliminar Empleado");
                    Console.WriteLine("\n6. Volver al Menú Principal");
                    Console.Write("\nSelecciona una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            LogicaEmpleados.ListaEmpleadosConsola(empleados);

                            if (empleados.Count != 0)
                                LogicaEmpleados.ContadorEmpleadosConsola(empleados);

                            break;
                        case "2":
                            LogicaEmpleados.InformacionEmpleadoConsola(empleados);
                            break;
                        case "3":
                            LogicaEmpleados.AgregarEmpleadoConsola(empleados);
                            break;
                        case "4":
                            LogicaEmpleados.ModificarEmpleadoConsola(empleados);
                            break;
                        case "5":
                            LogicaEmpleados.EliminarEmpleadoConsola(empleados);
                            break;
                        case "6":
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
                    Console.WriteLine("\n Aministrar Proyectos\n");
                    Console.WriteLine("1. Lista de Proyectos");
                    Console.WriteLine("2. Informacion de Proyecto"); // tambien esta en Reportes -> Rerporte Proyectos
                    Console.WriteLine("3. Agregar Proyecto");
                    Console.WriteLine("4. Marcar Proyecto como Completado");
                    Console.WriteLine("5. Modificar Datos de Proyecto");
                    Console.WriteLine("6. Eliminar Proyecto");
                    Console.WriteLine("7. Asignar Empleado a Proyecto");
                    Console.WriteLine("8. Desasignar Empleado de Proyecto");
                    Console.WriteLine("\n9. Volver al Menú Principal");
                    Console.Write("\nSeleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            LogicaProyectos.ListaProyectosConsola(proyectos);
                            if (proyectos.Count != 0)
                                LogicaProyectos.ContadorProyectosConsola(proyectos);
                            break;
                        case "2":
                            LogicaProyectos.InformacionProyectoConsola(proyectos);
                            break;
                        case "3":
                            LogicaProyectos.AgregarProyectoConsola(proyectos);
                            break;
                        case "4":
                            LogicaProyectos.MarcarProyectoComoCompletadoConsola(proyectos); // este no se para que me servira
                            break;
                        case "5":
                            LogicaProyectos.ModificarDatosDelProyectoConsola(proyectos);
                            break;
                        case "6":
                            LogicaProyectos.EliminarProyectoConsola(proyectos);
                            break;
                        case "7":
                            LogicaProyectos.AsignarEmpleadoAProyectoConsola(proyectos, empleados);
                            break;
                        case "8":
                            LogicaProyectos.DesasignarEmpleadoDeProyectoConsola(proyectos, empleados);
                            break;
                        case "9":
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

        public static void MenuOperaciones(List<Empleado> empleados, List<Proyectos> proyectos)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\nMenú de Operaciones\n");
                    Console.WriteLine("1. Asignar Bonos a los Empleados");
                    Console.WriteLine("2. Calcular Incrementos de Salarios"); // aumento de salarios - calculo de salarios , etc... 
                    Console.WriteLine("3. Realizar Otras Operaciones"); // decuentos de salario? 
                    Console.WriteLine("\n4. Volver al Menú Principal\n");
                    Console.Write("Seleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("hola");

                            //AsignarBonos(empleados);
                            break;
                        case "2":
                            Console.WriteLine("hola");

                            //CalcularIncrementosSalarios(empleados);
                            break;
                        case "3":
                            Console.WriteLine("hola");

                            //RealizarOtrasOperaciones(empleados, proyectos);
                            break;
                        case "4":
                            return; // Salir del submenu y volver al menú principal
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

        public static void MenuReportes(List<Empleado> empleados, List<Proyectos> proyectos)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\nMenú de Reportes\n");
                    Console.WriteLine("1. Reporte de Empleados");
                    Console.WriteLine("2. Reporte de Proyectos");
                    Console.WriteLine("3. Reporte Financiero");
                    Console.WriteLine("\n4. Volver al Menú Principal");
                    Console.Write("\nSeleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":

                            // Guardar esta logica para mas adelante para conectar con una base de datos
                            //Console.Write("Ingrese el ID del empleado para mostrar su reporte:");
                            //if (int.TryParse(Console.ReadLine(), out int empleadoId))
                            //{
                            //    ReportesNegocio.ReporteEmpleado(empleadoId, empleados, proyectos);

                            //    LogicaReportes.ReporteEmpleadoConsola(empleadoId, empleados, proyectos);

                            //}
                            //else
                            //{
                            //    Console.WriteLine("\nID de empleado no válido.\n");
                            //}
                            //break;
                            LogicaReportes.ReporteEmpleadosConsola(empleados, proyectos); // juntar toda la info sobre el o los empleados e insertarla aca
                            break;

                        case "2":
                            LogicaReportes.ReporteProyectosConsola(proyectos); // juntar toda la info sobre el o los proyectos e insertarla aca
                            break;

                        case "3":
                            LogicaReportes.ReporteFinancieroConsola(empleados, proyectos); // juntar toda la info sobre finanzas e insertarla aca
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
