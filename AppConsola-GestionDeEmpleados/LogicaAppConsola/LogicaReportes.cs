using Dominio.Entidades.Dominio.Entidades;
using Dominio.Entidades;
using Dominio.ReglasDelNegocio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola.LogicaAppConsola
{
    public class LogicaReportes
    {

        //-------------------------------------------------------------------------------------------------------------------------------//
        //                  Adaptcion de los metodos de ProyectosNegocio a la App de Consola                                             //
        //-------------------------------------------------------------------------------------------------------------------------------//

        public static void ReporteEmpleadosConsola(List<Empleado> empleados, List<Proyectos> proyectos) 
        {
        // FUNCIONA BIEN PERO tendria que poder elegir el empleado, que aparezca la lista de empleados y de ahi poder seleccionar que reporte quiero.
            
            if (empleados.Count == 0)
            {
                MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                return;
            }

            // Generar reporte para cada empleado -> aca tendria que cambiarlo ...
            foreach (var empleado in empleados)
            {
                // Mostrar la información básica del empleado
                Console.WriteLine($"\nReporte de Empleado:");
                Console.WriteLine($"Nombre: {empleado.Nombre} {empleado.Apellido}");
                Console.WriteLine($"Salario Base: {empleado.SalarioBase}");
                Console.WriteLine($"Bonos: {empleado.CalcularBonos()}");
                Console.WriteLine($"Salario Final: {empleado.CalcularSalario()}");


                // Buscar proyectos asociados al empleado a través del objeto Empleado
                var proyectosEmpleado = proyectos
                    .Where(p => p.EmpleadosAsignados.Contains(empleado))  // Revisa si el empleado está asignado al proyecto
                    .ToList();


                // Mostrar los proyectos asociados al empleado
                if (proyectosEmpleado.Count > 0)
                {
                    Console.WriteLine("\nProyectos asignados:");
                    foreach (var proyecto in proyectosEmpleado)
                    {
                        Console.WriteLine($"Proyecto: {proyecto.Nombre}, Presupuesto: {proyecto.Presupuesto}");
                    }
                    
                    MetodosAuxiliares.MostrarMensaje("chau");


                }
                else
                {
                    MetodosAuxiliares.MostrarMensaje("\nEl empleado no tiene proyectos asignados.");

                }

                Console.WriteLine(new string('-', 50)); // Separador para cada empleado
            }
        }

        public static void ReporteProyectosConsola(List<Proyectos> proyectos)
        {


            // podria agregar si el proyecto esta activo o no lo esta ...

            if (proyectos == null || proyectos.Count == 0)
            {
                MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                return;
            }

            Console.Clear();
            Console.WriteLine("\nReporte Proyectos\n");

            foreach (var proyecto in proyectos)
            {
                Console.WriteLine($"Proyecto: {proyecto.Nombre}");
                Console.WriteLine($"Descripción: {proyecto.Descripcion}");
                Console.WriteLine($"Fecha de Inicio: {proyecto.FechaInicio.ToShortDateString()}");
                Console.WriteLine($"Fecha de Fin: {proyecto.FechaFin.ToShortDateString()}");
                Console.WriteLine($"Presupuesto: {proyecto.Presupuesto}");

                // Lista de empleados asignados al proyecto
                if (proyecto.EmpleadosAsignados != null && proyecto.EmpleadosAsignados.Count > 0)
                {
                    Console.WriteLine("\nEmpleados Asignados:");
                    foreach (var empleado in proyecto.EmpleadosAsignados)
                    {
                        Console.WriteLine($"- {empleado.Nombre} {empleado.Apellido}; Posicion: {empleado.EsOperativo}.");
                    }
                }
                else
                {
                    Console.WriteLine("No hay empleados asignados a este proyecto.");
                }

                Console.WriteLine("----------------------------------------------------");
            }
        
        MetodosAuxiliares.MostrarMensaje("\n Salir ...");


        }

        public static void ReporteFinancieroConsola(List<Empleado> empleados, List<Proyectos> proyectos)
        {
            try
            {
                ReporteFinanzas reporteFinanzas = CalcularTotalesFinancieros(empleados, proyectos);

                Console.WriteLine("\n# Reporte Financiero\n");
                Console.WriteLine($"Total Gastos en Salarios: {reporteFinanzas.TotalSalarios}");
                Console.WriteLine($"Total Gastos en Bonos: {reporteFinanzas.TotalBonos}");
                Console.WriteLine($"Total Presupuestos de Proyectos: {reporteFinanzas.TotalPresupuestosProyectos}");
                MetodosAuxiliares.MostrarMensaje($"Total Gastos (Salarios + Bonos + Presupuestos): {reporteFinanzas.TotalGastos}");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al mostrar el reporte financiero: {ex.Message}");
            }
        }

        public static ReporteFinanzas CalcularTotalesFinancieros(List<Empleado> empleados, List<Proyectos> proyectos)
        {
            ReporteFinanzas reporteFinanzas = new ReporteFinanzas();
            reporteFinanzas.TotalSalarios = empleados.Sum(e => e.SalarioBase);
            reporteFinanzas.TotalBonos = empleados.Sum(e => e.Bonos.CalcularBonos());
            reporteFinanzas.TotalPresupuestosProyectos = proyectos.Sum(p => p.Presupuesto);
            reporteFinanzas.TotalGastos = reporteFinanzas.TotalSalarios + reporteFinanzas.TotalBonos + reporteFinanzas.TotalPresupuestosProyectos;
            return reporteFinanzas;
        }

    }
}
