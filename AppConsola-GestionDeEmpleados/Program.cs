using System;
using System.Collections.Generic;
using Dominio;
using Dominio.Entidades;
using Dominio.Entidades.Dominio.Entidades;
using Negocio;

namespace AppDeConsola
{
    public class Program
    {
        public static List<Empleado> empleados = new List<Empleado>();
        public static List<Proyecto> proyectos = new List<Proyecto>();


        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\nMenú Principal\n");
                    Console.WriteLine("1. Mostrar Lista de Empleados");
                    Console.WriteLine("2. Buscar Empleado");
                    Console.WriteLine("3. Administrar Empleados");
                    Console.WriteLine("4. Calcular Salarios con Incremento");
                    Console.WriteLine("5. Mostrar Reportes");
                    Console.WriteLine("6. Gestión de Proyectos");
                    Console.WriteLine("\n7. Salir");
                    Console.Write("\nSelecciona una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            EmpleadoNegocio.ListaEmpleados(empleados);
                            break;
                        case "2":
                            EmpleadoNegocio.BuscarEmpleado(empleados);
                            break;
                        case "3":
                            MenuAdministrarEmpleados();
                            break;
                        case "4":
                            Salarios.CalcularSalariosConIncremento(empleados);
                            break;
                        case "5":
                            Reportes.MostrarReportes(empleados);
                            break;
                        case "6":
                            MenuGestionDeProyectos();
                            break;
                        case "7": return;
                        default:
                            MetodosAuxiliares.MostrarMensaje("\nOpción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MetodosAuxiliares.MostrarMensaje($"\nError: {ex.Message}\n");
                }
            }
        }

        public static void MenuAdministrarEmpleados()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\nAdministrar Empleados\n");
                    Console.WriteLine("1. Añadir Empleado");
                    Console.WriteLine("2. Modificar Empleado");
                    Console.WriteLine("3. Eliminar Empleado");
                    Console.WriteLine("\n4. Volver al Menú Principal");
                    Console.Write("\nSelecciona una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            SubmenuAgregarEmpleado();
                            break;
                        case "2":
                            EmpleadoNegocio.ModificarEmpleado(empleados);
                            break;
                        case "3":
                            EmpleadoNegocio.EliminarEmpleado(empleados);
                            break;
                        case "4":
                            return;
                        default:
                            MetodosAuxiliares.MostrarMensaje("\nOpción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MetodosAuxiliares.MostrarMensaje($"\nError inesperado en el submenú: {ex.Message}\n");
                }
            }
        }

        public static void SubmenuAgregarEmpleado()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\nAñadir Empleado\n");
                    Console.WriteLine("1. Añadir Empleado Operativo");
                    Console.WriteLine("2. Añadir Gerente");
                    Console.WriteLine("3. Añadir Director");
                    Console.WriteLine("\n4. Volver");
                    Console.Write("\nSelecciona una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            EmpleadoNegocio.AgregarEmpleado(empleados, new Empleado(esOperativo: true));
                            break;
                        case "2":
                            EmpleadoNegocio.AgregarEmpleado(empleados, new Gerente());
                            break;
                        case "3":
                            EmpleadoNegocio.AgregarEmpleado(empleados, new Director());
                            break;
                        case "4":
                            return;
                        default:
                            MetodosAuxiliares.MostrarMensaje("\nOpción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MetodosAuxiliares.MostrarMensaje($"\nError inesperado en el submenú: {ex.Message}\n");
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
                    Console.WriteLine("1. Mostrar Proyectos Activos");
                    Console.WriteLine("2. Mostrar Proyectos No Activos");
                    Console.WriteLine("3. Asignar Empleado a Proyecto");
                    Console.WriteLine("4. Desasignar Empleado de Proyecto");
                    Console.WriteLine("5. Agregar Proyecto");
                    Console.WriteLine("6. Marcar Proyecto como Completado");
                    Console.WriteLine("7. Modificar Datos del Proyecto");
                    Console.WriteLine("8. Eliminar Proyecto");
                    Console.WriteLine("\n9. Volver al Menú Principal");
                    Console.Write("\nSeleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            ProyectosNegocio.MostrarProyectosActivos(proyectos);
                            break;
                        case "2":
                            ProyectosNegocio.MostrarProyectosNoActivos(proyectos);
                            break;
                        case "3":
                            ProyectosNegocio.AsignarEmpleadoAProyecto(proyectos, empleados);
                            break;
                        case "4":
                            ProyectosNegocio.DesasignarEmpleadoDeProyecto(proyectos, empleados);
                            break;
                        case "5":
                            ProyectosNegocio.AgregarProyecto(proyectos);
                            break;
                        case "6":
                            ProyectosNegocio.MarcarProyectoComoCompletado(proyectos);
                            break;
                        case "7":
                            ProyectosNegocio.ModificarDatosDelProyecto(proyectos);
                            break;
                        case "8":
                            ProyectosNegocio.EliminarProyecto(proyectos);
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
                    MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
                }
            }
        }
    }
}
