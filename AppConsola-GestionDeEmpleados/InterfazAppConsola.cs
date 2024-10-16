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
                    Console.WriteLine("\nAdministrar Empleados\n");
                    Console.WriteLine("1. Lista de Empleados");
                    Console.WriteLine("2. Buscar Empleado");
                    Console.WriteLine("3. Añadir Empleado");
                    Console.WriteLine("4. Modificar Empleado");
                    Console.WriteLine("5. Cambiar Estado");
                    Console.WriteLine("6. Eliminar Empleado");

                    //Console.WriteLine("7. Asignar Salario"); 
                    //Console.WriteLine("8. Desasignar salario.");
                    // estos dos metodos no tendrian que estar
                    // ya que los salarios se asignan automaticamente, segun la categoria seleccionada, cuando se carga un nuevo empleado.
                    

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

                        //case "7":
                        //    LogicaEmpleados.AsignarSalario();
                        //    break;
                        //case "8":
                        //    LogicaEmpleados.DesasignarSalario();
                        //    break;

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
                    Console.WriteLine("\n Aministrar Proyectos\n");
                    Console.WriteLine("1. Lista de Proyectos");
                    Console.WriteLine("2. Informacion de Proyecto"); // tambien esta en Reportes -> Rerporte Proyectos
                    Console.WriteLine("3. Agregar Proyecto");
                    Console.WriteLine("4. Modificar Datos de Proyecto");
                    Console.WriteLine("5. Cambiar Estado");
                    Console.WriteLine("6. Eliminar Proyecto");
                    Console.WriteLine("7. Asignar Empleado a Proyecto");
                    Console.WriteLine("8. Desasignar Empleado de Proyecto");
                    Console.WriteLine("\n9. Volver al Menú Principal");
                    Console.Write("\nSeleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            LogicaProyectos.ListaProyectosConsola();
                            LogicaProyectos.ResumenProyectosConsola();
                            break;
                        case "2":
                            LogicaProyectos.InformacionProyectoConsola();
                            break;
                        case "3":
                            LogicaProyectos.AgregarProyectoConsola();
                            break;
                        case "4":
                            LogicaProyectos.ModificarDatosDelProyectoConsola();
                            break;
                        case "5":
                            LogicaProyectos.CambiarEstadoProyectoConsola();
                            break;
                        case "6":
                            LogicaProyectos.EliminarProyectoConsola();
                            break;
                        case "7":
                            LogicaProyectos.AsignarEmpleadoAProyectoConsola();
                            break;
                        case "8":
                            LogicaProyectos.DesasignarEmpleadoDeProyectoConsola();
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

        public static void MenuOperaciones()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\nMenú de Operaciones\n");
                    Console.WriteLine("1. Salarios");
                    Console.WriteLine("2. Bonos");
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
                    Console.WriteLine("\nMenú de Reportes\n");
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
