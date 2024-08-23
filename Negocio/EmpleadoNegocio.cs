using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Dominio.ReglasDelNegocio;

namespace Negocio
{
    public class EmpleadoNegocio
    {
        static List<Empleado> empleados = new List<Empleado>();

        MetodosAuxiliares metodosAuxiliares = new MetodosAuxiliares();
        Bonos bonos = new Bonos();
        Salarios salarios = new Salarios();
        Reportes reportes = new Reportes();


        public static void ListaEmpleados()
        {
            try
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine();
                    MetodosAuxiliares.MostrarMensaje("No hay empleados registrados.");
                    return;
                }

                Console.WriteLine("\nLista de Empleados:");
                
                // opcion 1
                //for (int i = 0; i < empleados.Count; i++)
                //{
                //    Console.WriteLine($"{i + 1}. {empleados[i].Nombre} {empleados[i].Apellido}.");
                //}

                // opcion 2
                for (int i = 0; i < empleados.Count; i++)
                {
                    string tipoEmpleado = empleados[i] is Gerente ? "Gerente" : empleados[i] is Director ? "Director" : "Operativo";
                    Console.WriteLine($"{i + 1}. {empleados[i].Nombre} {empleados[i].Apellido}, puesto: {tipoEmpleado}, Salario: {empleados[i].CalcularSalario():C}");
                }

                Console.WriteLine();
                ContadorEmpleados();

            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"Error: {ex.Message}");
            }
        }

        public static void BuscarEmpleado()
        {
            try
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine();
                    MetodosAuxiliares.MostrarMensaje("No hay empleados registrados.");
                    return;
                }

                Console.Write("\nIngrese el nombre o apellido del empleado a buscar: ");
                string criterio = Console.ReadLine().ToLower();
                var resultados = empleados.Where(e => e.Nombre.ToLower().Contains(criterio) || e.Apellido.ToLower().Contains(criterio)).ToList();

                if (resultados.Count > 0)
                {
                    foreach (var empleado in resultados)
                    {
                        Console.WriteLine($"\nEmpleado encontrado: {empleado.Nombre} {empleado.Apellido}, Salario Final: {empleado.CalcularSalario()}");
                        // agregar el tipo de empleado
                    }
                }
                else
                {
                    MetodosAuxiliares.MostrarMensaje("No se encontraron empleados con ese criterio.");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"Error al buscar empleado: {ex.Message}");
            }
        }

        public static void AgregarEmpleado(Empleado empleado)
        {
            Salarios salarios = new Salarios();
            try
            {
                Console.WriteLine();
                Console.WriteLine($"Ingrese los datos del {empleado.GetType().Name.ToLower()}:");
                empleado.Nombre = MetodosAuxiliares.LeerDato("Nombre");
                empleado.Apellido = MetodosAuxiliares.LeerDato("Apellido");
                empleado.Edad = Convert.ToInt32(MetodosAuxiliares.LeerDato("Edad"));

                // Asignación automática del salario base por categoría
                Salarios.AsignarSalarioPorCategoria(empleado);

                empleados.Add(empleado);

                Console.WriteLine();
                Console.WriteLine($"{empleado.GetType().Name}, {empleado.Nombre} {empleado.Apellido}, {empleado.Edad} años, Salario Base: {empleado.SalarioBase:C}");
                MetodosAuxiliares.MostrarMensaje("Empleado agregado exitosamente.");
                Console.WriteLine();

                // Preguntar si se desean asignar bonos
                Console.WriteLine("¿Desea asignar bonos al empleado? (S/N): ");
                string opcionBonos = Console.ReadLine();
                if (opcionBonos.ToUpper() == "S")
                {
                    Bonos.AsignarBonos(empleado);  // Método para asignar bonos
                }
            }
            catch (FormatException)
            {
                MetodosAuxiliares.MostrarMensaje("Formato de entrada incorrecto. Inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"Error inesperado: {ex.Message}");
            }
        }

        public static void ModificarEmpleado()
        {
            try
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine();
                    MetodosAuxiliares.MostrarMensaje("No hay empleados registrados.");
                    return;
                }

                ListaEmpleados();
                Console.WriteLine("Enter para continuar\n");

                int indice = MetodosAuxiliares.ObtenerIndiceEmpleado();
                if (indice != -1)
                {
                    var empleado = empleados[indice];
                    empleado.Nombre = MetodosAuxiliares.LeerDato("Nombre", empleado.Nombre);
                    empleado.Apellido = MetodosAuxiliares.LeerDato("Apellido", empleado.Apellido);
                    empleado.Edad = Convert.ToInt32(MetodosAuxiliares.LeerDato("Edad", empleado.Edad.ToString()));
                    empleado.SalarioBase = Convert.ToDecimal(MetodosAuxiliares.LeerDato("Salario Base", empleado.SalarioBase.ToString()));
                    MetodosAuxiliares.MostrarMensaje("Datos actualizados correctamente.");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                MetodosAuxiliares.MostrarMensaje("Formato de entrada incorrecto. Inténtalo de nuevo.");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                MetodosAuxiliares.MostrarMensaje($"Error al modificar empleado: {ex.Message}");
                Console.WriteLine();

            }
        }


        // Opcion 1
        //public static void EliminarEmpleado()
        //{
        //    // me gustaria tener un alerta al eliminar.. que no se elimine sin confirmar la eliminacion
        //    try
        //    {
        //        if (empleados.Count == 0)
        //        {
        //            Console.WriteLine();
        //            MetodosAuxiliares.MostrarMensaje("No hay empleados registrados.");
        //            return;
        //        }

        //        ListaEmpleados();
        //        int indice = MetodosAuxiliares.ObtenerIndiceEmpleado();
        //        if (indice != -1)
        //        {
        //            empleados.RemoveAt(indice);
        //            Console.WriteLine();
        //            MetodosAuxiliares.MostrarMensaje("Eliminado correctamente.");
        //            Console.WriteLine();
        //        }
        //    }
        //    catch (ArgumentOutOfRangeException)
        //    {

        //        MetodosAuxiliares.MostrarMensaje("Índice fuera de rango. Inténtalo de nuevo.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MetodosAuxiliares.MostrarMensaje($"Error al eliminar empleado: {ex.Message}");
        //    }
        //}


        // Opcion 2
        public static void EliminarEmpleado()
        {
            try
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine();
                    MetodosAuxiliares.MostrarMensaje("No hay empleados registrados.");
                    return;
                }

                ListaEmpleados();
                int indice = MetodosAuxiliares.ObtenerIndiceEmpleado();
                if (indice != -1)
                {
                    Console.WriteLine($"¿Estás seguro que deseas eliminar a {empleados[indice].Nombre} {empleados[indice].Apellido}? (S/N): ");
                    string confirmacion = Console.ReadLine();
                    if (confirmacion.ToUpper() == "S")
                    {
                        empleados.RemoveAt(indice);
                        Console.WriteLine();
                        MetodosAuxiliares.MostrarMensaje("Eliminado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Eliminación cancelada.");
                    }
                    Console.WriteLine();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MetodosAuxiliares.MostrarMensaje("Índice fuera de rango. Inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"Error al eliminar empleado: {ex.Message}");
            }
        }

        public static void ContadorEmpleados()
        {
            try
            {
                // Contar empleados por categoría
                int totalEmpleados = empleados.Count;
                int totalGerentes = empleados.OfType<Gerente>().Count();
                int totalDirectores = empleados.OfType<Director>().Count();
                int totalEmpleadosOperativos = totalEmpleados - totalGerentes - totalDirectores;

                // Mostrar conteo de empleados por categoría
                Console.WriteLine("\nResumen de Empleados:");
                Console.WriteLine($"Total de Empleados Operativos: {totalEmpleadosOperativos}");
                Console.WriteLine($"Total de Gerentes: {totalGerentes}");
                Console.WriteLine($"Total de Directores: {totalDirectores}");
                Console.WriteLine();
                Console.WriteLine($"Total de Empleados: {totalEmpleados}");

                // Esperar a que el usuario presione una tecla antes de continuar
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"Error al contar empleados: {ex.Message}");
            }
        }


    }
}