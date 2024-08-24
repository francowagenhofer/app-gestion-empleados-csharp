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
    public class Reportes
    {

        public static void MostrarReportes(List<Empleado> empleados)
        {
            // # tendria que poner el monto de los bonos 
            // mostrar el tipo de empleado

            try
            {
                if (empleados == null || empleados.Count == 0)
                {
                    Console.WriteLine();
                    MetodosAuxiliares.MostrarMensaje("No hay empleados registrados.");
                    return;
                }

                var reportes = empleados.Select(e => new
                {
                    NombreCompleto = $"{e.Nombre} {e.Apellido}",
                    SalarioBase = e.SalarioBase,
                    SalarioBonos = e.CalcularBonos(), // probando...
                    SalarioFinal = e.CalcularSalario()
                });

                foreach (var reporte in reportes)
                {
                    Console.WriteLine($"Nombre: {reporte.NombreCompleto}, Salario Base: {reporte.SalarioBase}, Bonos: {reporte.SalarioBonos}, Salario Final: {reporte.SalarioFinal}");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"Error al mostrar reportes: {ex.Message}");
            }
        }
    }
}
