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
                    MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }

                Console.WriteLine("\n# Lista de Empleados:");
                for (int i = 0; i < empleados.Count; i++)
                {
                    string tipoEmpleado = empleados[i] is Gerente ? "Gerente" : empleados[i] is Director ? "Director" : "Empleado Operativo";
                    Console.WriteLine($"{i + 1}. {empleados[i].Nombre} {empleados[i].Apellido}; {tipoEmpleado}; Salario: {empleados[i].CalcularSalario()} pesos");
                }
                Console.WriteLine();

                ContadorEmpleados(empleados);
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError: {ex.Message}\n");
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
                Console.WriteLine("# Resumen de Empleados:");
                Console.WriteLine($"Empleados Operativos: {totalEmpleadosOperativos}");
                Console.WriteLine($"Gerentes: {totalGerentes}");
                Console.WriteLine($"Directores: {totalDirectores}");
                MetodosAuxiliares.MostrarMensaje($"Total de Empleados: {totalEmpleados}");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al contar empleados: {ex.Message}");
            }
        }


        public static void BuscarEmpleado(List<Empleado> empleados)
        {
            try
            {
                if (empleados.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
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
                        Console.WriteLine($"\nEmpleado encontrado: {empleado.Nombre} {empleado.Apellido}; {empleado.GetType().Name}; Salario: {empleado.SalarioBase} pesos.\n");
                    }
                }
                else
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo se encontraron empleados con ese criterio.");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al buscar empleado: {ex.Message}\n");
            }
        }


        public static void AgregarEmpleado(List<Empleado> empleados, Empleado empleado)
        {      
            try
            {
                //Console.WriteLine($"\nIngrese los datos del {empleado.GetType().Name.ToLower()}:");
                string tipoEmpleado = empleado.EsOperativo ? "Empleado Operativo" : empleado.GetType().Name;

                Console.WriteLine($"\nIngrese los datos del {tipoEmpleado}:");
                empleado.Nombre = MetodosAuxiliares.LeerDato("Nombre");
                empleado.Apellido = MetodosAuxiliares.LeerDato("Apellido");
                empleado.Edad = Convert.ToInt32(MetodosAuxiliares.LeerDato("Edad"));
      
                Salarios.AsignarSalarioPorCategoria(empleado); // Asignación automática del salario base por categoría
                
                empleados.Add(empleado); 
                Console.WriteLine($"\nInformación personal: {empleado.Nombre} {empleado.Apellido}, {empleado.Edad} años; Posición: {tipoEmpleado}; Salario Base: {empleado.SalarioBase} pesos.");
                MetodosAuxiliares.MostrarMensaje("\nAgregado exitosamente.");
            }
            catch (FormatException)
            {
                MetodosAuxiliares.MostrarMensaje("\nFormato de entrada incorrecto. Inténtalo de nuevo.\n");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
            }
        }

        public static void ModificarEmpleado(List<Empleado> empleados)
        {
            try
            {
                if (empleados.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
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
                    empleado.SalarioBase = Convert.ToDecimal(MetodosAuxiliares.LeerDato("Salario Base", empleado.SalarioBase.ToString())); // en vez de modificar el sueldo dar la opcin de cambiar de puesto de empleado.
                    MetodosAuxiliares.MostrarMensaje("\nDatos actualizados correctamente.");
                }
            }
            catch (FormatException fe)
            {
                MetodosAuxiliares.MostrarMensaje("\nFormato de entrada incorrecto. Inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al modificar empleado: {ex.Message}");
            }
        }

        public static void EliminarEmpleado(List<Empleado> empleados)
        {
            try
            {
                if (empleados.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }

                ListaEmpleados(empleados);

                int indice = MetodosAuxiliares.ObtenerIndiceEmpleado(empleados);
                if (indice != -1)
                {
                    Console.Write($"\n¿Estás seguro que deseas eliminar a {empleados[indice].Nombre} {empleados[indice].Apellido}? (S/N): ");
                    string confirmacion = Console.ReadLine();
                    if (confirmacion.ToUpper() == "S")
                    {
                        empleados.RemoveAt(indice);
                        MetodosAuxiliares.MostrarMensaje("\nEliminado correctamente.");
                    }
                    else
                        MetodosAuxiliares.MostrarMensaje($"\nEliminación cancelada.");

                    Console.WriteLine();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MetodosAuxiliares.MostrarMensaje("\nÍndice fuera de rango. Inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al eliminar empleado: {ex.Message}");
            }
        }


    }
}