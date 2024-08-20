using System;
using System.Collections.Generic;
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
                    Console.WriteLine("1. Añadir Empleado");
                    Console.WriteLine("2. Añadir Gerente");
                    Console.WriteLine("3. Añadir Director");
                    Console.WriteLine("4. Mostrar Lista de Empleados");
                    Console.WriteLine("5. Modificar Información de Empleado");
                    Console.WriteLine("6. Eliminar Empleado");
                    Console.WriteLine("7. Salir");
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
                            EmpleadoNegocio.MostrarEmpleados();
                            break;
                        case "5":
                            EmpleadoNegocio.ModificarEmpleado();
                            break;
                        case "6":
                            EmpleadoNegocio.EliminarEmpleado();
                            break;
                        case "7": return;
                        default:
                            EmpleadoNegocio.MostrarMensaje("Opción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    EmpleadoNegocio.MostrarMensaje($"Error: {ex.Message}");
                }
            }
        }
    }
}
