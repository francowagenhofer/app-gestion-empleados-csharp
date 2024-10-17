using Dominio.Entidades;
using Dominio.Entidades.Dominio.Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppConsola.LogicaAppConsola
{
    public class LogicaEmpleados  // Adaptcion de los metodos de EmpleadoNegocio a la logica de la App de Consola.
    {
        public static void ListaEmpleadosConsola() //Bien.
        {
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
            try
            {
                List<Empleado> empleados = empleadoNegocio.ListarEmpleados();

                if (empleados == null || empleados.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }

                Console.WriteLine("\n- Lista de Empleados -");
                for (int i = 0; i < empleados.Count; i++)
                {
                    string estadoEmpleado = empleados[i].IsActive ? "Activo" : "Inactivo";
                    Console.WriteLine($"\n{i + 1}) Id: {empleados[i].Id}; Nombre: {empleados[i].Nombre} {empleados[i].Apellido}; Puesto: {empleados[i].NombreCategoria}; Estado: {estadoEmpleado}.");
                }
                Negocio.MetodosAuxiliares.MostrarMensaje($"\n - # -");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError: {ex.Message}\n");
            }
        }

        public static void ResumenEmpleadosConsola() // Bien.
        {
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
            try
            {
                List<Empleado> empleados = empleadoNegocio.ListarEmpleados();

                if (empleados.Count > 0)
                {
                    List<Empleado> empleadosActivos = empleados.Where(emp => emp.IsActive).ToList();
                    int totalEmpleadosActivos = empleadosActivos.Count;

                    List<Empleado> empleadosDesactivados = empleados.Where(emp => !emp.IsActive).ToList();
                    int totalEmpleadosDesactivados = empleadosDesactivados.Count;

                    int totalEmpleados = empleados.Count;

                    int totalOperativos = empleados.Count(e => e.NombreCategoria == "Operativo"); 
                    int totalGerentes = empleados.Count(e => e.NombreCategoria == "Gerente");     
                    int totalDirectores = empleados.Count(e => e.NombreCategoria == "Director");

                    Console.WriteLine("\n- Resumen de Empleados -\n");
                    Console.WriteLine($"- Total de Empleados: {totalEmpleados}");
                    Console.WriteLine($"- Empleados Operativos: {totalOperativos}");
                    Console.WriteLine($"- Gerentes: {totalGerentes}");
                    Console.WriteLine($"- Directores: {totalDirectores}");
                    Console.WriteLine($"- Empleados Activos: {totalEmpleadosActivos}");
                    Console.WriteLine($"- Empleados Desactivados: {totalEmpleadosDesactivados}");
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\n - # -");
                }
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al mostrar el resumen de empleados: {ex.Message}");
            }
        }

        public static void InformacionEmpleadoConsola()//Bien. 
        {
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
            ProyectosNegocio proyectoNegocio = new ProyectosNegocio();
            try
            {
                List<Empleado> listaEmpleados = empleadoNegocio.ListarEmpleados();

                if (listaEmpleados.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }

                ListaEmpleadosConsola();

                Console.Write("\nIngrese el ID del empleado a buscar: ");
                string criterio = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(criterio) || !int.TryParse(criterio, out int idEmpleado))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nDebe ingresar un ID válido para buscar.");
                    return;
                }

                var empleadoEncontrado = listaEmpleados.SingleOrDefault(e => e.Id == idEmpleado);
                if (empleadoEncontrado != null)
                {
                    Console.WriteLine("\n- Información del empleado -\n");
                    Console.WriteLine($"Nombre: {empleadoEncontrado.Nombre} {empleadoEncontrado.Apellido}");
                    Console.WriteLine($"DNI: {empleadoEncontrado.DNI}");
                    Console.WriteLine($"Edad: {DateTime.Now.Year - empleadoEncontrado.FechaNacimiento.Year}");
                    Console.WriteLine($"Fecha de Ingreso: {empleadoEncontrado.FechaIngreso.ToShortDateString()}");
                    Console.WriteLine($"Puesto: {empleadoEncontrado.NombreCategoria}"); 
                    Console.WriteLine($"Salario Base: ${empleadoEncontrado.MontoSalario}"); 

                    List<Proyectos> proyectosAsignados = proyectoNegocio.ListarProyectosAsignadosEmpleado(idEmpleado);
                    if (proyectosAsignados.Count > 0)
                    {
                        Console.WriteLine("\nProyectos Asignados:");
                        foreach (var proyecto in proyectosAsignados)
                        {
                            Console.WriteLine($"- Id: {proyecto.Id}. Proyecto: {proyecto.Nombre}.");
                        }
                    }
                    else
                        Console.WriteLine("\nEl empleado no tiene proyectos asignados.");
                }
                else
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo se encontró un empleado con ese ID.");

                Negocio.MetodosAuxiliares.MostrarMensaje("\n - # -");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al buscar empleado: {ex.Message}\n");
            }
        }

        public static void AgregarEmpleadoConsola() // Bien.  
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\nAñadir Empleado\n");
                    Console.WriteLine("1. Añadir Empleado Operativo");
                    Console.WriteLine("2. Añadir Gerente");
                    Console.WriteLine("3. Añadir Director");
                    Console.WriteLine("\n4. Volver");
                    Console.Write("\nSelecciona una opción: ");

                    string opcion = Console.ReadLine();
                    Empleado nuevoEmpleado = new Empleado();

                    SalariosNegocio salariosNegocio = new SalariosNegocio();

                    switch (opcion)
                    {
                        case "1": // Empleado Operativo
                            nuevoEmpleado.Categoria = 1;
                            nuevoEmpleado.Salario = 1;
                            break;
                        case "2": // Gerente
                            nuevoEmpleado.Categoria = 2;
                            nuevoEmpleado.Salario = 2;
                            break;
                        case "3": // Director
                            nuevoEmpleado.Categoria = 3;
                            nuevoEmpleado.Salario = 3;
                            break;
                        case "4": 
                            return;
                        default:
                            Negocio.MetodosAuxiliares.MostrarMensaje("\nOpción no válida.");
                            continue;
                    }

                    Console.WriteLine("\n- Agregar Empleado -\n");
                    nuevoEmpleado.Nombre = Negocio.MetodosAuxiliares.LeerDato("Nombre");
                    nuevoEmpleado.Apellido = Negocio.MetodosAuxiliares.LeerDato("\nApellido");
                    nuevoEmpleado.FechaNacimiento = DateTime.Parse(Negocio.MetodosAuxiliares.LeerDato("\nFecha de Nacimiento (dd/MM/yyyy)"));
                    nuevoEmpleado.FechaIngreso = DateTime.Now;  // Fecha de ingreso se asigna automáticamente
                    nuevoEmpleado.DNI = Negocio.MetodosAuxiliares.LeerDato("\nDNI");
                    nuevoEmpleado.IsActive = true;

                    EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();

                    bool dniExistente = empleadoNegocio.ValidarDNI(nuevoEmpleado.DNI);
                    if (dniExistente)
                    {
                        Negocio.MetodosAuxiliares.MostrarMensaje("\nEl DNI ya está registrado. Por favor, intente nuevamente e ingrese otro DNI.");
                        continue;
                    }

                    empleadoNegocio.AgregarEmpleado(nuevoEmpleado);

                    string tipoEmpleado = nuevoEmpleado.Categoria == 1 ? "Empleado Operativo" : nuevoEmpleado.Categoria == 2 ? "Gerente" : "Director";

                    Console.WriteLine($"\nEmpleado agregado: {nuevoEmpleado.Nombre} {nuevoEmpleado.Apellido}; Puesto: {tipoEmpleado}.");
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nAgregado exitosamente.");

                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado en el proceso de agregar empleado: {ex.Message}\n");
                }
            }
        }

        public static void ModificarEmpleadoConsola() // Bien. 
        {
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
            try
            {
                List<Empleado> listaEmpleados = empleadoNegocio.ListarEmpleados();

                if (listaEmpleados.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }

                ListaEmpleadosConsola();

                Console.WriteLine("\n- Modificar Empleado -\n");

                int empleadoId;
                bool esNumeroValido = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("ID del Empleado", ""), out empleadoId);

                if (!esNumeroValido || !listaEmpleados.Any(e => e.Id == empleadoId))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nID de empleado no válido. Inténtalo de nuevo.");
                    return;
                }

                var empleadoSeleccionado = listaEmpleados.First(e => e.Id == empleadoId);

                string nuevoNombre = Negocio.MetodosAuxiliares.LeerDato("\nNombre", empleadoSeleccionado.Nombre);
                string nuevoApellido = Negocio.MetodosAuxiliares.LeerDato("\nApellido", empleadoSeleccionado.Apellido);

                DateTime nuevaFechaNacimiento;
                bool fechaValida = DateTime.TryParse(Negocio.MetodosAuxiliares.LeerDato("\nFecha de Nacimiento (dd/MM/yyyy)", empleadoSeleccionado.FechaNacimiento.ToString("dd/MM/yyyy")), out nuevaFechaNacimiento);
                if (!fechaValida)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nFecha de nacimiento no válida. Inténtalo de nuevo.");
                    return;
                }

                string nuevoDNI = Negocio.MetodosAuxiliares.LeerDato("\nDNI", empleadoSeleccionado.DNI);

                Console.WriteLine("\nSelecciona una opción: \n");
                Console.WriteLine("1: Operativo - Salario: $2000,00");
                Console.WriteLine("2: Gerente - Salario: $4000,00");
                Console.WriteLine("3: Director - Salario: $6000,00");
                int seleccion;
                bool seleccionValida = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("\nNueva Categoría - Salario (1-3)", ""), out seleccion);

                if (!seleccionValida || seleccion < 1 || seleccion > 3)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nSelección no válida. Inténtalo de nuevo.");
                    return;
                }

                int nuevaCategoria;
                int nuevoSalario;
                switch (seleccion)
                {
                    case 1:
                        nuevaCategoria = 1;
                        nuevoSalario = 1; 
                        break;
                    case 2:
                        nuevaCategoria = 2;
                        nuevoSalario = 2; 
                        break;
                    case 3:
                        nuevaCategoria = 3;
                        nuevoSalario = 3; 
                        break;
                    default:
                        Negocio.MetodosAuxiliares.MostrarMensaje("\nSelección no válida. Inténtalo de nuevo.");
                        return;
                }

                Empleado empleadoModificado = new Empleado
                {
                    Id = empleadoSeleccionado.Id,
                    Nombre = nuevoNombre,
                    Apellido = nuevoApellido,
                    FechaNacimiento = nuevaFechaNacimiento,
                    DNI = nuevoDNI,
                    Imagen = empleadoSeleccionado.Imagen,
                    FechaIngreso = empleadoSeleccionado.FechaIngreso,
                    Categoria = nuevaCategoria,
                    Salario = nuevoSalario, 
                    IsActive = empleadoSeleccionado.IsActive
                };

                empleadoNegocio.ModificarEmpleado(empleadoModificado);

                Negocio.MetodosAuxiliares.MostrarMensaje("\nDatos actualizados correctamente.");
            }
            catch (FormatException fe)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje("\nFormato de entrada incorrecto. Inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al modificar empleado: {ex.Message}");
            }
        }

        public static void CambiarEstadoEmpleadoConsola() //Bien.
        {
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
            try
            {
                List<Empleado> listaEmpleados = empleadoNegocio.ListarEmpleados();

                if (listaEmpleados.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }
                ListaEmpleadosConsola();
                Console.WriteLine("\n- Activar/Desactivar Empleado -\n");

                int empleadoId;
                bool esNumeroValido = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("Id del Empleado", ""), out empleadoId);

                if (!esNumeroValido || !listaEmpleados.Any(e => e.Id == empleadoId))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nId de empleado no válido. Inténtalo de nuevo.");
                    return;
                }

                string estado = Negocio.MetodosAuxiliares.LeerDato("\n¿Activar o desactivar? (a/d)", "").ToLower();
                bool activar = estado == "a";

                empleadoNegocio.ActualizarEstadoEmpleado(empleadoId, activar);
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nEmpleado {(activar ? "activado" : "desactivado")} correctamente.");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al cambiar el estado del empleado: {ex.Message}");
            }
        }

        public static void EliminarEmpleadoConsola() //Bien.
        {
            EmpleadoNegocio eliminarEmpleado = new EmpleadoNegocio();
            ProyectosNegocio desasignarEmpleado = new ProyectosNegocio(); 
            try
            {
                List<Empleado> listaEmpleados = eliminarEmpleado.ListarEmpleados();

                if (listaEmpleados == null || listaEmpleados.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }
                ListaEmpleadosConsola();
                Console.WriteLine("\n- Eliminar Empleado -\n");

                int empleadoId;
                bool esNumeroValido = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("Id del Empleado a eliminar", ""), out empleadoId);
                if (!esNumeroValido || !listaEmpleados.Any(e => e.Id == empleadoId))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nId de empleado no válido. Inténtalo de nuevo.");
                    return;
                }

                string confirmacion = Negocio.MetodosAuxiliares.LeerDato("\n¿Estás seguro de que quieres eliminar este empleado? (s/n)", "").ToLower();
                if (confirmacion != "s")
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nOperación cancelada.");
                    return;
                }

                desasignarEmpleado.DesasignarEmpleadoDeTodosLosProyectos(empleadoId);
                eliminarEmpleado.EliminarEmpleado(empleadoId);
                Negocio.MetodosAuxiliares.MostrarMensaje("\nEmpleado eliminado correctamente.");
            }
            catch (FormatException fe)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError de formato: {fe.Message}");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al eliminar el empleado: {ex.Message}");
            }
        }

    }
}
