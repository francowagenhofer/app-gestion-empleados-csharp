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

        public static void ListaEmpleados()
        {
            try
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine();
                    MostrarMensaje("No hay empleados registrados.");
                    return;
                }

                // falta agregar el tipo de empleado que es
                Console.WriteLine("\nLista de Empleados:");
                for (int i = 0; i < empleados.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {empleados[i].Nombre} {empleados[i].Apellido}, puesto: (agregar logica) ");
                    
                    //, Salario: { empleados[i].CalcularSalario():C}

                }

                ContadorEmpleados();

            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error: {ex.Message}");
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
                MostrarMensaje($"Error al contar empleados: {ex.Message}");
            }
        }

        public static void BuscarEmpleado()
        {
            try
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine();
                    MostrarMensaje("No hay empleados registrados.");
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
                    MostrarMensaje("No se encontraron empleados con ese criterio.");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al buscar empleado: {ex.Message}");
            }
        }




        public static void MostrarReportes()
        {
            // # tendria que poner el monto de los bonos 
            // mostrar el tipo de empleado

            try
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine();
                    MostrarMensaje("No hay empleados registrados.");
                    return;
                }

                var reportes = empleados.Select(e => new
                {
                    NombreCompleto = $"{e.Nombre} {e.Apellido}",
                    SalarioBase = e.SalarioBase,
                    SalarioBonos = e.CalcularBonos(), // probando...
                    SalarioFinal = e.CalcularSalario()
                });

                foreach (var reporte in reportes)
                {
                    Console.WriteLine($"Nombre: {reporte.NombreCompleto}, Salario Base: {reporte.SalarioBase}, Bonos: {reporte.SalarioBonos}, Salario Final: {reporte.SalarioFinal}");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al mostrar reportes: {ex.Message}");
            }
        }


        public static void AgregarEmpleado(Empleado empleado)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine($"Ingrese los datos del {empleado.GetType().Name.ToLower()}:");
                empleado.Nombre = LeerDato("Nombre");
                empleado.Apellido = LeerDato("Apellido");
                empleado.Edad = Convert.ToInt32(LeerDato("Edad"));
                empleado.SalarioBase = Convert.ToDecimal(LeerDato("Salario Base"));

                // Asignación de bonos según el tipo de empleado
                if (empleado is Empleado)
                {
                    empleado.BonoAsistencia = Convert.ToDecimal(LeerDato("Bono Asistencia"));
                    empleado.BonoHorasExtra = Convert.ToDecimal(LeerDato("Bono Horas Extra"));
                    empleado.BonoDesempeño = Convert.ToDecimal(LeerDato("Bono Desempeño"));
                }
                else if (empleado is Gerente gerente)
                {
                    gerente.BonoMetaEquipo = Convert.ToDecimal(LeerDato("Bono Meta Equipo"));
                    gerente.BonoReduccionCostos = Convert.ToDecimal(LeerDato("Bono Reducción Costos"));
                    gerente.BonoSatisfaccionCliente = Convert.ToDecimal(LeerDato("Bono Satisfacción Cliente"));
                }
                else if (empleado is Director director)
                {
                    director.BonoDesempeñoEmpresa = Convert.ToDecimal(LeerDato("Bono Desempeño Empresa"));
                    director.BonoCrecimientoMercado = Convert.ToDecimal(LeerDato("Bono Crecimiento Mercado"));
                    director.StockOptions = Convert.ToDecimal(LeerDato("Stock Options"));
                }

                empleados.Add(empleado);

                Console.WriteLine();
                Console.WriteLine($"{empleado.GetType().Name}, {empleado.Nombre} {empleado.Apellido}, {empleado.Edad} años, Salario Final: {empleado.CalcularSalario()}");
                Console.WriteLine();
                MostrarMensaje("Agregado exitosamente.");
                Console.WriteLine();


                // creo que los bonos los agregaria en otra parte. no en donde va la ficha del empleado
                // agregaria una fecha de ingreso automatica. 

            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                MostrarMensaje("Formato de entrada incorrecto. Inténtalo de nuevo.");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error inesperado: {ex.Message}");
            }
        }


        public static void ModificarEmpleado()
        {
            try
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine();
                    MostrarMensaje("No hay empleados registrados.");
                    return;
                }

                ListaEmpleados();
                Console.WriteLine("Enter para continuar\n");

                int indice = ObtenerIndiceEmpleado();
                if (indice != -1)
                {
                    var empleado = empleados[indice];
                    empleado.Nombre = LeerDato("Nombre", empleado.Nombre);
                    empleado.Apellido = LeerDato("Apellido", empleado.Apellido);
                    empleado.Edad = Convert.ToInt32(LeerDato("Edad", empleado.Edad.ToString()));
                    empleado.SalarioBase = Convert.ToDecimal(LeerDato("Salario Base", empleado.SalarioBase.ToString()));
                    MostrarMensaje("Datos actualizados correctamente.");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                MostrarMensaje("Formato de entrada incorrecto. Inténtalo de nuevo.");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                MostrarMensaje($"Error al modificar empleado: {ex.Message}");
                Console.WriteLine();

            }
        }

        public static void EliminarEmpleado()
        {
            // me gustaria tener un alerta al eliminar.. que no se elimine sin confirmar la eliminacion
            try
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine();
                    MostrarMensaje("No hay empleados registrados.");
                    return;
                }

                ListaEmpleados();
                int indice = ObtenerIndiceEmpleado();
                if (indice != -1)
                {
                    empleados.RemoveAt(indice);
                    Console.WriteLine();
                    MostrarMensaje("Eliminado correctamente.");
                    Console.WriteLine();
                }
            }
            catch (ArgumentOutOfRangeException)
            {

                MostrarMensaje("Índice fuera de rango. Inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al eliminar empleado: {ex.Message}");
            }
        }


        public static void CalcularSalariosConIncremento()
        {
            try
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine();
                    MostrarMensaje("No hay empleados registrados.");
                    return;
                }

                Console.Write("Ingrese el porcentaje de incremento o bono adicional: ");
                decimal incremento = Convert.ToDecimal(Console.ReadLine());

                foreach (var empleado in empleados)
                {
                    decimal salarioConIncremento = empleado.CalcularSalario() + (empleado.CalcularSalario() * incremento / 100);
                    Console.WriteLine($"Empleado: {empleado.Nombre} {empleado.Apellido}, Salario Final con Incremento: {salarioConIncremento}");
                }
                Console.ReadLine();
            }
            catch (FormatException)
            {
                MostrarMensaje("Formato incorrecto. Inténtelo de nuevo.");
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al calcular salarios con incremento: {ex.Message}");
            }
        }



        // Métodos auxiliares para leer datos, mostrar mensajes y obtener índice
        public static string LeerDato(string campo, string valorPorDefecto = "")
        {
            Console.Write($"{campo}{(valorPorDefecto != "" ? $" (actual: {valorPorDefecto})" : "")}: ");
            return Console.ReadLine();
        }

        public static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.WriteLine();
            Console.Write("Presiona Enter para continuar ");
            Console.ReadLine();
        }



        public static int ObtenerIndiceEmpleado()
        {
            try
            {
                Console.Write("Ingresa el número del empleado: ");
                if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= empleados.Count)
                    return indice - 1; // Se resta uno para ajustar la lista -> lista programa (empieza contando desde 0 ) ≠ lista humana (comienza contando desde 1) 

                // Lanza la excepción si el índice no cumple las condiciones
                throw new ArgumentOutOfRangeException("Índice no válido.");
            }
            catch (FormatException)
            {
                MostrarMensaje("Formato de entrada incorrecto. Inténtalo de nuevo.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MostrarMensaje(ex.Message);
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error inesperado: {ex.Message}");
            }

            return -1;
        }



    }
}
