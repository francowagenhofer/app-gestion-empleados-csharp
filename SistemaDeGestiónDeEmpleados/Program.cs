using System;
using System.Collections.Generic;
using Dominio;
using Dominio.Entidades;
using Dominio.Interfaces;
using Dominio.ReglasDelNegocio;

namespace AppDeConsola
{
    public class Program
    {
        // Lista para almacenar los empleados agregados
        static List<Empleado> empleados = new List<Empleado>();

        static void Main(string[] args)
        {
            while (true)
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

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarEmpleado();
                        break;
                    case "2":
                        AgregarGerente();
                        break;
                    case "3":
                        AgregarDirector();
                        break;
                    case "4":
                        MostrarEmpleados();
                        break;
                    case "5":
                        ModificarEmpleado();
                        break;
                    case "6":
                        EliminarEmpleado();
                        break;
                    case "7":
                        return; // Salir del programa
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opción no válida. Presiona Enter para continuar...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static void AgregarEmpleado()
        {
            Empleado empleado = new Empleado();

            Console.WriteLine("Ingrese los datos del empleado:");
            Console.Write("Nombre: ");
            empleado.Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            empleado.Apellido = Console.ReadLine();
            Console.Write("Edad: ");
            empleado.Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Salario Base: ");
            empleado.SalarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Bono Asistencia: ");
            empleado.BonoAsistencia = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Bono Horas Extra: ");
            empleado.BonoHorasExtra = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Bono Desempeño: ");
            empleado.BonoDesempeño = Convert.ToDecimal(Console.ReadLine());

            // Agregar el empleado a la lista
            empleados.Add(empleado);

            Console.WriteLine($"Salario Final del Empleado {empleado.Nombre} {empleado.Apellido}: {empleado.CalcularSalario()}");
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }

        private static void AgregarGerente()
        {
            Gerente gerente = new Gerente();

            Console.WriteLine("Ingrese los datos del gerente:");
            Console.Write("Nombre: ");
            gerente.Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            gerente.Apellido = Console.ReadLine();
            Console.Write("Edad: ");
            gerente.Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Salario Base: ");
            gerente.SalarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Bono Meta Equipo: ");
            gerente.BonoMetaEquipo = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Bono Reducción Costos: ");
            gerente.BonoReduccionCostos = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Bono Satisfacción Cliente: ");
            gerente.BonoSatisfaccionCliente = Convert.ToDecimal(Console.ReadLine());

            // Agregar el gerente a la lista
            empleados.Add(gerente);

            Console.WriteLine($"Salario Final del Gerente {gerente.Nombre} {gerente.Apellido}: {gerente.CalcularSalario()}");
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }

        private static void AgregarDirector()
        {
            Director director = new Director();

            Console.WriteLine("Ingrese los datos del director:");
            Console.Write("Nombre: ");
            director.Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            director.Apellido = Console.ReadLine();
            Console.Write("Edad: ");
            director.Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Salario Base: ");
            director.SalarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Bono Desempeño Empresa: ");
            director.BonoDesempeñoEmpresa = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Bono Crecimiento Mercado: ");
            director.BonoCrecimientoMercado = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Stock Options: ");
            director.StockOptions = Convert.ToDecimal(Console.ReadLine());

            // Agregar el director a la lista
            empleados.Add(director);

            Console.WriteLine($"Salario Final del Director {director.Nombre} {director.Apellido}: {director.CalcularSalario()}");
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }

        // Mostrar lista de empleados
        private static void MostrarEmpleados()
        {
            Console.WriteLine("Lista de Empleados:");

            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados registrados.");
            }
            else
            {
                for (int i = 0; i < empleados.Count; i++)
                {
                    var empleado = empleados[i];
                    Console.WriteLine($"{i + 1}. {empleado.Nombre} {empleado.Apellido}, Edad: {empleado.Edad}, Salario Final: {empleado.CalcularSalario()}");
                }
            }

            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }

        // Modificar información de empleado
        private static void ModificarEmpleado()
        {
            MostrarEmpleados();

            Console.Write("Ingresa el número del empleado que deseas modificar: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < empleados.Count)
            {
                var empleado = empleados[indice];

                Console.WriteLine("Modificando datos del empleado:");
                Console.Write("Nombre: ");
                empleado.Nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                empleado.Apellido = Console.ReadLine();
                Console.Write("Edad: ");
                empleado.Edad = Convert.ToInt32(Console.ReadLine());
                Console.Write("Salario Base: ");
                empleado.SalarioBase = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Datos actualizados correctamente.");
            }
            else
            {
                Console.WriteLine("Índice no válido.");
            }

            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }

        // Eliminar empleado
        private static void EliminarEmpleado()
        {
            MostrarEmpleados();

            Console.Write("Ingresa el número del empleado que deseas eliminar: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < empleados.Count)
            {
                empleados.RemoveAt(indice);
                Console.WriteLine("Empleado eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Índice no válido.");
            }

            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}
