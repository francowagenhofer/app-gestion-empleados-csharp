using Dominio.Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola.LogicaAppConsola
{
    public class LogicaSalarios
    {
        //-------------------------------------------------------------------------------------------------------------------------------//
        //                  Adaptcion de los metodos de SalarioNegocio a la App de Consola                                               //
        //-------------------------------------------------------------------------------------------------------------------------------//

        public static void CalcularSalariosConIncrementoConsola(List<Empleado> empleados) 
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
