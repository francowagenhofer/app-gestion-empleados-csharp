using Dominio.Entidades.Dominio.Entidades;
using Dominio.ReglasDelNegocio;
using Dominio.Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppConsola.LogicaAppConsola;
using System.ComponentModel.Design;
using System.Data;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.Common;

namespace AppConsola
{
    public class LogicaProyectos  // Adaptcion de los metodos de ProyectosNegocio a la App de Consola.
    {
        public static void MenuProyectos()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n Administrar Proyectos\n");
                    //Console.WriteLine("1. Lista de Proyectos");
                    //Console.WriteLine("2. Informacion de Proyecto");
                    //Console.WriteLine("3. Agregar Proyecto");
                    //Console.WriteLine("4. Modificar Datos de Proyecto");
                    //Console.WriteLine("5. Cambiar Estado");
                    //Console.WriteLine("6. Eliminar Proyecto");
                    //Console.WriteLine("7. Asignar Empleado a Proyecto");
                    //Console.WriteLine("8. Desasignar Empleado de Proyecto");
                    //Console.WriteLine("\n9. Regresar al menú anterior\n");
                    Console.WriteLine("1. Ver lista de proyectos registrados\n");
                    Console.WriteLine("2. Ver detalles de un proyecto específico\n");
                    Console.WriteLine("3. Registrar un nuevo proyecto\n");
                    Console.WriteLine("4. Editar los detalles de un proyecto\n");
                    Console.WriteLine("5. Cambiar el estado de un proyecto\n");
                    Console.WriteLine("6. Eliminar un proyecto del sistema\n");
                    Console.WriteLine("7. Gestionar Asignaciones y Desasignaciones");
                    Console.WriteLine("\n8. Volver");
                    Console.Write("\nSeleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            ListaProyectosConsola();
                            ResumenProyectosConsola();
                            break;
                        case "2":
                            InformacionProyectoConsola();
                            break;
                        case "3":
                            AgregarProyectoConsola();
                            break;
                        case "4":
                            ModificarDatosDelProyectoConsola();
                            break;
                        case "5":
                            CambiarEstadoProyectoConsola();
                            break;
                        case "6":
                            EliminarProyectoConsola();
                            break;
                        case "7":
                            SubmenuAsignacionesDesasignacionesProyectos();
                            break;
                        case "8":
                            return;
                        default:
                            Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
                }
            }
        }

        public static void SubmenuAsignacionesDesasignacionesProyectos()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Gestión de Asignaciones y Desasignaciones de Proyecto\n");
                    Console.WriteLine(" Asignar\n");
                    Console.WriteLine("1. Asignar un empleado a un proyecto\n");
                    Console.WriteLine("2. Asignar un rol a un empleado dentro de un proyecto\n");
                    Console.WriteLine("3. Asignar una tarea a un proyecto\n");
                    Console.WriteLine("4. Asignar una tarea a un empleado dentro de un proyecto\n");
                    Console.WriteLine(" - # - \n");
                    Console.WriteLine(" Desasignar\n");
                    Console.WriteLine("5. Desasignar a un empleado de un proyecto\n");
                    Console.WriteLine("6. Desasignar un rol a un empleado de un proyecto\n");
                    Console.WriteLine("7. Desasignar una tarea de un proyecto\n");
                    Console.WriteLine("8. Desasignar una tarea de un empleado dentro de un Proyecto\n");
                    Console.WriteLine("\n9. Volver");
                    Console.Write("\nSeleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            AsignarEmpleadoAProyectoConsola();
                            break;
                        case "2":
                            LogicaRoles.AsignarRolAEmpleadoEnProyectoConsola();
                            break;
                        case "3":
                            LogicaTareas.AsignarTareaAProyectoConsola();
                            break;
                        case "4":
                            LogicaTareas.AsignarTareaAEmpleadoEnProyectoConsola();
                            break;
                        case "5":
                            LogicaTareas.DesasignarTareaDeEmpleadoEnProyectoConsola();
                            break;
                        case "6":
                            LogicaRoles.DesasignarRolDeEmpleadoEnProyectoConsola();
                            break;
                        case "7":
                            LogicaTareas.DesasignarTareaDeProyectoConsola();
                            break;
                        case "8":
                            LogicaTareas.DesasignarTareaDeEmpleadoEnProyectoConsola();
                            break;
                        case "9":
                            return;
                        default:
                            Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
                }
            }
        }

        //-------------------------------------------------------------------------------------------//

        public static void ListaProyectosConsola() //Bien. 
        {
            ProyectosNegocio proyectoNegocio = new ProyectosNegocio();
            try
            {
                List<Proyectos> proyectos = proyectoNegocio.ListarProyectos();

                if (proyectos == null || proyectos.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }

                Console.WriteLine("\n- Lista de Proyectos -\n");
                for (int i = 0; i < proyectos.Count; i++)
                {
                    string estadoProyecto = proyectos[i].IsActive ? "Activo" : "Inactivo";

                    Console.WriteLine($"{i + 1}) Id: {proyectos[i].Id}; Nombre: {proyectos[i].Nombre}; Estado: {estadoProyecto}.");
                }
                Negocio.MetodosAuxiliares.MostrarMensaje($"\n - # -");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError: {ex.Message}\n");
            }
        }

        public static void ResumenProyectosConsola() // Bien. Podria mejorar  
        {
            ProyectosNegocio proyectosNegocio = new ProyectosNegocio();
            try
            {
                List<Proyectos> proyectos = proyectosNegocio.ListarProyectos();

                if (proyectos.Count > 0)
                {
                    List<Proyectos> proyectosActivos = proyectos.Where(p => p.IsActive).ToList();
                    int totalProyectosActivos = proyectosActivos.Count;

                    List<Proyectos> proyectosInactivos = proyectos.Where(p => !p.IsActive).ToList();
                    int totalProyectosInactivos = proyectosInactivos.Count;

                    // Mejorar esto... tendria que agregar una tabla en la base de datos con los estados capaz ...
                    //int totalEnCurso = proyectos.Count(p => p.EstadoProyecto == "En Curso");
                    //int totalCompletados = proyectos.Count(p => p.EstadoProyecto == "Completado");
                    //int totalPendientes = proyectos.Count(p => p.EstadoProyecto == "Pendiente");

                    Console.WriteLine("\n- Resumen de Proyectos -\n");
                    Console.WriteLine($"- Total de Proyectos: {proyectos.Count}");

                    //Console.WriteLine($"- Proyectos En Curso: {totalEnCurso}");
                    //Console.WriteLine($"- Proyectos Completados: {totalCompletados}");
                    //Console.WriteLine($"- Proyectos Pendientes: {totalPendientes}");

                    Console.WriteLine($"- Proyectos Activos: {totalProyectosActivos}");
                    MetodosAuxiliares.MostrarMensaje($"- Proyectos Inactivos: {totalProyectosInactivos}");
                }
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al mostrar el resumen de proyectos: {ex.Message}");
            }
        }
        
        public static void InformacionProyectoConsola() // Bien. 
        {
            ProyectosNegocio proyectoNegocio = new ProyectosNegocio();
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
            RolNegocio rolNegocio = new RolNegocio();
            TareasNegocio tareasNegocio = new TareasNegocio();

            try
            {
                List<Proyectos> listaProyectos = proyectoNegocio.ListarProyectos();

                if (listaProyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }

                ListaProyectosConsola();

                Console.Write("\nIngrese el Id del proyecto a buscar: ");
                string criterio = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(criterio))
                {
                    MetodosAuxiliares.MostrarMensaje("\nDebe ingresar un Id válido para buscar.");
                    return;
                }

                if (int.TryParse(criterio, out int idProyecto))
                {
                    var proyectoEncontrado = listaProyectos.SingleOrDefault(p => p.Id == idProyecto);
                    if (proyectoEncontrado != null)
                    {
                        proyectoEncontrado.EmpleadosAsignados = empleadoNegocio.ListarEmpleadosAsignados(idProyecto);
                        proyectoEncontrado.RolesAsignados = rolNegocio.ListarRolesDeEmpleadosEnProyecto(idProyecto);
                        proyectoEncontrado.TareasAsignadas = tareasNegocio.ListarTareasAsignadasAProyecto(idProyecto);

                        Console.WriteLine("\n- Información del proyecto -");
                        Console.WriteLine($"\nNombre: {proyectoEncontrado.Nombre}");
                        Console.WriteLine($"\nDescripción: {proyectoEncontrado.Descripcion}");
                        Console.WriteLine($"\nFecha de Inicio: {proyectoEncontrado.FechaInicio.ToShortDateString()}");
                        Console.WriteLine($"\nFecha de Fin: {proyectoEncontrado.FechaFin.ToShortDateString()}");
                        Console.WriteLine($"\nPresupuesto: ${proyectoEncontrado.Presupuesto}");
                        Console.WriteLine($"\nEstado: {proyectoEncontrado.EstadoProyecto}");

                        // Mostrar empleados asignados al proyecto
                        if (proyectoEncontrado.EmpleadosAsignados.Count > 0)
                        {
                            Console.WriteLine("\n# Empleados asignados al proyecto:\n");
                            for (int i = 0; i < proyectoEncontrado.EmpleadosAsignados.Count; i++)
                            {
                                var empleado = proyectoEncontrado.EmpleadosAsignados[i];
                                Console.WriteLine($"{i + 1}) Id: {empleado.Id} - Nombre: {empleado.Nombre} {empleado.Apellido}");
                            }
                        }
                        else
                            Console.WriteLine("\n# No hay empleados asignados a este proyecto.");

                        // Mostrar roles asignados
                        if (proyectoEncontrado.RolesAsignados.Count > 0)
                        {
                            Console.WriteLine("\n# Roles asignados al proyecto:\n");
                            for (int i = 0; i < proyectoEncontrado.RolesAsignados.Count; i++)
                            {
                                var rol = proyectoEncontrado.RolesAsignados[i];
                                Console.WriteLine($"{i + 1}) Id: {rol.Id} - Rol: {rol.Nombre}.");
                            }
                        }
                        else
                            Console.WriteLine("\n# No hay roles asignados a este proyecto.");

                        // Mostrar tareas asignadas
                        if (proyectoEncontrado.TareasAsignadas.Count > 0)
                        {
                            Console.WriteLine("\n# Tareas asignadas al proyecto:\n");
                            for (int i = 0; i < proyectoEncontrado.TareasAsignadas.Count; i++)
                            {
                                var tarea = proyectoEncontrado.TareasAsignadas[i];
                                Console.WriteLine($"{i + 1}) Id: {tarea.Id} - Tarea: {tarea.Nombre}.");

                                //// Mostrar empleados asignados a la tarea
                                //var empleadosAsignados = tareasNegocio.ListarEmpleadosAsignadosATarea(tarea.Id, idProyecto);
                                //if (empleadosAsignados.Count > 0)
                                //{
                                //    Console.WriteLine("\nEmpleados asignados a esta tarea del proyecto:"); // tendria que corregir esto en el metodo.
                                //    foreach (var empleado in empleadosAsignados)
                                //    {
                                //        Console.WriteLine($"- {empleado.Nombre} {empleado.Apellido}");
                                //    }
                                //}
                                //else
                                //    MetodosAuxiliares.MostrarMensaje("No hay empleados asignados a esta tarea.");
                            }
                        }
                        else
                            Console.WriteLine("\n# No hay tareas asignadas a este proyecto.");
                    }
                    else
                        MetodosAuxiliares.MostrarMensaje("\nNo se encontró un proyecto con ese Id.");
                }
                else
                    MetodosAuxiliares.MostrarMensaje("\nEl Id ingresado no es válido.");

                MetodosAuxiliares.MostrarMensaje("\n - # -");

            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al buscar proyecto: {ex.Message}\n");
            }
        }

        public static void AgregarProyectoConsola() //Bien.
        {
            Proyectos nuevoProyecto = new Proyectos();
            ProyectosNegocio proyectosNegocio = new ProyectosNegocio();
            while (true)
            {
                try
                {
                    Console.WriteLine("\n- Agregar Nuevo Proyecto -\n");
                    nuevoProyecto.Nombre = Negocio.MetodosAuxiliares.LeerDato("Nombre del Proyecto");
                    nuevoProyecto.Descripcion = Negocio.MetodosAuxiliares.LeerDato("\nDescripción del Proyecto");
                    nuevoProyecto.FechaInicio = DateTime.Parse(Negocio.MetodosAuxiliares.LeerDato("\nFecha de Inicio (dd/MM/yyyy)"));
                    nuevoProyecto.FechaFin = DateTime.Parse(Negocio.MetodosAuxiliares.LeerDato("\nFecha de Fin (dd/MM/yyyy)"));
                    nuevoProyecto.Presupuesto = decimal.Parse(Negocio.MetodosAuxiliares.LeerDato("\nPresupuesto del Proyecto"));
                    nuevoProyecto.EstadoProyecto = "Pendiente";
                    nuevoProyecto.IsActive = true;

                    proyectosNegocio.AgregarProyecto(nuevoProyecto);

                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nEl proyecto '{nuevoProyecto.Nombre}' ha sido agregado exitosamente.");

                    break;
                }
                catch (FormatException ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nError de formato: Asegúrate de ingresar los datos correctamente.");
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado al agregar el proyecto: {ex.Message}");
                }
            }
        }

        public static void ModificarDatosDelProyectoConsola() //Bien.
        {
            ProyectosNegocio proyectosNegocio = new ProyectosNegocio();
            try
            {
                List<Proyectos> proyectos = proyectosNegocio.ListarProyectos();

                if (proyectos == null || proyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }

                ListaProyectosConsola();

                Console.WriteLine("\n- Modificar información de un proyecto -\n");

                int proyectoId;
                bool esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("Id del proyecto", ""), out proyectoId);

                if (!esNumeroValido || !proyectos.Any(p => p.Id == proyectoId))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de proyecto no válido. Inténtalo de nuevo.");
                    return;
                }

                var proyectoSeleccionado = proyectos.First(p => p.Id == proyectoId);


                Console.WriteLine("\nCampos a modificar:\n");
                Console.WriteLine("1. Nombre");
                Console.WriteLine("2. Fecha de Inicio");
                Console.WriteLine("3. Fecha de Fin");
                Console.WriteLine("4. Descripción");
                Console.WriteLine("5. Presupuesto");
                Console.WriteLine("6. Estado del Proyecto");
                Console.Write("\nSeleccione una opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        proyectoSeleccionado.Nombre = MetodosAuxiliares.LeerDato("\nNuevo nombre", proyectoSeleccionado.Nombre);
                        break;
                    case 2:
                        proyectoSeleccionado.FechaInicio = DateTime.Parse(MetodosAuxiliares.LeerDato("\nNueva fecha de inicio (dd/MM/yyyy)", proyectoSeleccionado.FechaInicio.ToString("dd/MM/yyyy")));
                        break;
                    case 3:
                        proyectoSeleccionado.FechaFin = DateTime.Parse(MetodosAuxiliares.LeerDato("\nNueva fecha de fin (dd/MM/yyyy)", proyectoSeleccionado.FechaFin.ToString("dd/MM/yyyy")));
                        break;
                    case 4:
                        proyectoSeleccionado.Descripcion = MetodosAuxiliares.LeerDato("\nNueva descripción", proyectoSeleccionado.Descripcion);
                        break;
                    case 5:
                        proyectoSeleccionado.Presupuesto = Convert.ToDecimal(MetodosAuxiliares.LeerDato("\nNuevo presupuesto", proyectoSeleccionado.Presupuesto.ToString()));
                        break;
                    case 6:
                        proyectoSeleccionado.EstadoProyecto = MetodosAuxiliares.LeerDato("\nNuevo estado del proyecto", proyectoSeleccionado.EstadoProyecto); 
                        break;
                    default:
                        MetodosAuxiliares.MostrarMensaje("Opción no válida.");
                        return;
                }

                proyectosNegocio.ModificarProyecto(proyectoSeleccionado);

                MetodosAuxiliares.MostrarMensaje("\nLos datos del proyecto han sido actualizados exitosamente.");
            }
            catch (FormatException fe)
            {
                MetodosAuxiliares.MostrarMensaje("\nFormato de entrada incorrecto. Inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al modificar el proyecto: {ex.Message}");
            }
        }

        public static void CambiarEstadoProyectoConsola() //Bien. 
        {
            ProyectosNegocio proyectosNegocio = new ProyectosNegocio();
            try
            {
                List<Proyectos> listaProyectos = proyectosNegocio.ListarProyectos();
                if (listaProyectos.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }
                ListaProyectosConsola();

                Console.WriteLine("\n- Activar/Desactivar Proyecto -\n");

                int proyectoId;
                bool esNumeroValido = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("Id del Proyecto", ""), out proyectoId);

                if (!esNumeroValido || !listaProyectos.Any(p => p.Id == proyectoId))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nId de proyecto no válido. Inténtalo de nuevo.");
                    return;
                }

                string estado = Negocio.MetodosAuxiliares.LeerDato("\n¿Activar o desactivar? (a/d)", "").ToLower();
                bool activar = estado == "a";

                proyectosNegocio.ActualizarEstadoProyecto(proyectoId, activar);
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nProyecto {(activar ? "activado" : "desactivado")} correctamente.");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al cambiar el estado del proyecto: {ex.Message}");
            }
        }

        public static void EliminarProyectoConsola() //Bien. 
        {
            ProyectosNegocio proyectosNegocio = new ProyectosNegocio();

            try
            {
                List<Proyectos> proyectos = proyectosNegocio.ListarProyectos();
                if (proyectos == null || proyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }
                ListaProyectosConsola();

                Console.WriteLine("\n- Eliminar Proyecto -\n");

                int proyectoId;
                bool esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("ID del Proyecto a eliminar", ""), out proyectoId);

                if (!esNumeroValido || !proyectos.Any(p => p.Id == proyectoId))
                {
                    MetodosAuxiliares.MostrarMensaje("\nID de proyecto no válido. Inténtalo de nuevo.");
                    return;
                }

                string confirmacion = MetodosAuxiliares.LeerDato("\n¿Estás seguro de que quieres eliminar este proyecto? (s/n)", "").ToLower();
                if (confirmacion != "s")
                {
                    MetodosAuxiliares.MostrarMensaje("\nOperación cancelada.");
                    return;
                }

                proyectosNegocio.EliminarProyecto(proyectoId);
                MetodosAuxiliares.MostrarMensaje("\nProyecto eliminado correctamente.");
            }
            catch (FormatException fe)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError de formato: {fe.Message}");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al eliminar el proyecto: {ex.Message}");
            }
        }

        public static void AsignarEmpleadoAProyectoConsola() //Bien.
        {
            ProyectosNegocio proyectosNegocio = new ProyectosNegocio();
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();

            try
            {
                List<Proyectos> proyectos = proyectosNegocio.ListarProyectos();
                List<Empleado> empleados = empleadoNegocio.ListarEmpleados();

                if (proyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }
                else if (empleados.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }

                Console.WriteLine("\n- Asignar Empleado a Proyecto -");

                ListaProyectosConsola();

                int seleccionProyecto;
                bool esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el ID del proyecto", ""), out seleccionProyecto);

                if (!esNumeroValido || !proyectos.Any(p => p.Id == seleccionProyecto))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de proyecto no válido. Inténtalo de nuevo.");
                    return;
                }

                LogicaAppConsola.LogicaEmpleados.ListaEmpleadosConsola();

                int seleccionEmpleado;
                esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el ID del empleado", ""), out seleccionEmpleado);

                if (!esNumeroValido || !empleados.Any(e => e.Id == seleccionEmpleado))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de empleado no válido. Inténtalo de nuevo.");
                    return;
                }

                List<Proyectos> proyectosAsignados = proyectosNegocio.ListarProyectosAsignadosEmpleado(seleccionEmpleado);
                if (proyectosAsignados.Any(p => p.Id == seleccionProyecto))
                {
                    MetodosAuxiliares.MostrarMensaje("\nEl empleado ya está asignado a este proyecto. No se puede asignar más de una vez.");
                    return;
                }

                proyectosNegocio.AsignarEmpleadoAProyecto(seleccionProyecto, seleccionEmpleado);
                MetodosAuxiliares.MostrarMensaje("\nEmpleado asignado al proyecto correctamente.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al asignar empleado al proyecto: {ex.Message}");
            }
        }

        public static void DesasignarEmpleadoDeProyectoConsola() //Bien. 
        // Seria ideal poder mostrar una lista de los empleados que hay en el proyecto seleccionado ...         
        {
            try
            {
                ProyectosNegocio proyectosNegocio = new ProyectosNegocio();
                EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();

                List<Proyectos> proyectos = proyectosNegocio.ListarProyectos();
                List<Empleado> empleados = empleadoNegocio.ListarEmpleados();

                if (proyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }

                Console.WriteLine("\n- Desasignar Empleado de Proyecto -");

                ListaProyectosConsola();

                int seleccionProyecto;
                bool esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el ID del proyecto", ""), out seleccionProyecto);

                if (!esNumeroValido || !proyectos.Any(p => p.Id == seleccionProyecto))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de proyecto no válido. Inténtalo de nuevo.");
                    return;
                }

                List<Empleado> empleadosAsignados = empleadoNegocio.ListarEmpleadosAsignados(seleccionProyecto);

                if (empleadosAsignados.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay empleados asignados a este proyecto.");
                    return;
                }

                LogicaAppConsola.LogicaEmpleados.ListaEmpleadosConsola();

                int seleccionEmpleado;
                esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el ID del empleado a desasignar", ""), out seleccionEmpleado);

                if (!esNumeroValido || !empleadosAsignados.Any(e => e.Id == seleccionEmpleado))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de empleado no válido. Inténtalo de nuevo.");
                    return;
                }

                proyectosNegocio.DesasignarEmpleadoDeProyecto(seleccionProyecto, seleccionEmpleado);
                MetodosAuxiliares.MostrarMensaje("\nEmpleado desasignado del proyecto correctamente.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al ejecutar la operación: {ex.Message}");
            }
        }


        // estos por ahora no se usan ...
        public static void ProyectosActivosConsola()
        {
            ProyectosNegocio proyectoNegocio = new ProyectosNegocio();
            try
            {
                List<Proyectos> listaProyectos = proyectoNegocio.ListarProyectos();

                if (listaProyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }

                Console.WriteLine("\n-- Proyectos Activos --");
                foreach (var proyecto in listaProyectos)
                {
                    if (DateTime.Now >= proyecto.FechaInicio && DateTime.Now <= proyecto.FechaFin)
                    {
                        //MostrarInformacionProyecto(proyecto);     Metodo que ya no esta disponible
                    }
                }
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al mostrar proyectos activos: {ex.Message}");
            }
        }
        public static void ProyectosNoActivosConsola()
        {
            ProyectosNegocio proyectoNegocio = new ProyectosNegocio();
            try
            {
                List<Proyectos> listaProyectos = proyectoNegocio.ListarProyectos();

                if (listaProyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }

                Console.WriteLine("\n-- Proyectos No Activos --");
                foreach (var proyecto in listaProyectos)
                {
                    if (DateTime.Now > proyecto.FechaFin)
                    {
                        //MostrarInformacionProyecto(proyecto);         Metodo que ya no esta disponible
                    }
                }
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al mostrar proyectos no activos: {ex.Message}");
            }
        }

    }
}
