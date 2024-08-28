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
    public class ReportesNegocio
    {
        public static void MostrarReportes(List<Empleado> empleados)
        {
            // # tendria que poner el monto de los bonos 
            // mostrar el tipo de empleado

            try
            {
                if (empleados == null || empleados.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }

                Console.WriteLine("\n# Reportes");

                var reportes = empleados.Select(e => new
                {
                    NombreCompleto = $"{e.Nombre} {e.Apellido}",
                    SalarioBase = e.SalarioBase,
                    SalarioBonos = e.CalcularBonos(), // probando...
                    SalarioFinal = e.CalcularSalario()
                });

                foreach (var reporte in reportes)
                {
                    Console.WriteLine($"\nNombre: {reporte.NombreCompleto}; Salario Base: {reporte.SalarioBase}; Bonos: {reporte.SalarioBonos}; Salario Final: {reporte.SalarioFinal}");
                }
                //Console.ReadLine();
                MetodosAuxiliares.MostrarMensaje("");

            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al mostrar reportes: {ex.Message}");
            }
        }
    }
}
