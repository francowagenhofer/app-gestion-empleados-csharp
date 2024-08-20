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
    public class EmpleadoNegocio
    {
        static List<Empleado> empleados = new List<Empleado>();

        public static void AgregarEmpleado(Empleado empleado)
        {
            try
            {
                Console.WriteLine($"Ingrese los datos del {empleado.GetType().Name.ToLower()}:");
                empleado.Nombre = LeerDato("Nombre");
                empleado.Apellido = LeerDato("Apellido");
                empleado.Edad = Convert.ToInt32(LeerDato("Edad"));
                empleado.SalarioBase = Convert.ToDecimal(LeerDato("Salario Base"));

                // Asignación de bonos según el tipo de empleado
                if (empleado is Empleado)
                {
                    empleado.BonoAsistencia = Convert.ToDecimal(LeerDato("Bono Asistencia"));
                    empleado.BonoHorasExtra = Convert.ToDecimal(LeerDato("Bono Horas Extra"));
                    empleado.BonoDesempeño = Convert.ToDecimal(LeerDato("Bono Desempeño"));
                }
                else if (empleado is Gerente gerente)
                {
                    gerente.BonoMetaEquipo = Convert.ToDecimal(LeerDato("Bono Meta Equipo"));
                    gerente.BonoReduccionCostos = Convert.ToDecimal(LeerDato("Bono Reducción Costos"));
                    gerente.BonoSatisfaccionCliente = Convert.ToDecimal(LeerDato("Bono Satisfacción Cliente"));
                }
                else if (empleado is Director director)
                {
                    director.BonoDesempeñoEmpresa = Convert.ToDecimal(LeerDato("Bono Desempeño Empresa"));
                    director.BonoCrecimientoMercado = Convert.ToDecimal(LeerDato("Bono Crecimiento Mercado"));
                    director.StockOptions = Convert.ToDecimal(LeerDato("Stock Options"));
                }

                empleados.Add(empleado);
                MostrarMensaje($"Salario Final del {empleado.GetType().Name} {empleado.Nombre} {empleado.Apellido}: {empleado.CalcularSalario()}");
            }
            catch (FormatException fe)
            {
                MostrarMensaje("Formato de entrada incorrecto. Inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error inesperado: {ex.Message}");
            }
        }

        // Métodos auxiliares para leer datos, mostrar mensajes y obtener índice
        public static string LeerDato(string campo, string valorPorDefecto = "")
        {
            Console.Write($"{campo}{(valorPorDefecto != "" ? $" (actual: {valorPorDefecto})" : "")}: ");
            return Console.ReadLine();
        }

        public static void MostrarEmpleados()
        {
            try
            {
                if (empleados.Count == 0)
                {
                    MostrarMensaje("No hay empleados registrados.");
                }
                else
                {
                    for (int i = 0; i < empleados.Count; i++)
                        Console.WriteLine($"{i + 1}. {empleados[i].Nombre} {empleados[i].Apellido}, Salario Final: {empleados[i].CalcularSalario()}");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al mostrar empleados: {ex.Message}");
            }
        }

        public static void ModificarEmpleado()
        {
            try
            {
                MostrarEmpleados();
                int indice = ObtenerIndiceEmpleado();
                if (indice != -1)
                {
                    var empleado = empleados[indice];
                    empleado.Nombre = LeerDato("Nombre", empleado.Nombre);
                    empleado.Apellido = LeerDato("Apellido", empleado.Apellido);
                    empleado.Edad = Convert.ToInt32(LeerDato("Edad", empleado.Edad.ToString()));
                    empleado.SalarioBase = Convert.ToDecimal(LeerDato("Salario Base", empleado.SalarioBase.ToString()));
                    MostrarMensaje("Datos actualizados correctamente.");
                }
            }
            catch (FormatException fe)
            {
                MostrarMensaje("Formato de entrada incorrecto. Inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al modificar empleado: {ex.Message}");
            }
        }

        public static void EliminarEmpleado()
        {
            try
            {
                MostrarEmpleados();
                int indice = ObtenerIndiceEmpleado();
                if (indice != -1)
                {
                    empleados.RemoveAt(indice);
                    MostrarMensaje("Empleado eliminado correctamente.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MostrarMensaje("Índice fuera de rango. Inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al eliminar empleado: {ex.Message}");
            }
        }

        public static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.WriteLine("Presiona Enter para continuar...");
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
