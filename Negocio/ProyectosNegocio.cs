using Dominio.Entidades;
using Dominio.Entidades.Dominio.Entidades;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProyectosNegocio
    {


        public static void MostrarProyectosActivos(List<Proyecto> proyectos)
        {
            Console.WriteLine("\n--- Proyectos Activos ---");
            foreach (var proyecto in proyectos)
            {
                if (DateTime.Now >= proyecto.FechaInicio && DateTime.Now <= proyecto.FechaFin)
                {
                    proyecto.MostrarInformacion();
                    proyecto.MostrarEmpleadosAsignados();
                }
            }
        }

        public static void MostrarProyectosNoActivos(List<Proyecto> proyectos)
        {
            Console.WriteLine("\n--- Proyectos No Activos ---");
            foreach (var proyecto in proyectos)
            {
                if (DateTime.Now > proyecto.FechaFin)
                {
                    proyecto.MostrarInformacion();
                    proyecto.MostrarEmpleadosAsignados();
                }
            }
        }

        public static void AgregarProyecto(List<Proyecto> proyectos)
        {
            Console.WriteLine("\n--- Agregar Nuevo Proyecto ---");

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

            Proyecto nuevoProyecto = new Proyecto(nombre, fechaInicio, fechaFin, descripcion, presupuesto);

            proyectos.Add(nuevoProyecto);

            Console.WriteLine($"El proyecto '{nombre}' ha sido agregado exitosamente.");
        }


        public static void ModificarDatosDelProyecto(List<Proyecto> proyectos)
        {
            Console.WriteLine("\nSeleccione un proyecto para modificar:");
            for (int i = 0; i < proyectos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {proyectos[i].Nombre}");
            }

            int seleccionProyecto = Convert.ToInt32(Console.ReadLine()) - 1;
            var proyecto = proyectos[seleccionProyecto];

            Console.WriteLine("\nSeleccione el campo a modificar:");
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Fecha de Inicio");
            Console.WriteLine("3. Fecha de Fin");
            Console.WriteLine("4. Descripción");
            Console.WriteLine("5. Presupuesto");
            int opcion = Convert.ToInt32(Console.ReadLine());

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

            Console.WriteLine("Los datos del proyecto han sido actualizados exitosamente.");
        }

        public static void EliminarProyecto(List<Proyecto> proyectos)
        {
            Console.WriteLine("\nSeleccione un proyecto para eliminar:");
            for (int i = 0; i < proyectos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {proyectos[i].Nombre}");
            }

            int seleccionProyecto = Convert.ToInt32(Console.ReadLine()) - 1;

            proyectos.RemoveAt(seleccionProyecto);
            Console.WriteLine("Proyecto eliminado exitosamente.");
        }

        // Métodos de asignación y desasignación de empleados
        public static void AsignarEmpleadoAProyecto(List<Proyecto> proyectos, List<Empleado> empleados)
        {
            Console.WriteLine("\nSeleccione un proyecto al cual asignar un empleado:");
            for (int i = 0; i < proyectos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {proyectos[i].Nombre}");
            }

            int seleccionProyecto = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("\nSeleccione un empleado para asignar al proyecto:");
            for (int i = 0; i < empleados.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {empleados[i].Nombre} {empleados[i].Apellido}");
            }

            int seleccionEmpleado = Convert.ToInt32(Console.ReadLine()) - 1;

            proyectos[seleccionProyecto].AsignarEmpleado(empleados[seleccionEmpleado]);
        }

        public static void DesasignarEmpleadoDeProyecto(List<Proyecto> proyectos, List<Empleado> empleados)
        {
            Console.WriteLine("\nSeleccione un proyecto del cual desasignar un empleado:");
            for (int i = 0; i < proyectos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {proyectos[i].Nombre}");
            }

            int seleccionProyecto = Convert.ToInt32(Console.ReadLine()) - 1;

            var empleadosAsignados = proyectos[seleccionProyecto].EmpleadosAsignados;
            if (empleadosAsignados.Count == 0)
            {
                Console.WriteLine("No hay empleados asignados a este proyecto.");
                return;
            }

            Console.WriteLine("\nSeleccione un empleado para desasignar:");
            for (int i = 0; i < empleadosAsignados.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {empleadosAsignados[i].Nombre} {empleadosAsignados[i].Apellido}");
            }

            int seleccionEmpleado = Convert.ToInt32(Console.ReadLine()) - 1;

            proyectos[seleccionProyecto].DesasignarEmpleado(empleadosAsignados[seleccionEmpleado]);
        }

        public static void MarcarProyectoComoCompletado(List<Proyecto> proyectos)
        {
            Console.WriteLine("\nSeleccione un proyecto para marcar como completado:");
            for (int i = 0; i < proyectos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {proyectos[i].Nombre}");
            }

            int seleccionProyecto = Convert.ToInt32(Console.ReadLine()) - 1;

            proyectos[seleccionProyecto].FechaFin = DateTime.Now;

            Console.WriteLine($"El proyecto '{proyectos[seleccionProyecto].Nombre}' ha sido marcado como completado.");
        }
    }
}
