using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MetodosAuxiliares
    {
 
        // creo que esta clase la tendria que llevar a la logica de la app de la consola 
        // ya que son metodos auxiliares que sirven para ese contexto.


        public static string LeerDato(string campo, string valorPorDefecto = "")
        {
            Console.Write($"{campo}{(valorPorDefecto != "" ? $" (actual: {valorPorDefecto})" : "")}: ");
            return Console.ReadLine();
        }

        public static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.Write("\nPresiona Enter para continuar. ");
            Console.ReadLine();
        }


        // podria poner los contadores aca ...

        // podria crear aca los metodos de seleccionar un empleado y seleccionar un proyecto



        public static int ObtenerIndiceEmpleado(List<Empleado> empleados) // tendria que hacer uno para Proyectos
        {
            try
            {
                Console.Write("\nIngresa el número del empleado: ");
                if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= empleados.Count)
                    return indice - 1; // Se resta uno para ajustar la lista -> lista programa (empieza contando desde 0 ) ≠ lista humana (comienza contando desde 1) 

                throw new ArgumentOutOfRangeException("Índice no válido."); // Lanza la excepción si el índice no cumple las condiciones
            }
            catch (FormatException)
            {
                MostrarMensaje("\nFormato de entrada incorrecto. Inténtalo de nuevo.\n");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MostrarMensaje(ex.Message);
            }
            catch (Exception ex)
            {
                MostrarMensaje($"\nError inesperado: {ex.Message}\n");
            }

            return -1;
        }

    }
}
