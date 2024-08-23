using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MetodosAuxiliares
    {

        public static string LeerDato(string campo, string valorPorDefecto = "")
        {
            Console.Write($"{campo}{(valorPorDefecto != "" ? $" (actual: {valorPorDefecto})" : "")}: ");
            return Console.ReadLine();
        }

        public static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.WriteLine();
            Console.Write("Presiona Enter para continuar ");
            Console.ReadLine();
        }

        public static int ObtenerIndiceEmpleado()
        {
            try
            {
                Console.Write("Ingresa el número del empleado: ");
                if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= empleados.Count)
                    return indice - 1; // Se resta uno para ajustar la lista -> lista programa (empieza contando desde 0 ) ≠ lista humana (comienza contando desde 1) 

                // Lanza la excepción si el índice no cumple las condiciones
                throw new ArgumentOutOfRangeException("Índice no válido.");
            }
            catch (FormatException)
            {
                MostrarMensaje("Formato de entrada incorrecto. Inténtalo de nuevo.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MostrarMensaje(ex.Message);
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error inesperado: {ex.Message}");
            }

            return -1;
        }

    }
}
