using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Dominio.ReglasDelNegocio;

namespace Negocio
{
    public class Salarios
    {
        static List<Empleado> empleados = new List<Empleado>();

        public static void AsignarSalarioPorCategoria(Empleado empleado)
        {
            if (empleado is Gerente)
            {
                empleado.SalarioBase = 50000m;  // Salario base para Gerente
            }
            else if (empleado is Director)
            {
                empleado.SalarioBase = 70000m;  // Salario base para Director
            }
            else
            {
                empleado.SalarioBase = 30000m;  // Salario base para empleado operativo
            }

            Console.WriteLine($"{empleado.Nombre} ha sido asignado a la categoría {empleado.GetType().Name} con un salario base de {empleado.SalarioBase:C}");
        }

        public static void CalcularSalariosConIncremento()
        {
            try
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine();
                    MetodosAuxiliares.MostrarMensaje("No hay empleados registrados.");
                    return;
                }

                Console.Write("Ingrese el porcentaje de incremento o bono adicional: ");
                decimal incremento = Convert.ToDecimal(Console.ReadLine());

                foreach (var empleado in empleados)
                {
                    decimal salarioConIncremento = empleado.CalcularSalario() + (empleado.CalcularSalario() * incremento / 100);
                    Console.WriteLine($"Empleado: {empleado.Nombre} {empleado.Apellido}, Salario Final con Incremento: {salarioConIncremento}");
                }
                Console.ReadLine();
            }
            catch (FormatException)
            {
                MetodosAuxiliares.MostrarMensaje("Formato incorrecto. Inténtelo de nuevo.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"Error al calcular salarios con incremento: {ex.Message}");
            }
        }


    }
}
