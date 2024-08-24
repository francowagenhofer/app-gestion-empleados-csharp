using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using Dominio;
using Dominio.Entidades;
using Dominio.Interfaces;
using Dominio.ReglasDelNegocio;
using Negocio;

namespace AppDeConsola
{
    public class Program
    {
        public static List<Empleado> empleados = new List<Empleado>();

        public static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Menú de Gestión de Empleados\n");
                    Console.WriteLine("1. Mostrar Lista de Empleados");
                    Console.WriteLine("2. Buscar Empleado");
                    Console.WriteLine("3. Administrar Empleados");
                    Console.WriteLine("4. Calcular Salarios con Incremento");
                    Console.WriteLine("5. Mostrar Reportes");
                    Console.WriteLine("\n6. Salir");
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
                            AdministrarEmpleados();
                            break;
                        case "4":
                            Salarios.CalcularSalariosConIncremento(empleados); // no esta funcionando
                            break;
                        case "5":
                            Reportes.MostrarReportes(empleados); // no esta funcionando - # ver metodo
                            break;
                        case "6": return;
                        default:
                            Console.WriteLine();
                            MetodosAuxiliares.MostrarMensaje("Opción no válida.");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    MetodosAuxiliares.MostrarMensaje($"Error: {ex.Message}");
                    Console.WriteLine();
                }
            }
        }

        public static void AdministrarEmpleados()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Administrar Empleados");
                    Console.WriteLine();
                    Console.WriteLine("1. Añadir Empleado");
                    Console.WriteLine("2. Modificar Empleado");
                    Console.WriteLine("3. Eliminar Empleado");
                    Console.WriteLine("\n4. Volver al Menú Principal");
                    Console.WriteLine();
                    Console.Write("Selecciona una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            SubmenuAgregarEmpleado();
                            break;
                        case "2":
                            EmpleadoNegocio.ModificarEmpleado(empleados); // no esta funcionando
                            break;
                        case "3":
                            EmpleadoNegocio.EliminarEmpleado(empleados); // no esta funcionando
                            break;
                        case "4":
                            return;  // Vuelve al menú principal
                        default:
                            Console.WriteLine();
                            MetodosAuxiliares.MostrarMensaje("Opción no válida.");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    MetodosAuxiliares.MostrarMensaje($"Error inesperado en el submenú: {ex.Message}");
                    Console.WriteLine();
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
                    Console.WriteLine("Añadir Empleado");
                    Console.WriteLine();
                    Console.WriteLine("1. Añadir Empleado general");
                    Console.WriteLine("2. Añadir Gerente");
                    Console.WriteLine("3. Añadir Director");
                    Console.WriteLine("\n4. Volver");
                    Console.WriteLine();
                    Console.Write("Selecciona una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            EmpleadoNegocio.AgregarEmpleado(empleados, new Empleado());
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
                            Console.WriteLine();
                            MetodosAuxiliares.MostrarMensaje("Opción no válida.");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    MetodosAuxiliares.MostrarMensaje($"Error inesperado en el submenú: {ex.Message}");
                    Console.WriteLine();
                }
            }
        }



    }
}
