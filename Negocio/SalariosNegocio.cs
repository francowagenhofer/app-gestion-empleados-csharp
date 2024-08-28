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
    public class SalariosNegocio
    {

        public static void AsignarSalarioPorCategoria(Empleado empleado)
        {
            try
            {
                if (empleado is Gerente)
                    empleado.SalarioBase = 50000m;

                else if (empleado is Director)
                    empleado.SalarioBase = 70000m;

                else
                    empleado.SalarioBase = 30000m;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void CalcularSalariosConIncremento(List<Empleado> empleados) // paso la lista por parametro (clave)
        {
            try
            {
                if (empleados == null || empleados.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }

                Console.Write("\nIngrese el porcentaje de incremento o bono adicional: ");
                decimal incremento = Convert.ToDecimal(Console.ReadLine());

                foreach (var empleado in empleados)
                {
                    decimal salarioConIncremento = empleado.CalcularSalario() + (empleado.CalcularSalario() * incremento / 100);
                    Console.WriteLine($"\nEmpleado: {empleado.Nombre} {empleado.Apellido}, Salario Final con Incremento: {salarioConIncremento}");
                }
                //Console.ReadLine();
                MetodosAuxiliares.MostrarMensaje("");
            }
            catch (FormatException)
            {
                MetodosAuxiliares.MostrarMensaje("\nFormato incorrecto. Inténtelo de nuevo.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al calcular salarios con incremento: {ex.Message}");
            }
        }


    }
}
