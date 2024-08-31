using Dominio.Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppConsola.LogicaAppConsola
{
    public class LogicaEmpleados
    {
        //-------------------------------------------------------------------------------------------------------------------------------//

        //                  Adaptcion de los metodos de EmpleadoNegocio a la App de Consola
        

        //-------------------------------------------------------------------------------------------------------------------------------//


        public static void ListaEmpleadosConsola(List<Empleado> empleados)
        {
            try
            {
                if (empleados.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
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
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError: {ex.Message}\n");
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
                Negocio.MetodosAuxiliares.MostrarMensaje($"Total de Empleados: {totalEmpleados}");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al contar empleados: {ex.Message}");
            }
        }


        public static void BuscarEmpleadoConsola(List<Empleado> empleados) // el buscador de empleados varia segun el tipo de aplicacion (consola, escritorio, web). 
        {
            try
            {
                if (empleados.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }

                Console.Write("\nIngrese el nombre o apellido del empleado a buscar: ");
                string criterio = Console.ReadLine()?.Trim().ToLower();

                // Validar que el criterio no sea vacío
                if (string.IsNullOrWhiteSpace(criterio))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nDebe ingresar un nombre o apellido valido para buscar.");
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
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo se encontraron empleados con ese criterio.");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al buscar empleado: {ex.Message}\n");
            }
        }




        // Agregar un nuevo empleado mediante la interacción con la consola

        // opcion 1
        //public static void AgregarEmpleado(List<Empleado> empleados, Empleado empleado)
        //{
        //    try
        //    {
        //        //Console.WriteLine($"\nIngrese los datos del {empleado.GetType().Name.ToLower()}:");
        //        string tipoEmpleado = empleado.EsOperativo ? "Empleado Operativo" : empleado.GetType().Name;

        //        Console.WriteLine($"\nIngrese los datos del {tipoEmpleado}:");

        //        // tendria que agregarle un Id. 
        //        // luego el Id se da en la base de datos

        //        empleado.Nombre = MetodosAuxiliares.LeerDato("Nombre");
        //        empleado.Apellido = MetodosAuxiliares.LeerDato("Apellido");
        //        empleado.Edad = Convert.ToInt32(MetodosAuxiliares.LeerDato("Edad"));

        //        SalariosNegocio.AsignarSalarioPorCategoria(empleado); // Asignación automática del salario base por categoría

        //        empleados.Add(empleado);
        //        Console.WriteLine($"\nInformación personal: {empleado.Nombre} {empleado.Apellido}, {empleado.Edad} años; Posición: {tipoEmpleado}; Salario Base: {empleado.SalarioBase} pesos.");
        //        MetodosAuxiliares.MostrarMensaje("\nAgregado exitosamente.");
        //    }
        //    catch (FormatException)
        //    {
        //        MetodosAuxiliares.MostrarMensaje("\nFormato de entrada incorrecto. Inténtalo de nuevo.\n");
        //    }
        //    catch (Exception ex)
        //    {
        //        MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
        //    }
        //}

        public static void AgregarEmpleadoConsola(List<Empleado> empleados)
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
                            nuevoEmpleado = new Empleado(esOperativo: true);
                            break;
                        case "2":
                            nuevoEmpleado = new Gerente();
                            break;
                        case "3":
                            nuevoEmpleado = new Director();
                            break;
                        case "4":
                            return;
                        default:
                            Negocio.MetodosAuxiliares.MostrarMensaje("\nOpción no válida.");
                            continue;
                    }

                    // Solicitar los datos del nuevo empleado
                    nuevoEmpleado.Nombre = Negocio.MetodosAuxiliares.LeerDato("Nombre");
                    nuevoEmpleado.Apellido = Negocio.MetodosAuxiliares.LeerDato("Apellido");
                    nuevoEmpleado.Edad = Convert.ToInt32(Negocio.MetodosAuxiliares.LeerDato("Edad"));

                    // tendria que agregarle un Id


                    // Asignar el salario por categoría
                    SalariosNegocio.AsignarSalarioPorCategoria(nuevoEmpleado);

                    // Agregar el nuevo empleado a la lista a través de la capa de negocio 
                    EmpleadoNegocio.AgregarEmpleado(empleados, nuevoEmpleado);

                    // Mostrar la información del empleado agregado
                    Console.WriteLine($"\nEmpleado agregado: {nuevoEmpleado.Nombre} {nuevoEmpleado.Apellido}; Salario Base: {nuevoEmpleado.SalarioBase} pesos.");
                    Negocio.MetodosAuxiliares.MostrarMensaje("Empleado agregado exitosamente.");
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado en el proceso de agregar empleado: {ex.Message}\n");
                }
            }
        }


        public static void ModificarEmpleadoConsola(List<Empleado> empleados) // esta raro -> revisar ...
        {
            //var empleados = EmpleadoNegocio.ObtenerListaEmpleados();

            try
            {
                if (empleados.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }

                ListaEmpleadosConsola(empleados);

                //MostrarListaEmpleados();

                int indice = Negocio.MetodosAuxiliares.ObtenerIndiceEmpleado(empleados);
                if (indice != -1)
                {
                    var empleado = empleados[indice];

                    string nuevoNombre = Negocio.MetodosAuxiliares.LeerDato("Nombre", empleado.Nombre);
                    string nuevoApellido = Negocio.MetodosAuxiliares.LeerDato("Apellido", empleado.Apellido);
                    int nuevaEdad = Convert.ToInt32(Negocio.MetodosAuxiliares.LeerDato("Edad", empleado.Edad.ToString()));
                    decimal nuevoSalario = Convert.ToDecimal(Negocio.MetodosAuxiliares.LeerDato("Salario Base", empleado.SalarioBase.ToString()));

                    EmpleadoNegocio.ModificarEmpleado(empleado, nuevoNombre, nuevoApellido, nuevaEdad, nuevoSalario);

                    Negocio.MetodosAuxiliares.MostrarMensaje("\nDatos actualizados correctamente.");
                }
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


        public static void EliminarEmpleadoConsola(List<Empleado> empleados)
        {
            //var empleados = EmpleadoNegocio.ObtenerListaEmpleados();

            if (empleados.Count == 0)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                return;
            }

            ListaEmpleadosConsola(empleados);

            //MostrarListaEmpleados();

            int indice = Negocio.MetodosAuxiliares.ObtenerIndiceEmpleado(empleados);
            if (indice != -1)
            {
                Console.Write($"\n¿Estás seguro que deseas eliminar a {empleados[indice].Nombre} {empleados[indice].Apellido}? (S/N): ");
                string confirmacion = Console.ReadLine();
                if (confirmacion.ToUpper() == "S")
                {
                    EmpleadoNegocio.EliminarEmpleado(empleados, indice);
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nEliminado correctamente.");
                }
                else
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nEliminación cancelada.");
                }
            }
        }

    }
}
