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
    public class LogicaRoles // Adaptcion de los metodos de RolNegocio a la App de Consola.
    {
        public static void MenuRoles()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n Administrar Roles\n");
                    Console.WriteLine("1. Ver lista de roles registrados\n");
                    Console.WriteLine("2. Ver detalles de un rol específico\n");
                    Console.WriteLine("3. Registrar un nuevo rol\n");
                    Console.WriteLine("4. Editar los detalles de un rol\n");
                    Console.WriteLine("5. Eliminar un rol del sistema\n");
                    Console.WriteLine("\n6. Volver");
                    Console.Write("\nSeleccione una opción: ");



                    switch (Console.ReadLine())
                    {
                        case "1":
                            ListarRolesConsola();
                            break;
                        case "2":
                            InformacionRolesConsola();
                            break;
                        case "3":
                            AgregarRolConsola();
                            break;
                        case "4":
                            ModificarDatosDelRolConsola();
                            break;
                        //case "5":
                        //    AsignarRolAEmpleadoEnProyectoConsola();
                        //    break;
                        //case "6":
                        //    DesasignarRolDeEmpleadoEnProyectoConsola();
                        //    break;
                        case "5":
                            EliminarRolConsola();
                            break;
                        case "6":
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

        public static void ListarRolesConsola() // Bien. 
        {
            RolNegocio rolesNegocio = new RolNegocio();
            try
            {
                List<Rol> roles = rolesNegocio.ListarRoles();

                if (roles == null || roles.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay roles registrados.");
                    return;
                }

                Console.WriteLine("\n- Lista de Roles -\n");
                for (int i = 0; i < roles.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id: {roles[i].Id} - Nombre del rol: {roles[i].Nombre}.");
                }
                Negocio.MetodosAuxiliares.MostrarMensaje("\n - # -");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError: {ex.Message}\n");
            }
        }
  
        public static void InformacionRolesConsola() // Bien. 
        {
            RolNegocio rolesNegocio = new RolNegocio();
            try
            {
                List<Rol> roles = rolesNegocio.ListarRoles();

                if (roles == null || roles.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay roles registrados.");
                    return;
                }
                ListarRolesConsola(); 

                int rolId;
                bool esNumeroValido = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("\nSelecciona un rol por su Id", ""), out rolId);

                if (!esNumeroValido || !roles.Any(r => r.Id == rolId))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nId de rol no válido. Inténtalo de nuevo.");
                    return;
                }

                var informacionRol = rolesNegocio.ObtenerInformacionRol(rolId);

                Console.WriteLine($"\n- Información del Rol -\n");
                Console.WriteLine($"Id: {informacionRol.Id}");
                Console.WriteLine($"Nombre: {informacionRol.Nombre}");
                Console.WriteLine($"Descripción: {informacionRol.Descripcion}");

                Console.WriteLine($"\nProyectos vinculados:\n");
                if (informacionRol.ProyectosAsignados.Count == 0)
                {
                    Console.WriteLine("No hay proyectos asignados a este rol.");
                }
                else
                {
                    foreach (var proyecto in informacionRol.ProyectosAsignados)
                    {
                        Console.WriteLine($"Id: {proyecto.Id} - Nombre del proyecto: {proyecto.Nombre}");
                    }
                }

                Console.WriteLine($"\nEmpleados Asignados:\n");
                if (informacionRol.EmpleadosAsignados.Count == 0)
                {
                    Console.WriteLine("No hay empleados asignados a este rol.");
                }
                else
                {
                    foreach (var empleado in informacionRol.EmpleadosAsignados)
                    {
                        Console.WriteLine($"Id: {empleado.Id} - Nombre del empleado: {empleado.Nombre} {empleado.Apellido}");
                    }
                }

                MetodosAuxiliares.MostrarMensaje($"\n - # -");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al obtener la información del rol: {ex.Message}");
            }
        }

        public static void AgregarRolConsola() // Bien. 
        {
            Rol nuevoRol = new Rol();
            RolNegocio rolesNegocio = new RolNegocio();
            while (true)
            {
                try
                {
                    Console.WriteLine("\n- Agregar Nuevo Rol -\n");

                    nuevoRol.Nombre = Negocio.MetodosAuxiliares.LeerDato("Nombre del Rol");
                    nuevoRol.Descripcion = Negocio.MetodosAuxiliares.LeerDato("\nDescripción del Rol");

                    rolesNegocio.CrearRol(nuevoRol); 

                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nEl rol '{nuevoRol.Nombre}' ha sido agregado exitosamente.");

                    break;
                }
                catch (FormatException ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nError de formato: Asegúrate de ingresar los datos correctamente.");
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado al agregar el rol: {ex.Message}");
                }
            }
        }

        public static void ModificarDatosDelRolConsola() // Bien. 
        {
            RolNegocio rolesNegocio = new RolNegocio();
            try
            {
                List<Rol> listaRoles = rolesNegocio.ListarRoles();

                if (listaRoles == null || listaRoles.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay roles registrados.");
                    return;
                }
                ListarRolesConsola();

                Console.WriteLine("\n- Modificar Rol -\n");

                int rolId;
                bool esNumeroValido = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("Id del Rol", ""), out rolId);

                if (!esNumeroValido || !listaRoles.Any(r => r.Id == rolId))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nId de rol no válido. Inténtalo de nuevo.");
                    return;
                }

                var rolSeleccionado = listaRoles.First(r => r.Id == rolId);

                rolSeleccionado.Nombre = Negocio.MetodosAuxiliares.LeerDato("\nNuevo nombre", rolSeleccionado.Nombre);
                rolSeleccionado.Descripcion = Negocio.MetodosAuxiliares.LeerDato("\nNueva descripción", rolSeleccionado.Descripcion);

                rolesNegocio.ModificarRol(rolSeleccionado);

                Negocio.MetodosAuxiliares.MostrarMensaje("\nLos datos del rol han sido actualizados exitosamente.");
            }
            catch (FormatException fe)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje("\nFormato de entrada incorrecto. Inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al modificar el rol: {ex.Message}");
            }
        }

        public static void EliminarRolConsola() // Bien. 
        {
            RolNegocio rolesNegocio = new RolNegocio();

            try
            {

                List<Rol> listaRoles = rolesNegocio.ListarRoles();
                if (listaRoles == null || listaRoles.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay roles registrados.");
                    return;
                }

                ListarRolesConsola();

                Console.WriteLine("\n- Eliminar Rol -\n");

                int rolId;
                bool esNumeroValido = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("Id del Rol a eliminar", ""), out rolId);

                if (!esNumeroValido || !listaRoles.Any(r => r.Id == rolId))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nId de rol no válido. Inténtalo de nuevo.");
                    return;
                }

                string confirmacion = Negocio.MetodosAuxiliares.LeerDato("\n¿Estás seguro de que quieres eliminar este rol? (s/n)", "").ToLower();
                if (confirmacion != "s")
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nOperación cancelada.");
                    return;
                }

                rolesNegocio.EliminarRol(rolId);
                Negocio.MetodosAuxiliares.MostrarMensaje("\nRol eliminado correctamente.");
            }
            catch (FormatException fe)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError de formato: {fe.Message}");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al eliminar el rol: {ex.Message}");
            }
        }

        public static void AsignarRolAEmpleadoEnProyectoConsola() // Bien.
        {
            RolNegocio rolesNegocio = new RolNegocio();
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
            ProyectosNegocio proyectosNegocio = new ProyectosNegocio();

            try
            {
                List<Rol> listaRoles = rolesNegocio.ListarRoles();
                List<Empleado> listaEmpleados = empleadoNegocio.ListarEmpleados();
                List<Proyectos> listaProyectos = proyectosNegocio.ListarProyectos();

                if (listaRoles.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay roles registrados.");
                    return;
                }
                else if (listaEmpleados.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }
                else if (listaProyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }

                Console.WriteLine("\n- Asignar rol a empleado en proyecto -");

                // Mostrar lista de proyectos
                LogicaProyectos.ListaProyectosConsola();
                int seleccionProyecto;
                bool esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id del proyecto", ""), out seleccionProyecto);

                if (!esNumeroValido || !listaProyectos.Any(p => p.Id == seleccionProyecto))
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
                Console.WriteLine("\n- Empleados asignados al proyecto -\n");
                for (int i = 0; i < empleadosAsignados.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Id: {empleadosAsignados[i].Id} - Nombre: {empleadosAsignados[i].Nombre} {empleadosAsignados[i].Apellido}");
                }

                int seleccionEmpleado;
                esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id del empleado", ""), out seleccionEmpleado);

                if (!esNumeroValido || !listaEmpleados.Any(e => e.Id == seleccionEmpleado))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de empleado no válido. Inténtalo de nuevo.");
                    return;
                }

                ListarRolesConsola();

                int seleccionRol;
                esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id del rol", ""), out seleccionRol);

                if (!esNumeroValido || !listaRoles.Any(r => r.Id == seleccionRol))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de rol no válido. Inténtalo de nuevo.");
                    return;
                }

                rolesNegocio.AsignarRolAEmpleadoEnProyecto(seleccionEmpleado, seleccionRol, seleccionProyecto);
                MetodosAuxiliares.MostrarMensaje("\nRol asignado correctamente al empleado en el proyecto.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al asignar rol: {ex.Message}");
            }
        }

        public static void DesasignarRolDeEmpleadoEnProyectoConsola() // Bien.
        {
            RolNegocio rolesNegocio = new RolNegocio();
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
            ProyectosNegocio proyectosNegocio = new ProyectosNegocio();

            try
            {
                List<Proyectos> listaProyectos = proyectosNegocio.ListarProyectos();

                if (listaProyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }

                Console.WriteLine("\n- Desasignar rol de empleado en proyecto -");

                LogicaProyectos.ListaProyectosConsola();

                int seleccionProyecto;
                bool esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el ID del proyecto", ""), out seleccionProyecto);

                if (!esNumeroValido || !listaProyectos.Any(p => p.Id == seleccionProyecto))
                {
                    MetodosAuxiliares.MostrarMensaje("\nID de proyecto no válido. Inténtalo de nuevo.");
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
                    Console.WriteLine($"{i + 1}) Id: {empleadosAsignados[i].Id} - Nombre: {empleadosAsignados[i].Nombre} {empleadosAsignados[i].Apellido}");
                }

                int seleccionEmpleado;
                esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id del empleado a desasignar del rol", ""), out seleccionEmpleado);

                if (!esNumeroValido || !empleadosAsignados.Any(e => e.Id == seleccionEmpleado))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de empleado no válido. Inténtalo de nuevo.");
                    return;
                }

                rolesNegocio.DesasignarRolDeEmpleadoEnProyecto(seleccionEmpleado, seleccionProyecto);
                MetodosAuxiliares.MostrarMensaje("\nRol desasignado correctamente del empleado en el proyecto.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al desasignar rol: {ex.Message}");
            }
        }

    }
}
