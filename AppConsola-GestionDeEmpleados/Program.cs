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
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Menú de Gestión de Empleados");
                    Console.WriteLine();
                    Console.WriteLine("1. Mostrar Lista de Empleados");
                    Console.WriteLine("2. Buscar Empleado (por Nombre o Apellido)");
                    Console.WriteLine("3. Administrar Empleados");
                    Console.WriteLine("4. Calcular Salarios con Incremento");
                    Console.WriteLine("5. Mostrar Reportes");
                    Console.WriteLine("6. Salir");
                    Console.WriteLine();
                    Console.Write("Selecciona una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            EmpleadoNegocio.ListaEmpleados();
                            break;
                        case "2":
                            EmpleadoNegocio.BuscarEmpleado();
                            break;
                        case "3":
                            GestionEmpleados();
                            break;
                        case "4":
                            EmpleadoNegocio.CalcularSalariosConIncremento();
                            break;
                        case "5":
                            EmpleadoNegocio.MostrarReportes(); // # ver metodo
                            break;
                        case "6": return;
                        default:
                            Console.WriteLine();
                            EmpleadoNegocio.MostrarMensaje("Opción no válida.");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    EmpleadoNegocio.MostrarMensaje($"Error: {ex.Message}");
                    Console.WriteLine();
                }
            }
        }

        static void GestionEmpleados()
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
                    Console.WriteLine("4. Volver al Menú Principal");
                    Console.WriteLine();
                    Console.Write("Selecciona una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            SubmenuAgregarEmpleado();
                            break;
                        case "2":
                            EmpleadoNegocio.ModificarEmpleado();
                            break;
                        case "3":
                            EmpleadoNegocio.EliminarEmpleado();
                            break;
                        case "4":
                            return;  // Vuelve al menú principal
                        default:
                            Console.WriteLine();
                            EmpleadoNegocio.MostrarMensaje("Opción no válida.");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    EmpleadoNegocio.MostrarMensaje($"Error inesperado en el submenú: {ex.Message}");
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
                    Console.WriteLine();
                    Console.WriteLine("4. Volver a Amdinistrar Empleados");
                    Console.WriteLine("5. Volver al Menú Principal");
                    Console.WriteLine();
                    Console.Write("Selecciona una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            EmpleadoNegocio.AgregarEmpleado(new Empleado());
                            break;
                        case "2":
                            EmpleadoNegocio.AgregarEmpleado(new Gerente());
                            break;
                        case "3":
                            EmpleadoNegocio.AgregarEmpleado(new Director());
                            break;
                        case "4":
                            return;  // Vuelve al menú principal
                        case "5":
                            return;  // Vuelve al menú principal
                        default:
                            Console.WriteLine();
                            EmpleadoNegocio.MostrarMensaje("Opción no válida.");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    EmpleadoNegocio.MostrarMensaje($"Error inesperado en el submenú: {ex.Message}");
                    Console.WriteLine();
                }
            }
        }



    }
}












// lo que le falta al menu:

//- un menu de salarios - con distintas opciones: incremento de salario por inflacion, etc.

// mostrar reportes general y particular

//- menu gestion de empleados - se agregan, se modifican o se eliminan # Falta una opcion que s tocas M volves directo al menu principal




//- Contar el número total de empleados y cuantos hay por categoria... esta informacion podria estar directamente en la lista de los emmpleadosvh. LISTO

//- Buscar empleados por nombre o apellido. LISTO

//- Mostrar reportes usando tipos de datos anónimos.

//- Calcular salarios con un incremento porcentual o bono adicional.

