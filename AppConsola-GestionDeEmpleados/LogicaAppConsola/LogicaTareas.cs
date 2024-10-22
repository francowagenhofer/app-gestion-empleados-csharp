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
    public class LogicaTareas
    {
        // Gestion de Tareas
        public static void MenuTareas()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\nAministrar Tareas\n");
                    Console.WriteLine("1. Lista de Tareas");
                    Console.WriteLine("2. Informacion de Tarea");
                    Console.WriteLine("3. Agregar Tarea");
                    Console.WriteLine("4. Modificar Tarea");
                    Console.WriteLine("5. Eliminar Tarea");
                    Console.WriteLine("6. Asignar Tarea a un Proyecto");
                    Console.WriteLine("7. Asignar Tarea a un Empleado en Proyecto");
                    Console.WriteLine("8. Desasignar Tarea de un Proyecto");
                    Console.WriteLine("9. Desasignar Tarea a un Empleado en Proyecto");
                    Console.WriteLine("\n10. Volver");
                    Console.Write("\nSeleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            ListarTareasConsola();
                            break;
                        case "2":
                            InformacionTareaConsola();
                            break;
                        case "3":
                            AgregarTareaConsola();
                            break;
                        case "4":
                            ModificarDatosDeLaTareaConsola();
                            break;
                        case "5":
                            EliminarTareaConsola();
                            break;
                        case "6":
                            AsignarTareaAProyectoConsola();
                            break;
                        case "7":
                            AsignarTareaAEmpleadoEnProyectoConsola();
                            break;
                        case "8":
                            DesasignarTareaDeProyectoConsola();
                            break;
                        case "9":
                            DesasignarTareaDeEmpleadoEnProyectoConsola();
                            break;
                        case "10":
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

        public static void ListarTareasConsola() // Bien. 
        {
            TareasNegocio tareaNegocio = new TareasNegocio();
            try
            {
                List<Tareas> tareas = tareaNegocio.ListarTodasLasTareas();

                if (tareas == null || tareas.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay tareas registradas.");
                    return;
                }

                Console.WriteLine("\n- Lista de Tareas -\n");
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id: {tareas[i].Id}; Nombre: {tareas[i].Nombre}; Descripción: {tareas[i].Descripcion}; Estado: {tareas[i].Estado}.");
                }
                Negocio.MetodosAuxiliares.MostrarMensaje("\n - # -");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError: {ex.Message}\n");
            }
        }

        public static void InformacionTareaConsola() // Bien. 
        {
            TareasNegocio tareaNegocio = new TareasNegocio();
            try
            {
                List<Tareas> tareas = tareaNegocio.ListarTodasLasTareas();

                if (tareas == null || tareas.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay tareas registradas.");
                    return;
                }
                ListarTareasConsola();

                int tareaId;
                bool esNumeroValido = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("\nSelecciona una tarea por su Id", ""), out tareaId);

                if (!esNumeroValido || !tareas.Any(t => t.Id == tareaId))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nId de tarea no válido. Inténtalo de nuevo.");
                    return;
                }

                var informacionTarea = tareaNegocio.ObtenerInformacionTarea(tareaId);

                Console.WriteLine($"\n- Información de la Tarea -\n");
                Console.WriteLine($"Id: {informacionTarea.Id}");
                Console.WriteLine($"Nombre: {informacionTarea.Nombre}");
                Console.WriteLine($"Descripción: {informacionTarea.Descripcion}");

                Console.WriteLine($"\nProyectos vinculados:");
                if (informacionTarea.ProyectosAsignados.Count == 0)
                {
                    Console.WriteLine("No hay proyectos asignados a esta tarea.");
                }
                else
                {
                    foreach (var proyecto in informacionTarea.ProyectosAsignados)
                    {
                        Console.WriteLine($"Id: {proyecto.Id}; Nombre: {proyecto.Nombre}");
                    }
                }

                Console.WriteLine($"\nEmpleados Asignados:");
                if (informacionTarea.EmpleadosAsignados.Count == 0)
                {
                    Console.WriteLine("No hay empleados asignados a esta tarea.");
                }
                else
                {
                    foreach (var empleado in informacionTarea.EmpleadosAsignados)
                    {
                        Console.WriteLine($"Id: {empleado.Id}; Nombre: {empleado.Nombre} {empleado.Apellido}");
                    }
                }

                MetodosAuxiliares.MostrarMensaje($"\n - # -");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al obtener la información de la tarea: {ex.Message}");
            }
        }

        public static void AgregarTareaConsola() // Bien. 
        {
            Tareas nuevaTarea = new Tareas();
            TareasNegocio tareaNegocio = new TareasNegocio();
            while (true)
            {
                try
                {
                    Console.WriteLine("\n- Agregar Nueva Tarea -\n");

                    nuevaTarea.Nombre = Negocio.MetodosAuxiliares.LeerDato("Nombre de la Tarea");
                    nuevaTarea.Descripcion = Negocio.MetodosAuxiliares.LeerDato("\nDescripción de la Tarea");
                    nuevaTarea.Estado = Negocio.MetodosAuxiliares.LeerDato("\nEstado de la Tarea");

                    string fechaInicioInput = Negocio.MetodosAuxiliares.LeerDato("\nFecha de Inicio (formato: dd/MM/yyyy)");
                    nuevaTarea.FechaInicio = DateTime.ParseExact(fechaInicioInput, "dd/MM/yyyy", null);

                    string fechaFinInput = Negocio.MetodosAuxiliares.LeerDato("\nFecha de Fin (formato: dd/MM/yyyy)");
                    nuevaTarea.FechaFin = DateTime.ParseExact(fechaFinInput, "dd/MM/yyyy", null);

                    tareaNegocio.AgregarTarea(nuevaTarea);

                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nLa tarea '{nuevaTarea.Nombre}' ha sido agregada exitosamente.");

                    break;
                }
                catch (FormatException ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nError de formato: Asegúrate de ingresar los datos correctamente.");
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado al agregar la tarea: {ex.Message}");
                }
            }
        }

        public static void ModificarDatosDeLaTareaConsola() // Bien.
        {
            TareasNegocio tareaNegocio = new TareasNegocio();
            try
            {
                List<Tareas> listaTareas = tareaNegocio.ListarTodasLasTareas();

                if (listaTareas == null || listaTareas.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay tareas registradas.");
                    return;
                }
                ListarTareasConsola();

                Console.WriteLine("\n- Modificar Tarea -\n");

                int tareaId;
                bool esNumeroValido = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("Id de la Tarea", ""), out tareaId);

                if (!esNumeroValido || !listaTareas.Any(t => t.Id == tareaId))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nId de tarea no válido. Inténtalo de nuevo.");
                    return;
                }

                var tareaSeleccionada = listaTareas.First(t => t.Id == tareaId);

                tareaSeleccionada.Nombre = Negocio.MetodosAuxiliares.LeerDato("\nNuevo nombre", tareaSeleccionada.Nombre);
                tareaSeleccionada.Descripcion = Negocio.MetodosAuxiliares.LeerDato("\nNueva descripción", tareaSeleccionada.Descripcion);
                tareaSeleccionada.Estado = Negocio.MetodosAuxiliares.LeerDato("\nNuevo estado", tareaSeleccionada.Estado);

                tareaNegocio.ModificarTarea(tareaSeleccionada);

                Negocio.MetodosAuxiliares.MostrarMensaje("\nLos datos de la tarea han sido actualizados exitosamente.");
            }
            catch (FormatException fe)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje("\nFormato de entrada incorrecto. Inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al modificar la tarea: {ex.Message}");
            }
        }

        public static void EliminarTareaConsola() // Bien.
        {
            TareasNegocio tareaNegocio = new TareasNegocio();

            try
            {
                List<Tareas> listaTareas = tareaNegocio.ListarTodasLasTareas();
                if (listaTareas == null || listaTareas.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay tareas registradas.");
                    return;
                }

                ListarTareasConsola();

                Console.WriteLine("\n- Eliminar Tarea -\n");

                int tareaId;
                bool esNumeroValido = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("Id de la Tarea a eliminar", ""), out tareaId);

                if (!esNumeroValido || !listaTareas.Any(t => t.Id == tareaId))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nId de tarea no válido. Inténtalo de nuevo.");
                    return;
                }

                string confirmacion = Negocio.MetodosAuxiliares.LeerDato("\n¿Estás seguro de que quieres eliminar esta tarea? (s/n)", "").ToLower();
                if (confirmacion != "s")
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nOperación cancelada.");
                    return;
                }

                tareaNegocio.EliminarTarea(tareaId);
                Negocio.MetodosAuxiliares.MostrarMensaje("\nTarea eliminada correctamente.");
            }
            catch (FormatException fe)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError de formato: {fe.Message}");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al eliminar la tarea: {ex.Message}");
            }
        }

        public static void AsignarTareaAProyectoConsola() // Bien. 
        {
            TareasNegocio tareaNegocio = new TareasNegocio();
            ProyectosNegocio proyectosNegocio = new ProyectosNegocio();

            try
            {
                List<Tareas> listaTareas = tareaNegocio.ListarTodasLasTareas();
                List<Proyectos> listaProyectos = proyectosNegocio.ListarProyectos();

                if (listaTareas.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay tareas registradas.");
                    return;
                }
                else if (listaProyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }

                Console.WriteLine("\n- Asignar Tarea a Proyecto -");

                LogicaProyectos.ListaProyectosConsola();
                int seleccionProyecto;
                bool esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id del proyecto", ""), out seleccionProyecto);
                if (!esNumeroValido || !listaProyectos.Any(p => p.Id == seleccionProyecto))
                {
                    MetodosAuxiliares.MostrarMensaje("\nID de proyecto no válido. Inténtalo de nuevo.");
                    return;
                }

                ListarTareasConsola();

                int seleccionTarea;
                esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id de la tarea", ""), out seleccionTarea);

                if (!esNumeroValido || !listaTareas.Any(t => t.Id == seleccionTarea))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de tarea no válido. Inténtalo de nuevo.");
                    return;
                }

                tareaNegocio.AsignarTareaAProyecto(seleccionTarea, seleccionProyecto);
                MetodosAuxiliares.MostrarMensaje("\nTarea asignada correctamente al proyecto.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al asignar tarea al proyecto: {ex.Message}");
            }
        }

        public static void AsignarTareaAEmpleadoEnProyectoConsola() // Bien.
        {
            TareasNegocio tareaNegocio = new TareasNegocio();
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
            ProyectosNegocio proyectoNegocio = new ProyectosNegocio();

            try
            {
                List<Proyectos> listaProyectos = proyectoNegocio.ListarProyectos();
                if (listaProyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos disponibles.");
                    return;
                }
                LogicaProyectos.ListaProyectosConsola();

                int seleccionProyecto;
                bool esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id del proyecto", ""), out seleccionProyecto);

                if (!esNumeroValido || !listaProyectos.Any(p => p.Id == seleccionProyecto))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de proyecto no válido. Inténtalo de nuevo.");
                    return;
                }

                List<Tareas> listaTareas = tareaNegocio.ListarTareasAsignadasAProyecto(seleccionProyecto);

                if (listaTareas.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay tareas asignadas a este proyecto.");
                    return;
                }

                Console.WriteLine("\n- Tareas asignadas al proyecto -\n");
                for (int i = 0; i < listaTareas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id: {listaTareas[i].Id}; Nombre: {listaTareas[i].Nombre}; Descripción: {listaTareas[i].Descripcion}");
                }
                int seleccionTarea;
                esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id de la tarea", ""), out seleccionTarea);

                if (!esNumeroValido || !listaTareas.Any(t => t.Id == seleccionTarea))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de tarea no válido. Inténtalo de nuevo.");
                    return;
                }

                List<Empleado> empleadosAsignados = empleadoNegocio.ListarEmpleadosAsignados(seleccionProyecto);

                if (empleadosAsignados.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay empleados asignados a este proyecto.");
                    return;
                }

                Console.WriteLine("\n- Empleados asignados al proyecto -\n");
                for (int i = 0; i < empleadosAsignados.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id: {empleadosAsignados[i].Id}; Nombre: {empleadosAsignados[i].Nombre} {empleadosAsignados[i].Apellido}.");
                }

                int seleccionEmpleado;
                esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id del empleado", ""), out seleccionEmpleado);

                if (!esNumeroValido || !empleadosAsignados.Any(e => e.Id == seleccionEmpleado))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de empleado no válido. Inténtalo de nuevo.");
                    return;
                }

                bool yaAsignada = tareaNegocio.VerificarAsignacionTareaEmpleado(seleccionTarea, seleccionEmpleado);

                if (yaAsignada)
                {
                    MetodosAuxiliares.MostrarMensaje("\nLa tarea ya está asignada a este empleado. Asignación cancelada.");
                    return;
                }

                DateTime fechaAsignacion = DateTime.Now;

                tareaNegocio.AsignarTareaAEmpleadoEnProyecto(seleccionTarea, seleccionEmpleado, seleccionProyecto, fechaAsignacion);
                MetodosAuxiliares.MostrarMensaje("\nTarea asignada correctamente al empleado en el proyecto.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al asignar tarea al empleado: {ex.Message}");
            }
        }

        public static void DesasignarTareaDeProyectoConsola() // Bien.
        {
            try
            {
                TareasNegocio tareaNegocio = new TareasNegocio();
                ProyectosNegocio proyectosNegocio = new ProyectosNegocio();

                List<Proyectos> proyectos = proyectosNegocio.ListarProyectos();
                if (proyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }

                Console.WriteLine("\n- Desasignar Tarea de Proyecto -");
                LogicaProyectos.ListaProyectosConsola();

                int seleccionProyecto;
                bool esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id del proyecto", ""), out seleccionProyecto);
                if (!esNumeroValido || !proyectos.Any(p => p.Id == seleccionProyecto))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de proyecto no válido. Inténtalo de nuevo.");
                    return;
                }

                List<Tareas> tareasAsignadas = tareaNegocio.ListarTareasAsignadasAProyecto(seleccionProyecto);
                if (tareasAsignadas.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay tareas asignadas a este proyecto.");
                    return;
                }

                Console.WriteLine("\nTareas asignadas a este proyecto:\n");
                foreach (var tarea in tareasAsignadas)
                {
                    Console.WriteLine($"Id: {tarea.Id} - Nombre: {tarea.Nombre}.");
                }

                int seleccionTarea;
                esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id de la tarea a desasignar", ""), out seleccionTarea);
                if (!esNumeroValido || !tareasAsignadas.Any(t => t.Id == seleccionTarea))
                {
                    MetodosAuxiliares.MostrarMensaje("\nID de tarea no válido. Inténtalo de nuevo.");
                    return;
                }

                tareaNegocio.DesignarTareaAProyecto(seleccionTarea, seleccionProyecto);
                MetodosAuxiliares.MostrarMensaje("\nTarea desasignada del proyecto correctamente.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al ejecutar la operación: {ex.Message}");
            }
        }

        public static void DesasignarTareaDeEmpleadoEnProyectoConsola() // Bien.
        {
            try
            {
                TareasNegocio tareaNegocio = new TareasNegocio();
                EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
                ProyectosNegocio proyectosNegocio = new ProyectosNegocio();

                List<Proyectos> proyectos = proyectosNegocio.ListarProyectos();
                if (proyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }
                LogicaProyectos.ListaProyectosConsola();

                int seleccionProyecto;
                bool esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id de un proyecto para ver las tareas asignadas", ""), out seleccionProyecto);
                if (!esNumeroValido || !proyectos.Any(p => p.Id == seleccionProyecto))
                {
                    MetodosAuxiliares.MostrarMensaje("\nID de proyecto no válido. Inténtalo de nuevo.");
                    return;
                }

                List<Tareas> tareasAsignadas = tareaNegocio.ListarTareasAsignadasAProyecto(seleccionProyecto);
                if (tareasAsignadas.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay tareas asignadas a este proyecto.");
                    return;
                }

                Console.WriteLine("\n- Tareas asignadas a este proyecto -\n");
                for (int i = 0; i < tareasAsignadas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id: {tareasAsignadas[i].Id} - Nombre: {tareasAsignadas[i].Nombre}.");
                }

                int seleccionTarea;
                esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id de la tarea", ""), out seleccionTarea);
                if (!esNumeroValido || !tareasAsignadas.Any(t => t.Id == seleccionTarea))
                {
                    MetodosAuxiliares.MostrarMensaje("\nID de tarea no válido. Inténtalo de nuevo.");
                    return;
                }

                List<Empleado> empleadosAsignados = tareaNegocio.ListarEmpleadosAsignadosATarea(seleccionTarea, seleccionProyecto);
                if (empleadosAsignados.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay empleados asignados a esta tarea en el proyecto.");
                    return;
                }

                Console.WriteLine("\n- Empleados asignados a esta tarea -\n");
                for (int i = 0; i < empleadosAsignados.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id: {empleadosAsignados[i].Id} - Nombre: {empleadosAsignados[i].Nombre} {empleadosAsignados[i].Apellido}");
                }

                int seleccionEmpleado;
                esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id del empleado a desasignar", ""), out seleccionEmpleado);
                if (!esNumeroValido || !empleadosAsignados.Any(e => e.Id == seleccionEmpleado))
                {
                    MetodosAuxiliares.MostrarMensaje("\nID de empleado no válido. Inténtalo de nuevo.");
                    return;
                }

                tareaNegocio.DesasignarTareaDeEmpleado(seleccionEmpleado, seleccionProyecto);

                MetodosAuxiliares.MostrarMensaje("\nTarea desasignada del empleado correctamente.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al ejecutar la operación: {ex.Message}");
            }
        }




    }
}
