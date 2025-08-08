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
    public class LogicaReportes // Adaptcion de los metodos de ReportesNegocio a la App de Consola.
    {
        //  Reporte de Empleados 
        public static void MenuReporteEmpleados()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\nReporte Empleados\n");
                    Console.WriteLine("1. Ver detalles de reporte\n");
                    Console.WriteLine("2. Generar nuevo reporte\n");
                    Console.WriteLine("3. Modificar dellates de reporte\n");
                    Console.WriteLine("4. Eliminar reporte\n");
                    Console.WriteLine("\n5. Volver");
                    Console.Write("\nSeleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            MostrarReportesEmpleadosConsola();
                            break;
                        case "2":
                            GenerarReporteEmpleadoConsola();
                            break;
                        case "3":
                            ModificarReporteEmpleadoConsola();
                            break;
                        case "4":
                            EliminarReporteEmpleadoConsola();
                            break;
                        case "5":
                            return;
                        default:
                            Negocio.MetodosAuxiliares.MostrarMensaje("\nOpción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
                }

            }
        }

        public static void MostrarReportesEmpleadosConsola() // Bien. 
        {
            try
            {
                ReportesNegocio reportesNegocio = new ReportesNegocio();

                List<ReporteEmpleado> reportes = reportesNegocio.ObtenerReportesEmpleados();
                if (reportes == null || reportes.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay reportes de empleados disponibles.");
                    return;
                }
                Console.WriteLine("\n- Lista de Reportes de Empleados -\n");
                for (int i = 0; i < reportes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id Reporte: {reportes[i].Id} - Nombre Empleado: {reportes[i].NombreEmpleado}; Categoría: {reportes[i].Categoria}.");
                }

                Console.WriteLine("\n- Resumen de Reportes de Empleados -\n");
                int totalReportes = reportes.Count;
                int totalOperativos = reportes.Count(r => r.Categoria == "Operativo");
                int totalGerentes = reportes.Count(r => r.Categoria == "Gerente");
                int totalDirectores = reportes.Count(r => r.Categoria == "Director");
                Console.WriteLine($"- Total de Reportes: {totalReportes}");
                Console.WriteLine($"- Reportes de Operativos: {totalOperativos}");
                Console.WriteLine($"- Reportes de Gerentes: {totalGerentes}");
                Console.WriteLine($"- Reportes de Directores: {totalDirectores}");

                Console.Write("\nIngrese el Id del reporte para ver más detalles: ");
                string seleccion = Console.ReadLine()?.Trim();

                if (int.TryParse(seleccion, out int idSeleccionado))
                {
                    var reporteSeleccionado = reportes.FirstOrDefault(r => r.Id == idSeleccionado);

                    if (reporteSeleccionado != null)
                    {
                        Console.WriteLine("\n- Detalles del Reporte de Empleado -\n");
                        Console.WriteLine($"ID: {reporteSeleccionado.Id}");
                        Console.WriteLine($"Nombre Empleado: {reporteSeleccionado.NombreEmpleado}");
                        Console.WriteLine($"Categoría: {reporteSeleccionado.Categoria}");
                        Console.WriteLine($"Salario Actual: ${reporteSeleccionado.SalarioActual}");
                        Console.WriteLine($"Total Bonos: ${reporteSeleccionado.TotalBonos}");
                        Console.WriteLine($"Proyectos Asignados: {reporteSeleccionado.ProyectosAsignados}");
                        Console.WriteLine($"Roles Asignados: {reporteSeleccionado.RolesAsignados}");
                        Console.WriteLine($"Tareas Asignadas: {reporteSeleccionado.TareasAsignadas}");
                        Console.WriteLine($"Fecha de Generación: {reporteSeleccionado.FechaGeneracion.ToShortDateString()}");
                        Negocio.MetodosAuxiliares.MostrarMensaje("\n - # - ");
                    }
                    else
                    {
                        Negocio.MetodosAuxiliares.MostrarMensaje("\nNo se encontró un reporte con el ID ingresado.");
                    }
                }
                else
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nEntrada no válida. Asegúrese de ingresar un ID numérico.");
                }
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al mostrar los reportes de empleados: {ex.Message}\n");
            }
        }

        public static void GenerarReporteEmpleadoConsola() // Bien. 
        {
            try
            {
                Console.WriteLine("\n- Generar Reporte de Empleado -");

                LogicaEmpleados.ListaEmpleadosConsola();

                Console.Write("\nIngrese el Id del empleado: ");
                string input = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int idEmpleado))
                {
                    Console.WriteLine("\nDebe ingresar un Id válido.");
                    return;
                }

                ReportesNegocio reportesNegocio = new ReportesNegocio();

                ReporteEmpleado nuevoReporte = new ReporteEmpleado
                {
                    IdEmpleado = idEmpleado,
                    FechaGeneracion = DateTime.Now
                };

                reportesNegocio.GenerarReporteEmpleados(nuevoReporte);

                Negocio.MetodosAuxiliares.MostrarMensaje($"\nReporte generado exitosamente para el empleado con Id {idEmpleado}.");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al generar el reporte: {ex.Message}");
            }
        }

        public static void ModificarReporteEmpleadoConsola() // Bien. 
        {
            try
            {
                ReportesNegocio reportesNegocio = new ReportesNegocio();
                List<ReporteEmpleado> reportes = reportesNegocio.ObtenerReportesEmpleados();

                if (reportes == null || reportes.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("No hay reportes de empleados disponibles para modificar.");
                    return;
                }

                Console.WriteLine("\n- Lista de Reportes de Empleados -\n");
                for (int i = 0; i < reportes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id Reporte: {reportes[i].Id} - Nombre Empleado: {reportes[i].NombreEmpleado}; Categoría: {reportes[i].Categoria}");
                }

                Console.Write("\nIngrese el ID del reporte que desea modificar: ");
                if (!int.TryParse(Console.ReadLine()?.Trim(), out int idSeleccionado) || !reportes.Any(r => r.Id == idSeleccionado))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nSelección no válida. Intente nuevamente.");
                    return;
                }

                ReporteEmpleado reporteModificado = reportes.First(r => r.Id == idSeleccionado);
                bool salir = false;

                while (!salir)
                {
                    Console.WriteLine("\nSeleccione el campo del reporte que desea modificar:\n");
                    Console.WriteLine("1. Nombre Empleado");
                    Console.WriteLine("2. Categoría");
                    Console.WriteLine("3. Salario Actual");
                    Console.WriteLine("4. Total Bonos");
                    Console.WriteLine("5. Proyectos Asignados");
                    Console.WriteLine("6. Roles Asignados");
                    Console.WriteLine("7. Tareas Asignadas");
                    Console.WriteLine("8. Fecha de Generación");
                    Console.WriteLine("9. Guardar y salir");
                    Console.Write("\nIngrese el número de la opción: ");
                    string opcion = Console.ReadLine()?.Trim();

                    switch (opcion)
                    {
                        case "1":
                            Console.Write($"\nNombre Empleado ({reporteModificado.NombreEmpleado}): ");
                            string nombreEmpleado = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(nombreEmpleado))
                                reporteModificado.NombreEmpleado = nombreEmpleado;
                            break;

                        case "2":
                            Console.Write($"\nCategoría ({reporteModificado.Categoria}): ");
                            string categoria = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(categoria))
                                reporteModificado.Categoria = categoria;
                            break;

                        case "3":
                            Console.Write($"Salario Actual ({reporteModificado.SalarioActual}): ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal salarioNuevo))
                                reporteModificado.SalarioActual = salarioNuevo;
                            break;

                        case "4":
                            Console.Write($"\nTotal Bonos ({reporteModificado.TotalBonos}): ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal bonosNuevo))
                                reporteModificado.TotalBonos = bonosNuevo;
                            break;

                        case "5":
                            Console.Write($"\nProyectos Asignados ({reporteModificado.ProyectosAsignados}): ");
                            string proyectosAsignados = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(proyectosAsignados))
                                reporteModificado.ProyectosAsignados = proyectosAsignados;
                            break;

                        case "6":
                            Console.Write($"\nRoles Asignados ({reporteModificado.RolesAsignados}): ");
                            string rolesAsignados = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(rolesAsignados))
                                reporteModificado.RolesAsignados = rolesAsignados;
                            break;

                        case "7":
                            Console.Write($"\nTareas Asignadas ({reporteModificado.TareasAsignadas}): ");
                            string tareasAsignadas = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(tareasAsignadas))
                                reporteModificado.TareasAsignadas = tareasAsignadas;
                            break;

                        case "8":
                            Console.Write($"\nFecha de Generación ({reporteModificado.FechaGeneracion.ToShortDateString()}): ");
                            if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaNueva))
                                reporteModificado.FechaGeneracion = fechaNueva;
                            break;

                        case "9":
                            reportesNegocio.ModificarReporteEmpleados(reporteModificado);
                            Negocio.MetodosAuxiliares.MostrarMensaje("\nEl reporte ha sido modificado exitosamente.");
                            salir = true;
                            break;

                        default:
                            Negocio.MetodosAuxiliares.MostrarMensaje("\nOpción no válida. Intente nuevamente.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al modificar el reporte de empleado: {ex.Message}");
            }
        }

        public static void EliminarReporteEmpleadoConsola() // Bien.
        {
            try
            {
                ReportesNegocio reportesNegocio = new ReportesNegocio();

                List<ReporteEmpleado> reportes = reportesNegocio.ObtenerReportesEmpleados();
                if (reportes == null || reportes.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("No hay reportes de empleados disponibles para eliminar.");
                    return;
                }
                Console.WriteLine("\n- Lista de Reportes de Empleados -\n");
                for (int i = 0; i < reportes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id Reporte: {reportes[i].Id} - Nombre Empleado: {reportes[i].NombreEmpleado}; Categoría: {reportes[i].Categoria}");
                }

                Console.Write("\nIngrese el número del reporte que desea eliminar: ");
                string seleccion = Console.ReadLine()?.Trim();

                if (int.TryParse(seleccion, out int numeroSeleccionado) && numeroSeleccionado > 0 && numeroSeleccionado <= reportes.Count)
                {
                    int idReporte = reportes[numeroSeleccionado - 1].Id;

                    Console.Write($"\n¿Está seguro que desea eliminar el reporte de {reportes[numeroSeleccionado - 1].NombreEmpleado}? (S/N): ");
                    string confirmacion = Console.ReadLine()?.Trim().ToUpper();

                    if (confirmacion == "S")
                    {
                        reportesNegocio.EliminarReporteEmpleados(idReporte);
                        Negocio.MetodosAuxiliares.MostrarMensaje("\nReporte eliminado exitosamente.");
                    }
                    else
                    {
                        Negocio.MetodosAuxiliares.MostrarMensaje("\nEliminación cancelada.");
                    }
                }
                else
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nSelección no válida. Intente nuevamente.");
                }
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al intentar eliminar el reporte: {ex.Message}");
            }
        }

        public static void MenuReporteProyectos()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\nReporte Proyectos\n");
                    Console.WriteLine("1. Ver detalles de reporte\n");
                    Console.WriteLine("2. Generar nuevo reporte\n");
                    Console.WriteLine("3. Modificar dellates de reporte\n");
                    Console.WriteLine("4. Eliminar reporte\n");
                    Console.WriteLine("\n5. Volver");
                    Console.Write("\nSeleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            MostrarReportesProyectosConsola();
                            break;
                        case "2":
                            GenerarReporteProyectoConsola();
                            break;
                        case "3":
                            ModificarReporteProyectoConsola();
                            break;
                        case "4":
                            EliminarReporteProyectoConsola();
                            break;
                        case "5":
                            return;
                        default:
                            Negocio.MetodosAuxiliares.MostrarMensaje("\nOpción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
                }

            }
        }

        public static void MostrarReportesProyectosConsola() // Bien. 
        {
            try
            {
                ReportesNegocio reportesNegocio = new ReportesNegocio();
                List<ReporteProyecto> reportes = reportesNegocio.ObtenerReportesProyectos();

                if (reportes == null || reportes.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay reportes de proyectos disponibles.");
                    return;
                }

                Console.WriteLine("\n- Lista de Reportes de Proyectos -\n");
                for (int i = 0; i < reportes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id Reporte: {reportes[i].Id} - Nombre Proyecto: {reportes[i].NombreProyecto}; Estado: {reportes[i].EstadoProyecto}.");
                }

                Console.WriteLine("\n- Resumen de Reportes de Proyectos -\n");
                int totalReportes = reportes.Count;
                int totalCompletados = reportes.Count(r => r.EstadoProyecto == "Completado");
                int totalEnCurso = reportes.Count(r => r.EstadoProyecto == "En Curso");
                Console.WriteLine($"- Total de Reportes: {totalReportes}");
                Console.WriteLine($"- Reportes Completados: {totalCompletados}");
                Console.WriteLine($"- Reportes En Curso: {totalEnCurso}");

                Console.Write("\nIngrese el Id del reporte para ver más detalles: ");
                string seleccion = Console.ReadLine()?.Trim();

                if (int.TryParse(seleccion, out int idSeleccionado))
                {
                    var reporteSeleccionado = reportes.FirstOrDefault(r => r.Id == idSeleccionado);

                    if (reporteSeleccionado != null)
                    {
                        Console.WriteLine("\n- Detalles del Reporte de Proyecto -\n");
                        Console.WriteLine($"ID: {reporteSeleccionado.Id}");
                        Console.WriteLine($"Nombre Proyecto: {reporteSeleccionado.NombreProyecto}");
                        Console.WriteLine($"Estado: {reporteSeleccionado.EstadoProyecto}");
                        Console.WriteLine($"Asignaciones de Empleados: {reporteSeleccionado.AsignacionesEmpleados}");
                        Console.WriteLine($"Tareas Asignadas: {reporteSeleccionado.TareasAsignadas}");
                        Console.WriteLine($"Roles Asignados: {reporteSeleccionado.RolesAsignados}");
                        Console.WriteLine($"Tiempo Estimado: {reporteSeleccionado.TiempoEstimado} horas");
                        Console.WriteLine($"Presupuesto: ${reporteSeleccionado.Presupuesto}");
                        Console.WriteLine($"Fecha de Generación: {reporteSeleccionado.FechaGeneracion.ToShortDateString()}");
                        Negocio.MetodosAuxiliares.MostrarMensaje("\n - # - ");
                    }
                    else
                    {
                        Negocio.MetodosAuxiliares.MostrarMensaje("\nNo se encontró un reporte con el ID ingresado.");
                    }
                }
                else
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nEntrada no válida. Asegúrese de ingresar un ID numérico.");
                }
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al mostrar los reportes de proyectos: {ex.Message}");
            }
        }

        public static void GenerarReporteProyectoConsola() // Bien. 
        {
            try
            {
                Console.WriteLine("\n- Generar Reporte de Proyecto -");

                LogicaProyectos.ListaProyectosConsola();

                Console.Write("\nIngrese el Id del proyecto: ");
                string input = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int idProyecto))
                {
                    Console.WriteLine("\nDebe ingresar un Id válido.");
                    return;
                }

                ReportesNegocio reportesNegocio = new ReportesNegocio();

                ReporteProyecto nuevoReporte = new ReporteProyecto
                {
                    IdProyecto = idProyecto,
                    FechaGeneracion = DateTime.Now
                };

                reportesNegocio.GenerarReporteProyectos(nuevoReporte);

                Negocio.MetodosAuxiliares.MostrarMensaje($"\nReporte generado exitosamente para el proyecto con Id {idProyecto}.");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al generar el reporte: {ex.Message}");
            }
        }

        public static void ModificarReporteProyectoConsola() // Bien. 
        {
            try
            {
                ReportesNegocio reportesNegocio = new ReportesNegocio();
                List<ReporteProyecto> reportes = reportesNegocio.ObtenerReportesProyectos();

                if (reportes == null || reportes.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("No hay reportes de proyectos disponibles para modificar.");
                    return;
                }

                Console.WriteLine("\n- Lista de Reportes de Proyectos -\n");
                for (int i = 0; i < reportes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id Reporte: {reportes[i].Id} - Nombre Proyecto: {reportes[i].NombreProyecto}; Estado: {reportes[i].EstadoProyecto}; Presupuesto: ${reportes[i].Presupuesto}");
                }

                Console.Write("\nIngrese el ID del reporte que desea modificar: ");
                if (!int.TryParse(Console.ReadLine()?.Trim(), out int idSeleccionado) || !reportes.Any(r => r.Id == idSeleccionado))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nSelección no válida. Intente nuevamente.");
                    return;
                }

                ReporteProyecto reporteModificado = reportes.First(r => r.Id == idSeleccionado);
                bool salir = false;

                while (!salir)
                {
                    Console.WriteLine("\nSeleccione el campo del reporte que desea modificar:\n");
                    Console.WriteLine("1. Nombre Proyecto");
                    Console.WriteLine("2. Estado");
                    Console.WriteLine("3. Presupuesto");
                    Console.WriteLine("4. Fecha de Generación (No modificable)");
                    Console.WriteLine("5. Asignaciones de Empleados");
                    Console.WriteLine("6. Tareas Asignadas");
                    Console.WriteLine("7. Roles Asignados");
                    Console.WriteLine("8. Tiempo Estimado");
                    Console.WriteLine("9. Guardar y salir");
                    Console.Write("\nIngrese el número de la opción: ");
                    string opcion = Console.ReadLine()?.Trim();

                    switch (opcion)
                    {
                        case "1":
                            Console.Write($"\nNombre Proyecto ({reporteModificado.NombreProyecto}): ");
                            string nombreProyecto = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(nombreProyecto))
                                reporteModificado.NombreProyecto = nombreProyecto;
                            break;

                        case "2":
                            Console.Write($"\nEstado ({reporteModificado.EstadoProyecto}): ");
                            string estado = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(estado))
                                reporteModificado.EstadoProyecto = estado;
                            break;

                        case "3":
                            Console.Write($"Presupuesto Actual (${reporteModificado.Presupuesto}): ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal presupuestoNuevo))
                                reporteModificado.Presupuesto = presupuestoNuevo;
                            break;

                        case "5":
                            Console.Write($"\nAsignaciones de Empleados ({reporteModificado.AsignacionesEmpleados}): ");
                            string asignaciones = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(asignaciones))
                                reporteModificado.AsignacionesEmpleados = asignaciones;
                            break;

                        case "6":
                            Console.Write($"\nTareas Asignadas ({reporteModificado.TareasAsignadas}): ");
                            string tareas = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(tareas))
                                reporteModificado.TareasAsignadas = tareas;
                            break;

                        case "7":
                            Console.Write($"\nRoles Asignados ({reporteModificado.RolesAsignados}): ");
                            string roles = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(roles))
                                reporteModificado.RolesAsignados = roles;
                            break;

                        case "8":
                            Console.Write($"\nTiempo Estimado (Actual: {reporteModificado.TiempoEstimado} horas): ");
                            if (int.TryParse(Console.ReadLine(), out int tiempoEstimadoNuevo))
                                reporteModificado.TiempoEstimado = tiempoEstimadoNuevo;
                            break;

                        case "9":
                            reportesNegocio.ModificarReporteProyectos(reporteModificado);
                            Negocio.MetodosAuxiliares.MostrarMensaje("\nReporte modificado exitosamente.");
                            salir = true;
                            break;

                        default:
                            Negocio.MetodosAuxiliares.MostrarMensaje("\nOpción no válida. Intente nuevamente.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"Error al modificar el reporte: {ex.Message}");
            }
        }

        public static void EliminarReporteProyectoConsola() // Bien. 
        {
            try
            {
                ReportesNegocio reportesNegocio = new ReportesNegocio();

                List<ReporteProyecto> reportes = reportesNegocio.ObtenerReportesProyectos();
                if (reportes == null || reportes.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("No hay reportes de proyectos disponibles para eliminar.");
                    return;
                }
                Console.WriteLine("\n- Lista de Reportes de Proyectos -\n");
                for (int i = 0; i < reportes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id Reporte: {reportes[i].Id} - Nombre Proyecto: {reportes[i].NombreProyecto}; Estado: {reportes[i].EstadoProyecto}");
                }

                Console.Write("\nIngrese el número del reporte que desea eliminar: ");
                string seleccion = Console.ReadLine()?.Trim();

                if (int.TryParse(seleccion, out int numeroSeleccionado) && numeroSeleccionado > 0 && numeroSeleccionado <= reportes.Count)
                {
                    // Obtener el ID del reporte a eliminar
                    int idReporte = reportes[numeroSeleccionado - 1].Id;

                    Console.Write($"\n¿Está seguro que desea eliminar el reporte con Id {idReporte}? (s/n): ");
                    if (Console.ReadLine()?.Trim().ToLower() == "s")
                    {
                        reportesNegocio.EliminarReporteProyectos(idReporte);
                        Negocio.MetodosAuxiliares.MostrarMensaje("\nReporte eliminado exitosamente.");
                    }
                    else
                        Negocio.MetodosAuxiliares.MostrarMensaje("\nOperación cancelada.");
                }
                else
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nSelección no válida. Intente nuevamente.");

            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al eliminar el reporte de proyecto: {ex.Message}");
            }
        }

        public static void MenuReporteFinanzas()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\nReporte Finanzas\n");
                    Console.WriteLine("1. Ver detalles de reporte\n");
                    Console.WriteLine("2. Generar nuevo reporte\n");
                    Console.WriteLine("3. Modificar dellates de reporte\n");
                    Console.WriteLine("4. Eliminar reporte\n");
                    Console.WriteLine("\n5. Volver");
                    Console.Write("\nSeleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            MostrarReportesFinanzasConsola();
                            break;
                        case "2":
                            GenerarReporteFinanzasConsola();
                            break;
                        case "3":
                            ModificarReporteFinanzasConsola();
                            break;
                        case "4":
                            EliminarReporteFinanzasConsola();
                            break;
                        case "5":
                            return;
                        default:
                            Negocio.MetodosAuxiliares.MostrarMensaje("\nOpción no válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
                }

            }
        }

        public static void MostrarReportesFinanzasConsola() // Bien.
        {
            try
            {
                ReportesNegocio reportesNegocio = new ReportesNegocio();
                List<ReporteFinanzas> reportes = reportesNegocio.ObtenerReportesFinanzas();

                if (reportes == null || reportes.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay reportes de finanzas disponibles.");
                    return;
                }

                Console.WriteLine("\n- Lista de Reportes de Finanzas -\n");
                for (int i = 0; i < reportes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id reporte finanzas: {reportes[i].Id} - fecha de generación {reportes[i].FechaGeneracion}.");
                }

                Console.WriteLine($"\nTotal de reportes de finanzas: {reportes.Count}");

                Console.Write("\nIngrese el Id del reporte que desea ver en detalle: ");
                if (int.TryParse(Console.ReadLine(), out int idSeleccionado))
                {
                    ReporteFinanzas reporteSeleccionado = reportes.FirstOrDefault(r => r.Id == idSeleccionado);

                    Console.WriteLine("\n- Detalles del Reporte de Finanzas -\n");
                    Console.WriteLine($"Id reporte: {reporteSeleccionado.Id}");
                    Console.WriteLine($"Total Salarios: {reporteSeleccionado.TotalSalarios}");
                    Console.WriteLine($"Total Bonos: {reporteSeleccionado.TotalBonos}");
                    Console.WriteLine($"Total Presupuestos Proyectos: {reporteSeleccionado.TotalPresupuestosProyectos}");
                    Console.WriteLine($"Total Gastos: {reporteSeleccionado.TotalGastos}");
                    Console.WriteLine($"Fecha de Generación: {reporteSeleccionado.FechaGeneracion}");
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\n - # - ");
                }
                else
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nSelección no válida. Intente nuevamente.");
                
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al mostrar los reportes de finanzas: {ex.Message}");
            }
        }

        public static void GenerarReporteFinanzasConsola() // Bien.
        {
            try
            {
                Console.WriteLine("\n- Generar Reporte de Finanzas -\n");

                Console.Write("¿Desea generar el reporte de finanzas? (si / no): ");
                string respuesta = Console.ReadLine().Trim().ToLower();

                if (respuesta == "si")
                {
                    ReporteFinanzas nuevoReporte = new ReporteFinanzas
                    {
                        FechaGeneracion = DateTime.Now
                    };

                    ReportesNegocio reportesNegocio = new ReportesNegocio();
                    reportesNegocio.GenerarReporteFinanzas(nuevoReporte);
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nReporte de finanzas generado exitosamente.");
                }
                else
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nOperación cancelada.");
                }
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al generar el reporte de finanzas: {ex.Message}");
            }
        }

        public static void ModificarReporteFinanzasConsola() // Bien.
        {
            try
            {
                ReportesNegocio reportesNegocio = new ReportesNegocio();
                List<ReporteFinanzas> reportes = reportesNegocio.ObtenerReportesFinanzas();

                if (reportes == null || reportes.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("No hay reportes de finanzas disponibles para modificar.");
                    return;
                }

                Console.WriteLine("\n- Lista de Reportes de finanzas -\n");
                for (int i = 0; i < reportes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id reporte finanzas: {reportes[i].Id} - fecha de generación {reportes[i].FechaGeneracion}.");
                }
                Negocio.MetodosAuxiliares.MostrarMensaje($"\n - # - ");

                Console.WriteLine("\n- Modificar reporte de finanzas -");
                Console.Write("\nIngrese el Id del reporte que desea modificar: ");
                if (!int.TryParse(Console.ReadLine()?.Trim(), out int idSeleccionado) || !reportes.Any(r => r.Id == idSeleccionado))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nSelección no válida. Intente nuevamente.");
                    return;
                }

                ReporteFinanzas reporteModificado = reportes.First(r => r.Id == idSeleccionado);

                bool continuar = true;
                while (continuar)
                {
                    Console.WriteLine("\nSeleccione el campo que desea modificar: \n");
                    Console.WriteLine("1. Total Salarios");
                    Console.WriteLine("2. Total Bonos");
                    Console.WriteLine("3. Total Presupuestos Proyectos");
                    Console.WriteLine("4. Finalizar modificaciones");
                    Console.Write("\nOpción: ");
                    string opcion = Console.ReadLine()?.Trim();

                    switch (opcion)
                    {
                        case "1":
                            Console.Write("\nIngrese el nuevo valor para Total Salarios: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal nuevoTotalSalarios))
                            {
                                reporteModificado.TotalSalarios = nuevoTotalSalarios;
                            }
                            else
                                Console.WriteLine("Valor inválido.");

                            break;
                        case "2":
                            Console.Write("\nIngrese el nuevo valor para Total Bonos: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal nuevoTotalBonos))
                            {
                                reporteModificado.TotalBonos = nuevoTotalBonos;
                            }
                            else
                                Console.WriteLine("Valor inválido.");

                            break;
                        case "3":
                            Console.Write("\nIngrese el nuevo valor para Total Presupuestos Proyectos: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal nuevoTotalPresupuestos))
                            {
                                reporteModificado.TotalPresupuestosProyectos = nuevoTotalPresupuestos;
                            }
                            else
                                Console.WriteLine("Valor inválido.");

                            break;
                        case "4":
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }

                reportesNegocio.ModificarReporteFinanzas(reporteModificado);
                Negocio.MetodosAuxiliares.MostrarMensaje("\nReporte de finanzas modificado exitosamente.");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al modificar el reporte de finanzas: {ex.Message}");
            }
        }

        public static void EliminarReporteFinanzasConsola() // Bien. 
        {
            try
            {
                ReportesNegocio reportesNegocio = new ReportesNegocio();
                List<ReporteFinanzas> reportes = reportesNegocio.ObtenerReportesFinanzas();

                if (reportes == null || reportes.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("No hay reportes de finanzas disponibles para eliminar.");
                    return;
                }
                Console.WriteLine("\n- Lista de reportes de finanzas -\n");
                for (int i = 0; i < reportes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id reporte finanzas: {reportes[i].Id} - fecha de generación {reportes[i].FechaGeneracion}.");
                }
                Negocio.MetodosAuxiliares.MostrarMensaje($"\n - # - ");

                Console.WriteLine("\n- Eliminar reportes de finanzas -");
                Console.Write("\nIngrese el Id del reporte que desea eliminar: ");
                if (!int.TryParse(Console.ReadLine(), out int idSeleccionado) || !reportes.Any(r => r.Id == idSeleccionado))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nId no válido. Intente nuevamente.");
                    return;
                }

                Console.Write($"\n¿Está seguro que desea eliminar el reporte con Id {idSeleccionado}? (s/n): ");
                if (Console.ReadLine()?.Trim().ToLower() == "s")
                {
                    reportesNegocio.EliminarReporteFinanzas(idSeleccionado);
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nReporte de finanzas eliminado exitosamente.");
                }
                else
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nOperación cancelada.");

            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al eliminar el reporte de finanzas: {ex.Message}");
            }
        }

    }
}
