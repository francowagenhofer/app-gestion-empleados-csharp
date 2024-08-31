using Dominio.Entidades.Dominio.Entidades;
using Dominio.Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola
{
    public class LogicaProyectos
    {
        //-------------------------------------------------------------------------------------------------------------------------------//
        //                  Adaptcion de los metodos de ProyectosNegocio a la App de Consola                                             //
        //-------------------------------------------------------------------------------------------------------------------------------//

        public static void ListaProyectosConsola(List<Proyectos> proyectos)
        {
            try
            {
                if (proyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }

                Console.WriteLine("\nLista de Proyectos "); // Mostrar lista de proyectos con un número de referencia
                for (int i = 0; i < proyectos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {proyectos[i].Nombre}");
                }
            }
            catch (FormatException ex)
            {
                MetodosAuxiliares.MostrarMensaje("Error de formato: Ingrese un número válido.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"Ocurrió un error inesperado: {ex.Message}");
            }
        }

        public static void ContadorProyectosConsola(List<Proyectos> proyectos)
        {
            try
            {
                int totalProyectos = proyectos.Count;
                MetodosAuxiliares.MostrarMensaje($"\nTotal de Proyectos: {totalProyectos}");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al contar empleados: {ex.Message}");
            }
        }

        public static void InformacionProyectoConsola(List<Proyectos> proyectos)
        {
            try
            {
                if (proyectos == null || proyectos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                    return;
                }

                Console.WriteLine("\nInformación de Proyecto");

                ListaProyectosConsola(proyectos);

                Console.Write("\nIngrese el número del proyecto que desea ver: ");
                if (int.TryParse(Console.ReadLine(), out int indiceProyecto) && indiceProyecto > 0 && indiceProyecto <= proyectos.Count)
                {
                    var proyectoSeleccionado = proyectos[indiceProyecto - 1];

                    // Mostrar información detallada del proyecto seleccionado
                    Console.WriteLine($"\nProyecto: {proyectoSeleccionado.Nombre}");
                    Console.WriteLine($"Descripción: {proyectoSeleccionado.Descripcion}");
                    Console.WriteLine($"Fecha de Inicio: {proyectoSeleccionado.FechaInicio.ToShortDateString()}");
                    Console.WriteLine($"Fecha de Fin: {proyectoSeleccionado.FechaFin.ToShortDateString()}");
                    Console.WriteLine($"Presupuesto: {proyectoSeleccionado.Presupuesto}");

                    if (proyectoSeleccionado.EmpleadosAsignados != null && proyectoSeleccionado.EmpleadosAsignados.Count > 0) // Mostrar empleados asignados al proyecto
                    {
                        Console.WriteLine("\nEmpleados Asignados:");
                        foreach (var empleado in proyectoSeleccionado.EmpleadosAsignados)
                        {
                            string tipoEmpleado = empleado is Gerente ? "Gerente" : empleado is Director ? "Director" : "Empleado Operativo";
                            Console.WriteLine($"- {empleado.Nombre} {empleado.Apellido}; Posición: {tipoEmpleado}.");
                        }
                    }
                    else
                        Console.WriteLine("\nNo hay empleados asignados a este proyecto.");
                }
                else
                    MetodosAuxiliares.MostrarMensaje("\nSelección inválida.");

                MetodosAuxiliares.MostrarMensaje("");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nOcurrió un error al mostrar la información del proyecto: {ex.Message}");
            }
        }


        // metodo que muestra la informacion de un proyecto seleccionado ... Aunque tambien estan los reportes para eso ...
        //public static void InformacionPoryectoConsola(List<Proyectos> proyectos, List<Empleado> empleados)
        //{
        //    try
        //    {
        //        //// Preguntar si se quiere ver más información de un proyecto
        //        //Console.Write("\nIngrese el número del proyecto para ver más detalles (o '0' para volver): ");
        //        //if (int.TryParse(Console.ReadLine(), out int numeroProyecto) && numeroProyecto > 0 && numeroProyecto <= proyectos.Count)
        //        //{
        //        //    var proyectoSeleccionado = proyectos[numeroProyecto - 1];

        //        //    // Mostrar la información del proyecto seleccionado
        //        //    Console.Clear();
        //        //    Console.WriteLine("\n--- Información del Proyecto ---");
        //        //    proyectoSeleccionado.MostrarInformacion();
        //        //    proyectoSeleccionado.MostrarEmpleadosAsignados();
        //        //}
        //        //else
        //        //{
        //        //    Console.WriteLine("\nNúmero de proyecto no válido o cancelado.");
        //        //}

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}


        //public static void MostrarProyectosActivosConsola(List<Proyectos> proyectos)
        //{
        //    if (proyectos.Count == 0)
        //    {
        //        MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
        //        return;
        //    }



        //    Console.WriteLine("\n--- Proyectos Activos ---");
        //    foreach (var proyecto in proyectos)
        //    {
        //        if (DateTime.Now >= proyecto.FechaInicio && DateTime.Now <= proyecto.FechaFin)
        //        {
        //            proyecto.MostrarInformacion();
        //            proyecto.MostrarEmpleadosAsignados();
        //        }
        //    }
        //}
        //public static void MostrarProyectosNoActivosConsola(List<Proyectos> proyectos)
        //{
        //    if (proyectos.Count == 0)
        //    {
        //        MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
        //        return;
        //    }

        //    Console.WriteLine("\n--- Proyectos No Activos ---");
        //    foreach (var proyecto in proyectos)
        //    {
        //        if (DateTime.Now > proyecto.FechaFin)
        //        {
        //            proyecto.MostrarInformacion();
        //            proyecto.MostrarEmpleadosAsignados();
        //        }
        //    }
        //}


        public static void AgregarProyectoConsola(List<Proyectos> proyectos)
        {
            Console.WriteLine("\nAgregar Nuevo Proyecto\n");

            Console.Write("Ingrese el nombre del proyecto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la fecha de inicio (dd/MM/yyyy): ");
            DateTime fechaInicio = DateTime.Parse(Console.ReadLine());

            Console.Write("Ingrese la fecha de fin (dd/MM/yyyy): ");
            DateTime fechaFin = DateTime.Parse(Console.ReadLine());

            Console.Write("Ingrese la descripción del proyecto: ");
            string descripcion = Console.ReadLine();

            Console.Write("Ingrese el presupuesto del proyecto: ");
            decimal presupuesto = Convert.ToDecimal(Console.ReadLine());

            Proyectos nuevoProyecto = new Proyectos(nombre, fechaInicio, fechaFin, descripcion, presupuesto);

            proyectos.Add(nuevoProyecto); // -> aca va el metodo ProyectosNegocio que esta conectado a la base de datos...

            MetodosAuxiliares.MostrarMensaje($"\nEl proyecto '{nombre}' ha sido agregado exitosamente.");

        }

        public static void ModificarDatosDelProyectoConsola(List<Proyectos> proyectos)// Corregir
        {
            if (proyectos.Count == 0)
            {
                MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                return;
            }

            Console.WriteLine("\nModificar Proyecto");


            ListaProyectosConsola(proyectos);
            Console.Write("\nSeleccione un proyecto para modificar: ");
            int seleccionProyecto = Convert.ToInt32(Console.ReadLine()) - 1;

            var proyecto = proyectos[seleccionProyecto];

            Console.Write("\nSeleccione el campo a modificar: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Fecha de Inicio");
            Console.WriteLine("3. Fecha de Fin");
            Console.WriteLine("4. Descripción");
            Console.WriteLine("5. Presupuesto\n");

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el nuevo nombre: ");
                    proyecto.Nombre = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Ingrese la nueva fecha de inicio (dd/MM/yyyy): ");
                    proyecto.FechaInicio = DateTime.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Ingrese la nueva fecha de fin (dd/MM/yyyy): ");
                    proyecto.FechaFin = DateTime.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("Ingrese la nueva descripción: ");
                    proyecto.Descripcion = Console.ReadLine();
                    break;
                case 5:
                    Console.Write("Ingrese el nuevo presupuesto: ");
                    proyecto.Presupuesto = Convert.ToDecimal(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            MetodosAuxiliares.MostrarMensaje("\nLos datos del proyecto han sido actualizados exitosamente.");
        }

        public static void EliminarProyectoConsola(List<Proyectos> proyectos)
        {
            if (proyectos.Count == 0)
            {
                MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                return;
            }

            Console.WriteLine("\nEliminar Proyecto");

            ListaProyectosConsola(proyectos);
            Console.Write("\nSeleccione un proyecto para eliminar:");
            int seleccionProyecto = Convert.ToInt32(Console.ReadLine()) - 1;

            proyectos.RemoveAt(seleccionProyecto);

            MetodosAuxiliares.MostrarMensaje("\nProyecto eliminado exitosamente.");
        }
        
        public static void MarcarProyectoComoCompletadoConsola(List<Proyectos> proyectos) // este metodo no se que onda ...
        {
            if (proyectos.Count == 0)
            {
                MetodosAuxiliares.MostrarMensaje("\nNo hay proyectos registrados.");
                return;
            }

            Console.WriteLine("\nSeleccione un proyecto para marcar como completado:");
            for (int i = 0; i < proyectos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {proyectos[i].Nombre}");
            }

            int seleccionProyecto = Convert.ToInt32(Console.ReadLine()) - 1;

            proyectos[seleccionProyecto].FechaFin = DateTime.Now;

            Console.WriteLine($"El proyecto '{proyectos[seleccionProyecto].Nombre}' ha sido marcado como completado.");
        }

        public static void AsignarEmpleadoAProyectoConsola(List<Proyectos> proyectos, List<Empleado> empleados)
        {
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

            Console.WriteLine("\nAsignar Empleado");

            ListaProyectosConsola(proyectos);
            Console.Write("\nSeleccione un proyecto al cual asignar un empleado: ");
            int seleccionProyecto = Convert.ToInt32(Console.ReadLine()) - 1;

            LogicaAppConsola.LogicaEmpleados.ListaEmpleadosConsola(empleados);
            Console.Write("\nSeleccione un empleado para asignar al proyecto: ");
            int seleccionEmpleado = Convert.ToInt32(Console.ReadLine()) - 1;

            proyectos[seleccionProyecto].AsignarEmpleado(empleados[seleccionEmpleado]);

            MetodosAuxiliares.MostrarMensaje("\nAsignado correctamente.");

        }

        public static void DesasignarEmpleadoDeProyectoConsola(List<Proyectos> proyectos, List<Empleado> empleados)
        {
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

            Console.WriteLine("\nDesasignar Empleado");

            ListaProyectosConsola(proyectos);
            Console.Write("\nSeleccione un proyecto del cual desasignar un empleado:");
            int seleccionProyecto = Convert.ToInt32(Console.ReadLine()) - 1;
            var empleadosAsignados = proyectos[seleccionProyecto].EmpleadosAsignados;
            if (empleadosAsignados.Count == 0)
            {
                Console.WriteLine("No hay empleados asignados a este proyecto.");
                return;
            }

            LogicaAppConsola.LogicaEmpleados.ListaEmpleadosConsola(empleados); // tendria que ser una lista de empleados asignados
            Console.Write("\nSeleccione un empleado para desasignar:");
            int seleccionEmpleado = Convert.ToInt32(Console.ReadLine()) - 1;



            //if (proyectoSeleccionado.EmpleadosAsignados != null && proyectoSeleccionado.EmpleadosAsignados.Count > 0) // Mostrar empleados asignados al proyecto
            //{
            //    Console.WriteLine("\nEmpleados Asignados:");
            //    foreach (var empleado in proyectoSeleccionado.EmpleadosAsignados)
            //    {
            //        string tipoEmpleado = empleado is Gerente ? "Gerente" : empleado is Director ? "Director" : "Empleado Operativo";
            //        Console.WriteLine($"- {empleado.Nombre} {empleado.Apellido}; Posición: {tipoEmpleado}.");
            //    }
            //}
            //else
            //    Console.WriteLine("\nNo hay empleados asignados a este proyecto.");


            proyectos[seleccionProyecto].DesasignarEmpleado(empleadosAsignados[seleccionEmpleado]);

            MetodosAuxiliares.MostrarMensaje("\nDesasignado correctamente.");
        }

    }
}
