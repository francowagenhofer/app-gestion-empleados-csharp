using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Dominio.ReglasDelNegocio;
using Dominio.Entidades.Dominio.Entidades;

namespace Negocio
{
    public class ReportesNegocio
    {

        // tendria que agregar tablas en la base de datos con los registros? 
        
        // como convierto estos metodos para que sean "universales" 

        // los metodos podrian ser "GenerarReporteEmpleado" para que se generen en la base de datos. y luego se podrian llamar desde las aplicaciones
     


        //public static void MostrarReportes(List<Empleado> empleados) // Este metodo se elimina...
        //{
        //    // # tendria que poner el monto de los bonos 
        //    // mostrar el tipo de empleado


        //    try
        //    {
        //        if (empleados == null || empleados.Count == 0)
        //        {
        //            MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
        //            return;
        //        }

        //        Console.WriteLine("\n# Reportes");

        //        var reportes = empleados.Select(e => new
        //        {
        //            NombreCompleto = $"{e.Nombre} {e.Apellido}",
        //            SalarioBase = e.SalarioBase,
        //            SalarioBonos = e.CalcularBonos(), // probando...
        //            SalarioFinal = e.CalcularSalario()
        //        });

        //        foreach (var reporte in reportes)
        //        {
        //            Console.WriteLine($"\nNombre: {reporte.NombreCompleto}; Salario Base: {reporte.SalarioBase}; Bonos: {reporte.SalarioBonos}; Salario Final: {reporte.SalarioFinal}");
        //        }
        //        //Console.ReadLine();
        //        MetodosAuxiliares.MostrarMensaje("");

        //    }
        //    catch (Exception ex)
        //    {
        //        MetodosAuxiliares.MostrarMensaje($"\nError al mostrar reportes: {ex.Message}");
        //    }
        //}

        //--------------------------------------------------------------------------------------------------------------------------------//


        //  Reportes: de empleados, de proyectos y financieros


        // Reportes de Empleados
        //public static void ReporteEmpleado(int empleadoId, List<Empleado> empleados, List<Proyectos> proyectos)
        //{
        //    // Buscar al empleado por ID
        //    var empleado = empleados.FirstOrDefault(e => e.Id == empleadoId);
        //    if (empleado == null)
        //    {
        //        Console.WriteLine($"Empleado con ID {empleadoId} no encontrado.");
        //        return;
        //    }

        //    // Mostrar la información básica del empleado
        //    Console.WriteLine($"\nReporte de Empleado:");
        //    Console.WriteLine($"Nombre: {empleado.Nombre} {empleado.Apellido}");
        //    Console.WriteLine($"Salario Base: {empleado.SalarioBase}");
        //    Console.WriteLine($"Bonos: {empleado.CalcularBonos()}");
        //    Console.WriteLine($"Salario Final: {empleado.CalcularSalario()}");

        //    // Mostrar los proyectos asociados al empleado
        //    var proyectosEmpleado = proyectos.Where(p => p.EmpleadosIds.Contains(empleado.Id)).ToList();
        //    if (proyectosEmpleado.Count > 0)
        //    {
        //        Console.WriteLine("\nProyectos asignados:");
        //        foreach (var proyecto in proyectosEmpleado)
        //        {
        //            Console.WriteLine($"Proyecto: {proyecto.Nombre}, Presupuesto: {proyecto.Presupuesto}");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("\nEl empleado no tiene proyectos asignados.");
        //    }
        //}

        ////        // Ejemplo de uso en el menú principal
        ////        Console.WriteLine("Ingrese el ID del empleado para mostrar su reporte:");
        ////        int empleadoId = int.Parse(Console.ReadLine());

        ////        ReportesNegocio.MostrarReporteEmpleado(empleadoId, listaEmpleados, listaProyectos);

        ////--------------------------------------------------------------------------------------------------------------------------------//


        //// Reportes de Proyectos
        //public static void ReporteProyectos(List<Proyectos> proyectos)
        //{
        //    if (proyectos == null || proyectos.Count == 0)
        //    {
        //        Console.WriteLine("\nNo hay proyectos registrados.");
        //        return;
        //    }

        //    foreach (var proyecto in proyectos)
        //    {
        //        Console.WriteLine($"\nProyecto: {proyecto.Nombre}");
        //        Console.WriteLine($"Descripción: {proyecto.Descripcion}");
        //        Console.WriteLine($"Fecha de Inicio: {proyecto.FechaInicio.ToShortDateString()}");
        //        Console.WriteLine($"Fecha de Fin: {proyecto.FechaFin.ToShortDateString()}");
        //        Console.WriteLine($"Presupuesto: {proyecto.Presupuesto}");

        //        // Lista de empleados asignados al proyecto
        //        if (proyecto.EmpleadosAsignados != null && proyecto.EmpleadosAsignados.Count > 0)
        //        {
        //            Console.WriteLine("Empleados Asignados:");
        //            foreach (var empleado in proyecto.EmpleadosAsignados)
        //            {
        //                Console.WriteLine($"- {empleado.Nombre} {empleado.Apellido}, Salario Base: {empleado.SalarioBase}, Bonos: {empleado.CalcularBonos()}");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("No hay empleados asignados a este proyecto.");
        //        }

        //        Console.WriteLine("----------------------------------------------------");
        //    }
        //}


        ////--------------------------------------------------------------------------------------------------------------------------------//


        //// Reportes Financieros
        //public static void ReporteFinanciero(List<Empleado> empleados, List<Proyectos> proyectos)
        //{
        //    try
        //    {
        //        ReporteFinanzas reporteFinanzas = CalcularTotalesFinancieros(empleados, proyectos);

        //        Console.WriteLine("\n# Reporte Financiero");
        //        Console.WriteLine($"Total Gastos en Salarios: {reporteFinanzas.TotalSalarios:C}");
        //        Console.WriteLine($"Total Gastos en Bonos: {reporteFinanzas.TotalBonos:C}");
        //        Console.WriteLine($"Total Presupuestos de Proyectos: {reporteFinanzas.TotalPresupuestosProyectos:C}");
        //        Console.WriteLine($"Total Gastos (Salarios + Bonos + Presupuestos): {reporteFinanzas.TotalGastos:C}");

        //        MetodosAuxiliares.MostrarMensaje("");
        //    }
        //    catch (Exception ex)
        //    {
        //        MetodosAuxiliares.MostrarMensaje($"\nError al mostrar el reporte financiero: {ex.Message}");
        //    }
        //}

        //public static ReporteFinanzas CalcularTotalesFinancieros(List<Empleado> empleados, List<Proyectos> proyectos)
        //{
        //    ReporteFinanzas reporteFinanzas = new ReporteFinanzas();
        //    reporteFinanzas.TotalSalarios = empleados.Sum(e => e.Salario);
        //    reporteFinanzas.TotalBonos = empleados.Sum(e => e.Bonos);
        //    reporteFinanzas.TotalPresupuestosProyectos = proyectos.Sum(p => p.Presupuesto);
        //    reporteFinanzas.TotalGastos = reporteFinanzas.TotalSalarios + reporteFinanzas.TotalBonos + reporteFinanzas.TotalPresupuestosProyectos;
        //    return reporteFinanzas;
        //}


    }
}
