using Dominio.Entidades;
using Dominio.Entidades.Dominio.Entidades;
using Dominio.Interfaces;
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
        public static void ListaEmpleadosConsola() // Funciona joya
        // creo que no hace falta pasar parametros... ya esta todo guardado en la lista.
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

                Console.WriteLine("\n- Lista de Empleados -\n");
                for (int i = 0; i < empleados.Count; i++)
                {
                    string tipoEmpleado = empleados[i].Categoria == 1 ? "Empleado Operativo" : empleados[i].Categoria == 2 ? "Gerente" : "Director";
                    string estadoEmpleado = empleados[i].IsActive ? "Activo" : "Inactivo";

                    Console.WriteLine($"{i + 1}) Nro. Id: {empleados[i].Id}; Nombre: {empleados[i].Nombre} {empleados[i].Apellido}; Puesto: {tipoEmpleado}; Estado: {estadoEmpleado}.");
                }
                Negocio.MetodosAuxiliares.MostrarMensaje($"\n - # -");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError: {ex.Message}\n");
            }
        }

        public static void ResumenEmpleadosConsola() // Funciona joya
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
                    int totalOperativos = empleados.Count(e => e.Categoria == 1);
                    int totalGerentes = empleados.Count(e => e.Categoria == 2);
                    int totalDirectores = empleados.Count(e => e.Categoria == 3);

                    Console.WriteLine("\n- Resumen de Empleados -\n");
                    Console.WriteLine($"- Total de Empleados: {totalEmpleados}");
                    Console.WriteLine($"- Empleados Operativos: {totalOperativos}");
                    Console.WriteLine($"- Gerentes: {totalGerentes}");
                    Console.WriteLine($"- Directores: {totalDirectores}");
                    Console.WriteLine($"- Empleados Activos: {totalEmpleadosActivos}");
                    Negocio.MetodosAuxiliares.MostrarMensaje($"- Empleados Desactivados: {totalEmpleadosDesactivados}");

                }
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al mostrar el resumen de empleados: {ex.Message}");
            }
        }

        public static string ObtenerNombreCategoria(int categoria) // Funciona joya 
        {
            switch (categoria)
            {
                case 1:
                    return "Empleado Operativo";
                case 2:
                    return "Gerente";
                case 3:
                    return "Director";
                default:
                    return "Categoría Desconocida";
            }
        }
    
        public static void InformacionEmpleadoConsola() // Funcion bien 
        // falta mejorar la informacion que se muestra del empleado ..
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
                    string tipoEmpleado = ObtenerNombreCategoria(empleadoEncontrado.Categoria);

                    Console.WriteLine("\n- Información del empleado -\n");
                    Console.WriteLine($"Nombre: {empleadoEncontrado.Nombre} {empleadoEncontrado.Apellido}");
                    Console.WriteLine($"Edad: {DateTime.Now.Year - empleadoEncontrado.FechaNacimiento.Year}");
                    Console.WriteLine($"Puesto: {tipoEmpleado}");
                    Console.WriteLine($"Fecha de Ingreso: {empleadoEncontrado.FechaIngreso.ToShortDateString()}");
                    Console.WriteLine($"Salario Base: ${empleadoEncontrado.SalarioBase}");

                    // Recuperar y mostrar los proyectos asignados
                    List<Proyectos> proyectosAsignados = proyectoNegocio.ListarProyectosAsignadosEmpleado(idEmpleado);
                    if (proyectosAsignados.Count > 0)
                    {
                        Console.WriteLine("\nProyectos Asignados:");
                        foreach (var proyecto in proyectosAsignados)
                        {
                            Console.WriteLine($"- Proyecto: {proyecto.Nombre}. Descripción: {proyecto.Descripcion}. Id proyecto: {proyecto.Id}.");
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
      
        public static void AgregarEmpleadoConsola() // Funciona joya 
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

                    Empleado nuevoEmpleado = null;

                    switch (opcion)
                    {
                        case "1":
                            nuevoEmpleado = new Empleado();
                            nuevoEmpleado.Categoria = 1; // Operativo
                            break;
                        case "2":
                            nuevoEmpleado = new Empleado();
                            nuevoEmpleado.Categoria = 2; // Gerente
                            break;
                        case "3":
                            nuevoEmpleado = new Empleado();
                            nuevoEmpleado.Categoria = 3; // Director
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
                    nuevoEmpleado.FechaNacimiento = DateTime.Parse(Negocio.MetodosAuxiliares.LeerDato("\nFecha de Nacimiento (dd/MM/yyyy)")); // tendria que calcularse el numero de años...       
                    nuevoEmpleado.FechaIngreso = DateTime.Now;  // Fecha de ingreso se asigna automáticamente
                    nuevoEmpleado.IsActive = true;

                    nuevoEmpleado.DNI = Negocio.MetodosAuxiliares.LeerDato("\nDNI");

                    //// Validar si el DNI ya existe
                    //EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
                    //bool dniExistente = empleadoNegocio.ValidarDNI(nuevoEmpleado.DNI);
                    //if (dniExistente)
                    //{
                    //    Negocio.MetodosAuxiliares.MostrarMensaje("\nEl DNI ya está registrado. Por favor, ingrese otro DNI.");
                    //    continue;
                    //}

                    // Asignar el salario según la categoría seleccionada
                    EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
                    SalariosNegocio.AsignarSalarioPorCategoria(nuevoEmpleado); // tengo que mejorar esta logica ...

                    // Agregar el nuevo empleado a la base de datos a través de la capa de negocio
                    empleadoNegocio.AgregarEmpleado(nuevoEmpleado);

                    // Mostrar la información del empleado agregado
                    string tipoEmpleado = nuevoEmpleado.Categoria == 1 ? "Empleado Operativo" : nuevoEmpleado.Categoria == 2 ? "Gerente" : "Director";
                    Console.WriteLine($"\nEmpleado agregado: {nuevoEmpleado.Nombre} {nuevoEmpleado.Apellido}; Puesto: {tipoEmpleado}; Salario Base: {nuevoEmpleado.SalarioBase} pesos.");
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nAgregado exitosamente.");
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado en el proceso de agregar empleado: {ex.Message}\n");
                }
            }
        }

        public static void ModificarEmpleadoConsola() // Falta mejorar 
         // agregar campos para modificar:
         // - fecha de nacimiento
         // - dni
         // - si esta activo o no
         // - la asignacion  de salario a un nuevo valor en base al cambio de puesto.
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
                int nuevaCategoria;
                bool categoriaValida = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("\nCategoría", empleadoSeleccionado.Categoria.ToString()), out nuevaCategoria);

                if (!categoriaValida)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nCategoría no válida. Inténtalo de nuevo.");
                    return;
                }

                // Crear un nuevo objeto Empleado con los datos modificados
                Empleado empleadoModificado = new Empleado
                {
                    Id = empleadoSeleccionado.Id,
                    Nombre = nuevoNombre,
                    Apellido = nuevoApellido,
                    FechaNacimiento = empleadoSeleccionado.FechaNacimiento,
                    DNI = empleadoSeleccionado.DNI,
                    Imagen = empleadoSeleccionado.Imagen,
                    FechaIngreso = empleadoSeleccionado.FechaIngreso,
                    Categoria = nuevaCategoria,
                    SalarioBase = empleadoSeleccionado.SalarioBase,
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

        public static void CambiarEstadoEmpleadoConsola() // Funciona joya 
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

        public static void EliminarEmpleadoConsola() // Funciona joya 
        {
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
            try
            {
                List<Empleado> listaEmpleados = empleadoNegocio.ListarEmpleados();

                if (listaEmpleados == null || listaEmpleados.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }
                ListaEmpleadosConsola();
                Console.WriteLine("\n- Eliminar Empleado -\n");

                // Pedir al usuario que ingrese el ID del empleado a eliminar
                int empleadoId;
                bool esNumeroValido = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("Id del Empleado a eliminar", ""), out empleadoId);

                // Verificar si el ID ingresado existe en la lista obtenida
                if (!esNumeroValido || !listaEmpleados.Any(e => e.Id == empleadoId))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nId de empleado no válido. Inténtalo de nuevo.");
                    return;
                }

                // Confirmación antes de eliminar
                string confirmacion = Negocio.MetodosAuxiliares.LeerDato("\n¿Estás seguro de que quieres eliminar este empleado? (s/n)", "").ToLower();
                if (confirmacion != "s")
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nOperación cancelada.");
                    return;
                }

                empleadoNegocio.EliminarEmpleado(empleadoId);
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
