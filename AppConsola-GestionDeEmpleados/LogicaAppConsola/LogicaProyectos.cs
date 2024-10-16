using Dominio.Entidades.Dominio.Entidades;
using Dominio.Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppConsola.LogicaAppConsola;

namespace AppConsola
{
    public class LogicaProyectos  // Adaptcion de los metodos de ProyectosNegocio a la App de Consola.
    {
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

        public static void ResumenProyectosConsola() //Bien. Falta mejorar 
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

        public static void InformacionProyectoConsola() //Bien. 
        // podria agreagar:
        // - roles de proyecto.
        // - tareas del proyecto       
        {
            ProyectosNegocio proyectoNegocio = new ProyectosNegocio();
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();

            try
            {
                List<Proyectos> listaProyectos = proyectoNegocio.ListarProyectos();

                if (listaProyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }

                ListaProyectosConsola();

                //Console.WriteLine("\n- Buscar proyecto -\n");
                Console.Write("\nIngrese el ID del proyecto a buscar: ");
                string criterio = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(criterio))
                {
                    MetodosAuxiliares.MostrarMensaje("\nDebe ingresar un ID válido para buscar.");
                    return;
                }

                if (int.TryParse(criterio, out int idProyecto)) // Buscar por ID
                {
                    var proyectoEncontrado = listaProyectos.SingleOrDefault(p => p.Id == idProyecto);
                    if (proyectoEncontrado != null)
                    {
                        proyectoEncontrado.EmpleadosAsignados = empleadoNegocio.ListarEmpleadosAsignados(idProyecto);

                        Console.WriteLine("\n- Información del proyecto -\n");
                        Console.WriteLine($"Nombre: {proyectoEncontrado.Nombre}");
                        Console.WriteLine($"Descripción: {proyectoEncontrado.Descripcion}");
                        Console.WriteLine($"Fecha de Inicio: {proyectoEncontrado.FechaInicio.ToShortDateString()}");
                        Console.WriteLine($"Fecha de Fin: {proyectoEncontrado.FechaFin.ToShortDateString()}");
                        Console.WriteLine($"Presupuesto: ${proyectoEncontrado.Presupuesto}");

                        if (proyectoEncontrado.EmpleadosAsignados != null && proyectoEncontrado.EmpleadosAsignados.Count > 0)
                        {
                            Console.WriteLine("\nEmpleados asignados:");
                            foreach (var empleado in proyectoEncontrado.EmpleadosAsignados)
                            {
                                Console.WriteLine($"- {empleado.Nombre} {empleado.Apellido}. Id: {empleado.Id}.");
                                // solo falta agreagr la categoria del empleado ...
                            }
                        }
                        else
                            Console.WriteLine("\nNo hay empleados asignados a este proyecto.");
                    }
                    else
                        MetodosAuxiliares.MostrarMensaje("\nNo se encontró un proyecto con ese ID.");
                }
                else
                    MetodosAuxiliares.MostrarMensaje("\nEl ID ingresado no es válido.");

                MetodosAuxiliares.MostrarMensaje("\n - # -");

            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al buscar proyecto: {ex.Message}\n");
            }
        }

        public static void AgregarProyectoConsola() //Bien. Algo no me cierra 
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
                    nuevoProyecto.EstadoProyecto = "Pendiente"; // no me cierra este...
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

        public static void ModificarDatosDelProyectoConsola() //Bien. Algo para cambiar  
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

                Console.WriteLine("\n- Modificar Proyecto -\n");

                int proyectoId;
                bool esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("ID del Proyecto", ""), out proyectoId);

                if (!esNumeroValido || !proyectos.Any(p => p.Id == proyectoId))
                {
                    MetodosAuxiliares.MostrarMensaje("\nID de proyecto no válido. Inténtalo de nuevo.");
                    return;
                }

                var proyectoSeleccionado = proyectos.First(p => p.Id == proyectoId);

                Console.WriteLine("\nSeleccione el campo a modificar:");
                Console.WriteLine("1. Nombre");
                Console.WriteLine("2. Fecha de Inicio");
                Console.WriteLine("3. Fecha de Fin");
                Console.WriteLine("4. Descripción");
                Console.WriteLine("5. Presupuesto");
                Console.WriteLine("6. Estado del Proyecto");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        proyectoSeleccionado.Nombre = MetodosAuxiliares.LeerDato("Nuevo nombre", proyectoSeleccionado.Nombre);
                        break;
                    case 2:
                        proyectoSeleccionado.FechaInicio = DateTime.Parse(MetodosAuxiliares.LeerDato("Nueva fecha de inicio (dd/MM/yyyy)", proyectoSeleccionado.FechaInicio.ToString("dd/MM/yyyy")));
                        break;
                    case 3:
                        proyectoSeleccionado.FechaFin = DateTime.Parse(MetodosAuxiliares.LeerDato("Nueva fecha de fin (dd/MM/yyyy)", proyectoSeleccionado.FechaFin.ToString("dd/MM/yyyy")));
                        break;
                    case 4:
                        proyectoSeleccionado.Descripcion = MetodosAuxiliares.LeerDato("Nueva descripción", proyectoSeleccionado.Descripcion);
                        break;
                    case 5:
                        proyectoSeleccionado.Presupuesto = Convert.ToDecimal(MetodosAuxiliares.LeerDato("Nuevo presupuesto", proyectoSeleccionado.Presupuesto.ToString()));
                        break;
                    case 6:
                        proyectoSeleccionado.EstadoProyecto = MetodosAuxiliares.LeerDato("Nuevo estado del proyecto", proyectoSeleccionado.EstadoProyecto); // mejorar este ...
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
