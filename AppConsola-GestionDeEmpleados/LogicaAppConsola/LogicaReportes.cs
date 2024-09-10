using Dominio.Entidades.Dominio.Entidades;
using Dominio.Entidades;
using Dominio.ReglasDelNegocio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AppConsola.LogicaAppConsola
{
    public class LogicaReportes
    {

        //-------------------------------------------------------------------------------------------------------------------------------//

        //                  Adaptcion de los metodos de ProyectosNegocio a la App de Consola               

        //                  Esta clase la voy a dejar para el final.

        //-------------------------------------------------------------------------------------------------------------------------------//

        public static void ReporteEmpleadosConsola(List<Empleado> empleados, List<Proyectos> proyectos)
        {
            // -> Aplicar la logica de la Eliminar/Modificar empleado en LogicaEmpleados. 

            // tengo que cambiar la informacion que brinda este metodo sobre el empleado -> tiene que ser mas orientada a los rendimientos de este: 

            //Proyectos Asignados
            //Horas Trabajadas por Proyecto
            //Tareas Completadas
            //Evaluaciones de Desempeño
            //Metas Alcanzadas
            //Feedback del Supervisor
            //Ausencias o Tardanzas
            //Productividad(Tareas / Proyectos Completados)


            if (empleados.Count == 0)
            {
                MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                return;
            }

            Console.WriteLine($"\n - Reporte de Empleados - \n");

            foreach (var empleado in empleados) // Genera reporte para cada empleado
            {
                string tipoEmpleado = empleado is Gerente ? "Gerente" : empleado is Director ? "Director" : "Empleado Operativo";

                // Mostrar la información del empleado
                Console.WriteLine("# Informacion del empleado");
                Console.WriteLine($"Nombre: {empleado.Nombre} {empleado.Apellido}");
                
                Console.WriteLine($"Edad: {empleado.Edad}"); // fecha de nacimineto 
                Console.WriteLine($"Edad: {empleado.FechaNacimiento}"); // fecha de nacimineto 

                Console.WriteLine($"Puesto: {tipoEmpleado}");
                Console.WriteLine($"Fecha de Ingreso");//Ingreso en la empresa
                Console.WriteLine($"Salario Base: ${empleado.SalarioBase}");
                Console.WriteLine($"Bonos: ${empleado.CalcularBonos()}");
                Console.WriteLine($"Salario Final: ${empleado.CalcularSalario()}");

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
                        Console.WriteLine($"- {proyecto.Nombre}."); /*, Presupuesto: { proyecto.Presupuesto}*/
                    }
                }
                else
                    Console.WriteLine("\nEl empleado no tiene proyectos asignados.");
                //MetodosAuxiliares.MostrarMensaje("\nEl empleado no tiene proyectos asignados.");


                //Console.WriteLine(new string('-', 50)); // Separador para cada empleado
                Console.WriteLine("\n -------------------- # -------------------- # -------------------- \n");
            }

            MetodosAuxiliares.MostrarMensaje("Fin del reporte.");
        }


        public static void ReporteProyectosConsola(List<Proyectos> proyectos)
        {
            // Items que oodria agregar:
            // podria agregar si el proyecto esta activo o no lo esta ...
            //Empleados Asignados
            //Progreso(%)
            //Tareas Completadas
            //Horas Trabajadas
            //Problemas
            //Retrasos
            //presupuesto
            //Gastos 


            if (proyectos == null || proyectos.Count == 0)
            {
                MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                return;
            }

            Console.WriteLine("\n - Reporte Proyectos - \n");

            foreach (var proyecto in proyectos)
            {
                Console.WriteLine("# Informacionn del proyecto");
                Console.WriteLine($"Proyecto: {proyecto.Nombre}");
                Console.WriteLine($"Descripción: {proyecto.Descripcion}");
                Console.WriteLine($"Fecha de Inicio: {proyecto.FechaInicio.ToShortDateString()}");
                Console.WriteLine($"Fecha de Fin: {proyecto.FechaFin.ToShortDateString()}");
                Console.WriteLine($"Presupuesto: ${proyecto.Presupuesto}");

                if (proyecto.EmpleadosAsignados != null && proyecto.EmpleadosAsignados.Count > 0) // Lista de empleados asignados al proyecto
                {
                    Console.WriteLine("\nEmpleados Asignados:");
                    foreach (var empleado in proyecto.EmpleadosAsignados)
                    {
                        string tipoEmpleado = empleado is Gerente ? "Gerente" : empleado is Director ? "Director" : "Empleado Operativo";
                        Console.WriteLine($"- {empleado.Nombre} {empleado.Apellido}; Posicion: {tipoEmpleado}.");
                    }
                }
                else
                    Console.WriteLine("No hay empleados asignados a este proyecto.");


                Console.WriteLine("\n -------------------- # -------------------- # -------------------- \n");
            }

            MetodosAuxiliares.MostrarMensaje("Fin del reporte.");
        }

        public static void ReporteFinancieroConsola(List<Empleado> empleados, List<Proyectos> proyectos)
        {
            // este reporte financiero responde a un proyecto? a un empleado? o a la "empresa"?

            //Reporte de Finanzas de la Empresa:
            //Presupuesto Total Asignado a Proyectos
            //Gastos Totales en Proyectos
            //Salarios Totales Pagados
            //Bonos Totales Pagados
            //Costos Operativos Generales(Alquiler, servicios, etc.)
            //Costos Extraordinarios(Equipos, licencias, etc.)
            //Beneficio Neto de la Empresa
            //Diferencia entre Presupuesto y Gastos Totales

            try
            {
                ReporteFinanzas reporteFinanzas = CalcularTotalesFinancieros(empleados, proyectos);
                Console.WriteLine("\n - Reporte Financiero - \n");
                Console.WriteLine($"Total Gastos en Salarios: ${reporteFinanzas.TotalSalarios}");
                Console.WriteLine($"Total Gastos en Bonos: ${reporteFinanzas.TotalBonos}");
                Console.WriteLine($"Total Presupuestos de Proyectos: ${reporteFinanzas.TotalPresupuestosProyectos}");
                MetodosAuxiliares.MostrarMensaje($"Total Gastos (Salarios + Bonos + Presupuestos): ${reporteFinanzas.TotalGastos}");
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
