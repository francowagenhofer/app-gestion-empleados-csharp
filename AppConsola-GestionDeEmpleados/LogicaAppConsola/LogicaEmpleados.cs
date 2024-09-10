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
        //                  Adaptcion de los metodos de EmpleadoNegocio a la App de Consola                                              //
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

                Console.WriteLine("\nLista de Empleados");
                for (int i = 0; i < empleados.Count; i++)
                {
                    string tipoEmpleado = empleados[i] is Gerente ? "Gerente" : empleados[i] is Director ? "Director" : "Empleado Operativo";
                    Console.WriteLine($"{i + 1}. {empleados[i].Nombre} {empleados[i].Apellido}; Puesto: {tipoEmpleado}.");
                }

                //; Salario: { empleados[i].CalcularSalario()}
                //pesos ----> ver en reporte de empleados!

            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError: {ex.Message}\n");
            }
        }

        public static void ContadorEmpleadosConsola(List<Empleado> empleados) // Esta el metodo contarEmpleados en la clase Empleado - como se relacionan?
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

        public static void InformacionEmpleadoConsola(List<Empleado> empleados) 
        {
        // el buscador de empleados varia segun el tipo de aplicacion (consola, escritorio, web). 
        // tengo que hacer cambios en este metodo para mejorarlo
        // primero agregar la lista de empleados
        // segundo agregar la informacion del empleado seleccionado:
        // nombre, edad, salario, puesto, fecha de contratacion, bonos, informacion de contacto, estado laboral (activo, no-avtivo)

            try
            {
                if (empleados.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }

                ListaEmpleadosConsola(empleados);

                Console.Write("\nIngrese el nombre o apellido del empleado a buscar: ");
                string criterio = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(criterio)) // Validar que el criterio no sea vacío
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
                        string tipoEmpleado = empleado is Gerente ? "Gerente" : empleado is Director ? "Director" : "Empleado Operativo";

                        Console.WriteLine($"\nEmpleado encontrado: \n");
                        Console.WriteLine("\n# Informacion del empleado\n");
                        Console.WriteLine($"Nombre: {empleado.Nombre} {empleado.Apellido}");

                        Console.WriteLine($"Edad: {empleado.Edad}"); // fecha de nacimineto 
                        Console.WriteLine($"Edad: {empleado.FechaNacimiento}"); // fecha de nacimineto 

                        Console.WriteLine($"Puesto: {empleado.GetType().Name} - {tipoEmpleado}");
                        Console.WriteLine($"Fecha de Ingreso");//Ingreso en la empresa
                        Console.WriteLine($"Salario Base: ${empleado.SalarioBase}");
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

        //----------------------------------------------------------------------------------------------------------------------------------

        //public static void AgregarEmpleadoConsola(List<Empleado> empleados)
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            Console.Clear();
        //            Console.WriteLine("\nAñadir Empleado\n");
        //            Console.WriteLine("1. Añadir Empleado Operativo");
        //            Console.WriteLine("2. Añadir Gerente");
        //            Console.WriteLine("3. Añadir Director");
        //            Console.WriteLine("\n4. Volver");
        //            Console.Write("\nSelecciona una opción: ");

        //            string opcion = Console.ReadLine();

        //            Empleado nuevoEmpleado = null;

        //            switch (opcion)
        //            {
        //                case "1":
        //                    nuevoEmpleado = new Empleado(esOperativo: true);
        //                    break;
        //                case "2":
        //                    nuevoEmpleado = new Gerente();
        //                    break;
        //                case "3":
        //                    nuevoEmpleado = new Director();
        //                    break;
        //                case "4":
        //                    return;
        //                default:
        //                    Negocio.MetodosAuxiliares.MostrarMensaje("\nOpción no válida.");
        //                    continue;
        //            }

        //            string tipoEmpleado = nuevoEmpleado.EsOperativo ? "Empleado Operativo" : nuevoEmpleado.GetType().Name;


        //            // Solicitar los datos del nuevo empleado
        //            nuevoEmpleado.Nombre = Negocio.MetodosAuxiliares.LeerDato("Nombre");
        //            nuevoEmpleado.Apellido = Negocio.MetodosAuxiliares.LeerDato("Apellido");
        //            nuevoEmpleado.Edad = Convert.ToInt32(Negocio.MetodosAuxiliares.LeerDato("Edad"));
        //            nuevoEmpleado.FechaNacimiento = Convert.ToInt32(Negocio.MetodosAuxiliares.LeerDato("Edad"));
        //            // tendria que agregarle un Id

        //            // Asignar el salario por categoría
        //            SalariosNegocio.AsignarSalarioPorCategoria(nuevoEmpleado);

        //            // Agregar el nuevo empleado a la lista a través de la capa de negocio 
        //            EmpleadoNegocio.AgregarEmpleado(empleados, nuevoEmpleado);

        //            // Mostrar la información del empleado agregado
        //            Console.WriteLine($"\nEmpleado agregado: {nuevoEmpleado.Nombre} {nuevoEmpleado.Apellido}; Puesto: {tipoEmpleado}; Salario Base: {nuevoEmpleado.SalarioBase} pesos.");
        //            Negocio.MetodosAuxiliares.MostrarMensaje("\nAgregado exitosamente.");



        //        }
        //        catch (Exception ex)
        //        {
        //            Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado en el proceso de agregar empleado: {ex.Message}\n");
        //        }
        //    }
        //}



        // puedo mostrar cuantos empleados estan activos o eso en un reporte ....


        public static void AgregarEmpleadoConsola(List<Empleado> empleado)
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

                    // Seleccionar la categoría basada en la opción elegida
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

                    // Solicitar los datos del nuevo empleado
                    nuevoEmpleado.Nombre = Negocio.MetodosAuxiliares.LeerDato("Nombre");
                    nuevoEmpleado.Apellido = Negocio.MetodosAuxiliares.LeerDato("Apellido");
                    nuevoEmpleado.FechaNacimiento = DateTime.Parse(Negocio.MetodosAuxiliares.LeerDato("Fecha de Nacimiento (dd/MM/yyyy)")); // tendria que calcularse el numero de años...
                    
                    nuevoEmpleado.DNI = Convert.ToInt32(Negocio.MetodosAuxiliares.LeerDato("DNI")); 
                    // solo se puede registrar una unica cuenta por dni, tendria que validar esto!!
                    
                    nuevoEmpleado.FechaIngreso = DateTime.Now;  // Fecha de ingreso se asigna automáticamente
                    nuevoEmpleado.IsActive = true;

                    // Asignar el salario según la categoría seleccionada
                    EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
                    SalariosNegocio.AsignarSalarioPorCategoria(nuevoEmpleado); // tengo que mejorar esta logica ...

                    // Agregar el nuevo empleado a la base de datos a través de la capa de negocio
                    empleadoNegocio.AgregarEmpleado(nuevoEmpleado); 

                    // Mostrar la información del empleado agregado
                    string tipoEmpleado = nuevoEmpleado.Categoria == 1 ? "Empleado Operativo" :
                                          nuevoEmpleado.Categoria == 2 ? "Gerente" : "Director";

                    Console.WriteLine($"\nEmpleado agregado: {nuevoEmpleado.Nombre} {nuevoEmpleado.Apellido}; Puesto: {tipoEmpleado}; Salario Base: {nuevoEmpleado.SalarioBase} pesos.");
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nAgregado exitosamente.");
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado en el proceso de agregar empleado: {ex.Message}\n");
                }
            }
        }




        //----------------------------------------------------------------------------------------------------------------------------------

        public static void ModificarEmpleadoConsola(List<Empleado> empleados) // cambiar el modificar salario por modificar posicion. 
        {
            //var empleados = EmpleadoNegocio.ObtenerListaEmpleados();

            try
            {
                if (empleados.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }

                //Console.Clear();
                Console.WriteLine("\nModificar Empleado");

                ListaEmpleadosConsola(empleados);

                //MostrarListaEmpleados();

                int indice = Negocio.MetodosAuxiliares.ObtenerIndiceEmpleado(empleados);
                if (indice != -1)
                {
                    var empleado = empleados[indice];
                    string nuevoNombre = Negocio.MetodosAuxiliares.LeerDato("Nombre", empleado.Nombre);
                    string nuevoApellido = Negocio.MetodosAuxiliares.LeerDato("Apellido", empleado.Apellido);

                    int nuevaEdad = Convert.ToInt32(Negocio.MetodosAuxiliares.LeerDato("Edad", empleado.Edad.ToString()));
                    //int nuevaEdad = Convert.ToInt32(Negocio.MetodosAuxiliares.LeerDato("Edad", empleado.FechaNacimiento.ToString()));

                    // puesto 

                    //EmpleadoNegocio.ModificarEmpleado(empleado, nuevoNombre, nuevoApellido, nuevaEdad); /*, nuevoPuesto*/

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

            //Console.Clear();
            Console.WriteLine("\nEliminar Empleado");

            ListaEmpleadosConsola(empleados);

            //MostrarListaEmpleados();

            int indice = Negocio.MetodosAuxiliares.ObtenerIndiceEmpleado(empleados);
            if (indice != -1)
            {
                Console.Write($"\n¿Estás seguro que deseas eliminar a {empleados[indice].Nombre} {empleados[indice].Apellido}? (S/N): ");
                string confirmacion = Console.ReadLine();
                if (confirmacion.ToUpper() == "S")
                {
                    //EmpleadoNegocio.EliminarEmpleado(empleados, indice);
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
