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
        public static void ListaEmpleados(List<Empleado> empleados)
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
                
                for (int i = 0; i < empleados.Count; i++)
                {
                    string tipoEmpleado = empleados[i] is Gerente ? "Gerente" : empleados[i] is Director ? "Director" : "Operativo";
                    Console.WriteLine($"{i + 1}. {empleados[i].Nombre} {empleados[i].Apellido}; Puesto: {tipoEmpleado}; Salario: {empleados[i].CalcularSalario()} pesos");
                }

                Console.WriteLine();
                ContadorEmpleados(empleados);

            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"Error: {ex.Message}");
            }
        }


        public static void BuscarEmpleado(List<Empleado> empleados)
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
                string criterio = Console.ReadLine()?.Trim().ToLower();

                // Validar que el criterio no sea vacío
                if (string.IsNullOrWhiteSpace(criterio))
                {
                    MetodosAuxiliares.MostrarMensaje("\nDebe ingresar un nombre o apellido valido para buscar.");
                    return;
                }

                var resultados = empleados
                    .Where(e => e.Nombre.ToLower().Contains(criterio) || e.Apellido.ToLower().Contains(criterio))
                    .ToList();

                if (resultados.Count > 0)
                {
                    foreach (var empleado in resultados)
                    {
                        Console.WriteLine($"\nEmpleado encontrado: {empleado.Nombre} {empleado.Apellido}; Salario Final: {empleado.CalcularSalario()} pesos.\n");
                        // Agregar el tipo de empleado si es necesario
                    }
                }
                else
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo se encontraron empleados con ese criterio.\n");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"Error al buscar empleado: {ex.Message}");
            }
        }



        public static void AgregarEmpleado(List<Empleado> empleados, Empleado empleado)
        {

            
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

                Console.WriteLine($"\n{empleado.Nombre} {empleado.Apellido}, {empleado.Edad} años; {empleado.GetType().Name}; Salario Base: {empleado.SalarioBase} pesos.\n");

                MetodosAuxiliares.MostrarMensaje("Agregado exitosamente.");
                Console.WriteLine();

                // Preguntar si se desean asignar bonos
                Console.WriteLine("¿Desea asignar bonos al empleado? (Si/No): ");
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

        public static void ModificarEmpleado(List<Empleado> empleados)
        {
            // en vez de modificar el sueldo dar la opcin de cambiar de puesto de empleado.

            try
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine();
                    MetodosAuxiliares.MostrarMensaje("No hay empleados registrados.");
                    return;
                }

                ListaEmpleados(empleados);

                int indice = MetodosAuxiliares.ObtenerIndiceEmpleado(empleados);
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

        public static void EliminarEmpleado(List<Empleado> empleados)
        {
            try
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine();
                    MetodosAuxiliares.MostrarMensaje("No hay empleados registrados.");
                    return;
                }

                ListaEmpleados(empleados);
                int indice = MetodosAuxiliares.ObtenerIndiceEmpleado(empleados);
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

        public static void ContadorEmpleados(List<Empleado> empleados)
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