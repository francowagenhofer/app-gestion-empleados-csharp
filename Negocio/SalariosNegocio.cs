using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Dominio.ReglasDelNegocio;
using negocio;

namespace Negocio
{
    public class SalariosNegocio
    {

        public static void AsignarSalarioPorCategoria(Empleado empleado)  
        {
            // mejorar el metodo antes de usar ...
            // el metodo funciona ... pero lo que se guarda en la tabla empleados es el valor de SalarioBase y no el IdAsignarSalario ...
            // tengo que reconvertir el metodo

            
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Selecciona la categoria del empleado para luego asignar el salario correspondiente
                switch (empleado.Categoria)
                {
                    case 1: // Operativo
                        empleado.SalarioBase = 30000m;
                        break;
                    case 2: // Gerente
                        empleado.SalarioBase = 50000m;
                        break;
                    case 3: // Director
                        empleado.SalarioBase = 70000m;
                        break;
                    default:
                        throw new ArgumentException("Categoría no válida.");
                }

                // Guardar el salario en la tabla AsignarSalarios
                //datos.setearProcedimiento("AsignarSalario"); // Procedimiento almacenado
                //datos.setearParametro("@IdEmpleado", empleado.Id);
                //datos.setearParametro("@IdCategoria", empleado.Categoria);
                //datos.setearParametro("@SalarioBase", empleado.SalarioBase);
                //datos.setearParametro("@FechaAsignacion", DateTime.Now);
                //datos.ejecutarAccion(); // Ejecutar el procedimiento

                //// Salarios ...
                //datos.setearProcedimiento("AgregarSalario"); 
                //datos.setearParametro("@IdEmpleado", empleado.Id);
                //datos.setearParametro("@IdAsignacionSalario", empleado.Id); 
                //datos.setearParametro("@Monto", empleado.SalarioBase);
                ////datos.setearParametro("@FechaPago", DateTime.Now); // este no se que onda podria ser ...
                //datos.ejecutarAccion();

                //// historial de salarios ...
                //datos.setearProcedimiento("AgregarHistorialSalario"); // Procedimiento almacenado
                //datos.setearParametro("@IdEmpleado", empleado.Id);
                //datos.setearParametro("@IdSalarioAnterior", null); // Suponiendo que es el primer salario asignado
                //datos.setearParametro("@IdSalarioNuevo", empleado.Id); // Asumimos que usamos el mismo Id
                //datos.setearParametro("@FechaCambio", DateTime.Now); 
                ////datos.setearParametro("@IdUsuario", null); // Puedes asignar el usuario que realizó el cambio si aplica
                //datos.setearParametro("@Comentarios", "Asignación inicial de salario.");
                //datos.ejecutarAccion();


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al asignar salario: {ex.Message}");
            }
        }


        //public static void CalcularSalariosConIncremento(List<Empleado> empleados) // tendria que adaptar este metodo.
        //{
        //    try
        //    {
        //        if (empleados == null || empleados.Count == 0)
        //        {
        //            MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
        //            return;
        //        }

        //        Console.Write("\nIngrese el porcentaje de incremento o bono adicional: ");
        //        decimal incremento = Convert.ToDecimal(Console.ReadLine());

        //        foreach (var empleado in empleados)
        //        {
        //            decimal salarioConIncremento = empleado.CalcularSalario() + (empleado.CalcularSalario() * incremento / 100);
        //            Console.WriteLine($"\nEmpleado: {empleado.Nombre} {empleado.Apellido}, Salario Final con Incremento: {salarioConIncremento}");
        //        }
        //        //Console.ReadLine();
        //        MetodosAuxiliares.MostrarMensaje("");
        //    }
        //    catch (FormatException)
        //    {
        //        MetodosAuxiliares.MostrarMensaje("\nFormato incorrecto. Inténtelo de nuevo.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MetodosAuxiliares.MostrarMensaje($"\nError al calcular salarios con incremento: {ex.Message}");
        //    }
        //}


    }
}
