using Dominio.Entidades;
using Dominio.Entidades.Dominio.Entidades;
using Dominio.ReglasDelNegocio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola.LogicaAppConsola
{
    public class LogicaOperaciones // Adaptcion de los metodos de las clases SalarioNegocio y BonosNegocio a la App de Consola
    {
        // SALARIOS
        public static void Salarios() // Bien.
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\nSalarios\n");
                    Console.WriteLine("1. Ver lista de salarios\n");
                    Console.WriteLine("2. Modificar salarios existentes\n");
                    Console.WriteLine("3. Calcular salarios existentes, aplicando incrementos o deducciones\n");
                    //Console.WriteLine("4. Agregar Salario\n");
                    //Console.WriteLine("5. Eliminar Salario\n");
                    Console.WriteLine("\n4. Volver");
                    Console.Write("\nSeleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            ListarSalarioConsola();
                            break;
                        case "2":
                            ModificarSalarioConsola();
                            break;
                        case "3":
                            CalcularSalariosConIncrementoConsola();
                            break;
                        //case "4":
                        //    AgregarSalarioConsola(); // Dilema ...
                        //    break;
                        //case "5":
                        //    EliminarSalarioConsola();
                        //    break;
                        case "4":
                            return;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
                }
            }
        }

        public static void ListarSalarioConsola() // Bien.
        {
            SalariosNegocio salariosNegocio = new SalariosNegocio();
            try
            {
                List<Salarios> salarios = salariosNegocio.ListarSalarios();
                if (salarios == null || salarios.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay salarios registrados.");
                    return;
                }

                Console.WriteLine("\n- Lista de salarios por categoria -");
                for (int i = 0; i < salarios.Count; i++)
                {
                    Console.WriteLine($"\n{i + 1}) Id: {salarios[i].Id} - Salario de {salarios[i].NombreCategoria}: ${salarios[i].Monto}.");
                }
                Negocio.MetodosAuxiliares.MostrarMensaje($"\n - # -");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError: {ex.Message}\n");
            }
        }

        public static void ModificarSalarioConsola() //Bien. 
        {
            SalariosNegocio salarioNegocio = new SalariosNegocio();
            try
            {
                List<Salarios> listaSalarios = salarioNegocio.ListarSalarios();
                if (listaSalarios == null || listaSalarios.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay salarios registrados.");
                    return;
                }
                ListarSalarioConsola();

                Console.WriteLine("\n- Modificar Salario -");
                int salarioId;
                bool esNumeroValido = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("\nId del salario a modificar", ""), out salarioId);

                if (!esNumeroValido || !listaSalarios.Any(s => s.Id == salarioId))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nId de salario no válido. Inténtalo de nuevo.");
                    return;
                }

                var salarioSeleccionado = listaSalarios.First(s => s.Id == salarioId);

                decimal nuevoMonto;
                bool montoValido = decimal.TryParse(Negocio.MetodosAuxiliares.LeerDato("\nNuevo Monto", salarioSeleccionado.Monto.ToString()), out nuevoMonto);
                if (!montoValido)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nMonto no válido. Inténtalo de nuevo.");
                    return;
                }

                Salarios salarioModificado = new Salarios
                {
                    Id = salarioSeleccionado.Id,
                    Monto = nuevoMonto,
                    IdCategoria = salarioSeleccionado.IdCategoria
                };

                salarioNegocio.ModificarSalario(salarioModificado);

                Negocio.MetodosAuxiliares.MostrarMensaje("\nSalario actualizado correctamente.");
            }
            catch (FormatException fe)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje("\nFormato de entrada incorrecto. Inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al modificar salario: {ex.Message}");
            }
        }

        public static void CalcularSalariosConIncrementoConsola() // Bien.
        {
            SalariosNegocio salariosNegocio = new SalariosNegocio();
            try
            {
                List<Salarios> salarios = salariosNegocio.ListarSalarios();
                if (salarios == null || salarios.Count == 0)
                {
                    Console.WriteLine("\nNo hay salarios registrados.");
                    return;
                }
                ListarSalarioConsola();

                Console.WriteLine("\n- Calcular Salario -");
                Console.WriteLine("\n1. Incrementar o reducir salario de una categoría.");
                Console.WriteLine("\n2. Incrementar o reducir salario de todas las categorías.");
                Console.Write("\nSeleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                decimal porcentaje;
                Console.Write("\nIngrese el porcentaje de incremento o rebaja (Ej: 10 para 10%): ");
                porcentaje = Convert.ToDecimal(Console.ReadLine()) / 100;

                switch (opcion)
                {
                    case 1:
                        Console.Write("\nIngrese el número de la categoría de la lista para aplicar el incremento/rebaja: ");
                        int seleccion = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (seleccion >= 0 && seleccion < salarios.Count)
                        {
                            Salarios salarioSeleccionado = salarios[seleccion];
                            decimal montoAnterior = salarioSeleccionado.Monto;

                            decimal nuevoSalario = salarioSeleccionado.Monto + salarioSeleccionado.Monto * porcentaje;

                            Negocio.MetodosAuxiliares.MostrarMensaje($"\nNuevo salario calculado para la categoría {salarioSeleccionado.NombreCategoria}: de ${montoAnterior} a ${nuevoSalario}.");
                        }
                        else
                            Negocio.MetodosAuxiliares.MostrarMensaje("\nSelección no válida.");

                        break;
                    case 2:
                        foreach (var salario in salarios)
                        {
                            decimal montoAnterior = salario.Monto;
                            decimal nuevoSalario = salario.Monto + salario.Monto * porcentaje;

                            Console.WriteLine($"\nNuevo salario calculado para la categoría {salario.NombreCategoria}: de ${montoAnterior} a ${nuevoSalario}.");
                        }
                        Negocio.MetodosAuxiliares.MostrarMensaje("\nIncremento/rebaja aplicado correctamente a todos los salarios.");
                        break;

                    default:
                        Negocio.MetodosAuxiliares.MostrarMensaje("\nOpción no válida. Inténtelo de nuevo.");
                        break;
                }
            }
            catch (FormatException)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje("\nFormato incorrecto. Inténtelo de nuevo.");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al calcular salarios con incremento/rebaja: {ex.Message}");
            }
        }

        //public static void AgregarSalarioConsola() 
        //{
        //    SalariosNegocio salarioNegocio = new SalariosNegocio();
        //    try
        //    {
        //        Console.WriteLine("\n- Agregar Salario -\n");

        //        // Ingresar manualmente el IdCategoria
        //        int idCategoria;
        //        bool categoriaValida = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("ID de la Categoría"), out idCategoria);
        //        if (!categoriaValida)
        //        {
        //            Negocio.MetodosAuxiliares.MostrarMensaje("\nID de Categoría no válido. Inténtalo de nuevo.");
        //            return;
        //        }

        //        // Ingresar manualmente el monto del salario
        //        decimal monto;
        //        bool montoValido = decimal.TryParse(Negocio.MetodosAuxiliares.LeerDato("Monto del Salario"), out monto);
        //        if (!montoValido)
        //        {
        //            Negocio.MetodosAuxiliares.MostrarMensaje("\nMonto no válido. Inténtalo de nuevo.");
        //            return;
        //        }

        //        // Crear nuevo objeto Salario con los datos ingresados
        //        Salarios nuevoSalario = new Salarios
        //        {
        //            IdCategoria = idCategoria,
        //            Monto = monto
        //        };

        //        // Llamar al método de la capa de negocio para agregar el salario
        //        salarioNegocio.AgregarSalario(nuevoSalario);
        //        Negocio.MetodosAuxiliares.MostrarMensaje("\nSalario agregado correctamente.");
        //    }
        //    catch (Exception ex)
        //    {
        //        Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al agregar salario: {ex.Message}");
        //    }
        //}

        //public static void EliminarSalarioConsola() 
        //{
        //    SalariosNegocio salarioNegocio = new SalariosNegocio();
        //    try
        //    {
        //        List<Salarios> listaSalarios = salarioNegocio.ListarSalarios();
        //        if (listaSalarios == null || listaSalarios.Count == 0)
        //        {
        //            Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay salarios registrados.");
        //            return;
        //        }
        //        Console.WriteLine("\n- Lista de Salarios -\n");
        //        foreach (var salario in listaSalarios)
        //        {
        //            Console.WriteLine($"ID: {salario.Id}, Monto: {salario.Monto}, Categoría: {salario.IdCategoria}");
        //        }

        //        int salarioId;
        //        bool esNumeroValido = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("ID del Salario a eliminar", ""), out salarioId);

        //        if (!esNumeroValido || !listaSalarios.Any(s => s.Id == salarioId))
        //        {
        //            Negocio.MetodosAuxiliares.MostrarMensaje("\nID de salario no válido. Inténtalo de nuevo.");
        //            return;
        //        }

        //        string confirmacion = Negocio.MetodosAuxiliares.LeerDato("\n¿Estás seguro de que quieres eliminar este salario? (s/n)", "").ToLower();
        //        if (confirmacion != "s")
        //        {
        //            Negocio.MetodosAuxiliares.MostrarMensaje("\nOperación cancelada.");
        //            return;
        //        }

        //        salarioNegocio.EliminarSalario(salarioId);
        //        Negocio.MetodosAuxiliares.MostrarMensaje("\nSalario eliminado correctamente.");
        //    }
        //    catch (FormatException fe)
        //    {
        //        Negocio.MetodosAuxiliares.MostrarMensaje($"\nError de formato: {fe.Message}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al eliminar salario: {ex.Message}");
        //    }
        //}


        // BONOS 
        public static void Bonos() // Bien. 
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n Bonos\n");
                    Console.WriteLine("1. Ver lista de bonos\n");
                    Console.WriteLine("2. Modificar bonos existentes\n");
                    Console.WriteLine("3. Calcular bonos existentes, aplicando incrementos o deducciones\n");
                    Console.WriteLine("4. Asignar bono/s a un empleado\n");
                    Console.WriteLine("5. Desasignar bono/s a un empleado\n");
                    Console.WriteLine("\n6. Volver");
                    Console.Write("\nSeleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            ListarBonosConsola();
                            break;
                        case "2":
                            ModificarBonoConsola();
                            break;
                        case "3":
                            CalcularBonosConIncrementoConsola();
                            break;
                        case "4":
                            AsignarBonoAEmpleadoConsola();
                            break;
                        case "5":
                            DesasignarBonoDeEmpleadoConsola();
                            break;
                        case "6":
                            return;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje($"\nError inesperado: {ex.Message}\n");
                }
            }
        }

        public static void ListarBonosConsola() // Bien. 
        {
            BonosNegocio bonosNegocio = new BonosNegocio();
            try
            {
                List<Bonos> bonos = bonosNegocio.ListarBonos();
                if (bonos == null || bonos.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay bonos registrados.");
                    return;
                }

                Console.WriteLine("\n- Lista de bonos -");
                for (int i = 0; i < bonos.Count; i++)
                {
                    Console.WriteLine($"\n{i + 1}) Id: {bonos[i].Id} - Bono {bonos[i].Nombre}: ${bonos[i].Monto}.");
                }
                Negocio.MetodosAuxiliares.MostrarMensaje($"\n - # -");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError: {ex.Message}\n");
            }
        }

        public static void ModificarBonoConsola() // Bien. 
        {
            BonosNegocio bonosNegocio = new BonosNegocio();
            try
            {
                List<Bonos> listaBonos = bonosNegocio.ListarBonos();
                if (listaBonos == null || listaBonos.Count == 0)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nNo hay bonos registrados.");
                    return;
                }
                ListarBonosConsola();

                Console.WriteLine("\n- Modificar Bono -");
                int bonoId;
                bool esNumeroValido = int.TryParse(Negocio.MetodosAuxiliares.LeerDato("\nId del bono a modificar", ""), out bonoId);

                if (!esNumeroValido || !listaBonos.Any(b => b.Id == bonoId))
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nId de bono no válido. Inténtalo de nuevo.");
                    return;
                }

                var bonoSeleccionado = listaBonos.First(b => b.Id == bonoId);

                decimal nuevoMonto;
                bool montoValido = decimal.TryParse(Negocio.MetodosAuxiliares.LeerDato("\nNuevo Monto", bonoSeleccionado.Monto.ToString()), out nuevoMonto);
                if (!montoValido)
                {
                    Negocio.MetodosAuxiliares.MostrarMensaje("\nMonto no válido. Inténtalo de nuevo.");
                    return;
                }

                Bonos bonoModificado = new Bonos
                {
                    Id = bonoSeleccionado.Id,
                    Monto = nuevoMonto,
                    Nombre = bonoSeleccionado.Nombre
                };

                bonosNegocio.ModificarBono(bonoModificado);

                Negocio.MetodosAuxiliares.MostrarMensaje("\nBono actualizado correctamente.");
            }
            catch (FormatException fe)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje("\nFormato de entrada incorrecto. Inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al modificar bono: {ex.Message}");
            }
        }

        public static void CalcularBonosConIncrementoConsola() // Bien.
        {
            BonosNegocio bonosNegocio = new BonosNegocio();
            try
            {
                List<Bonos> bonos = bonosNegocio.ListarBonos();
                if (bonos == null || bonos.Count == 0)
                {
                    Console.WriteLine("\nNo hay bonos registrados.");
                    return;
                }
                ListarBonosConsola();

                Console.WriteLine("\n- Calcular Bono -");
                Console.WriteLine("\n1. Incrementar o reducir bono de un tipo.");
                Console.WriteLine("\n2. Incrementar o reducir bono de todos los tipos.");
                Console.Write("\nSeleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                decimal porcentaje;
                Console.Write("\nIngrese el porcentaje de incremento o rebaja (Ej: 10 para 10%): ");
                porcentaje = Convert.ToDecimal(Console.ReadLine()) / 100;

                switch (opcion)
                {
                    case 1:
                        Console.Write("\nIngrese el Id del bono de la lista para aplicar el incremento/rebaja: ");
                        int seleccion = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (seleccion >= 0 && seleccion < bonos.Count)
                        {
                            Bonos bonoSeleccionado = bonos[seleccion];
                            decimal montoAnterior = bonoSeleccionado.Monto;

                            decimal nuevoBono = bonoSeleccionado.Monto + bonoSeleccionado.Monto * porcentaje;

                            Negocio.MetodosAuxiliares.MostrarMensaje($"\nNuevo bono calculado para el tipo {bonoSeleccionado.Nombre}: de ${montoAnterior} a ${nuevoBono}.");
                        }
                        else
                            Negocio.MetodosAuxiliares.MostrarMensaje("\nSelección no válida.");

                        break;
                    case 2:
                        foreach (var bono in bonos)
                        {
                            decimal montoAnterior = bono.Monto;
                            decimal nuevoBono = bono.Monto + bono.Monto * porcentaje;

                            Console.WriteLine($"\nNuevo bono calculado para el tipo {bono.Nombre}: de ${montoAnterior} a ${nuevoBono}.");
                        }
                        Negocio.MetodosAuxiliares.MostrarMensaje("\nIncremento/rebaja aplicado correctamente a todos los bonos.");
                        break;

                    default:
                        Negocio.MetodosAuxiliares.MostrarMensaje("\nOpción no válida. Inténtelo de nuevo.");
                        break;
                }
            }
            catch (FormatException)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje("\nFormato incorrecto. Inténtelo de nuevo.");
            }
            catch (Exception ex)
            {
                Negocio.MetodosAuxiliares.MostrarMensaje($"\nError al calcular bonos con incremento/rebaja: {ex.Message}");
            }
        }

        public static void AsignarBonoAEmpleadoConsola() // Bien. 
        {
            BonosNegocio bonosNegocio = new BonosNegocio();
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();

            try
            {
                List<Bonos> bonos = bonosNegocio.ListarBonos();
                List<Empleado> empleados = empleadoNegocio.ListarEmpleados();

                if (bonos.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay tipos de bonos registrados.");
                    return;
                }
                else if (empleados.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }

                Console.WriteLine("\n- Asignar Bono a Empleado -");

                ListarBonosConsola(); 
                int seleccionBono;
                bool esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id del bono", ""), out seleccionBono);
                if (!esNumeroValido || !bonos.Any(b => b.Id == seleccionBono))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de bono no válido. Inténtalo de nuevo.");
                    return;
                }

                LogicaAppConsola.LogicaEmpleados.ListaEmpleadosConsola();
                int seleccionEmpleado;
                esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id del empleado", ""), out seleccionEmpleado);
                if (!esNumeroValido || !empleados.Any(e => e.Id == seleccionEmpleado))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de empleado no válido. Inténtalo de nuevo.");
                    return;
                }

                DateTime fechaAsignacion = DateTime.Now;

                // Verificar si el empleado ya tiene este bono asignado
                List<Bonos> bonosAsignados = bonosNegocio.ListarBonosAsignadosEmpleado(seleccionEmpleado);
                if (bonosAsignados.Any(b => b.Id == seleccionBono))
                {
                    MetodosAuxiliares.MostrarMensaje("\nEl empleado ya tiene este bono asignado. No se puede asignar más de una vez.");
                    return;
                }

                bonosNegocio.AsignarBonoAEmpleado(seleccionEmpleado, seleccionBono, fechaAsignacion);
                MetodosAuxiliares.MostrarMensaje("\nBono asignado al empleado correctamente.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al asignar bono al empleado: {ex.Message}");
            }
        }

        public static void DesasignarBonoDeEmpleadoConsola() // Bien. 
        {
            try
            {
                BonosNegocio bonosNegocio = new BonosNegocio();
                EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();

                List<Empleado> empleados = empleadoNegocio.ListarEmpleados();

                if (empleados.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay empleados registrados.");
                    return;
                }
                LogicaAppConsola.LogicaEmpleados.ListaEmpleadosConsola();

                Console.WriteLine("\n- Desasignar Bono de Empleado -");

                int seleccionEmpleado;
                bool esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id del empleado", ""), out seleccionEmpleado);

                if (!esNumeroValido || !empleados.Any(e => e.Id == seleccionEmpleado))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de empleado no válido. Inténtalo de nuevo.");
                    return;
                }

                List<Bonos> bonosAsignados = bonosNegocio.ListarBonosAsignadosEmpleado(seleccionEmpleado);

                if (bonosAsignados.Count == 0)
                {
                    MetodosAuxiliares.MostrarMensaje("\nNo hay bonos asignados a este empleado.");
                    return;
                }

                Console.WriteLine("\nBonos asignados a este empleado:");
                foreach (var bono in bonosAsignados)
                {
                    Console.WriteLine($"Id Bono: {bono.Id}, Tipo: {bono.Nombre}");
                }

                int seleccionBono;
                esNumeroValido = int.TryParse(MetodosAuxiliares.LeerDato("\nSeleccione el Id del bono a desasignar", ""), out seleccionBono);

                if (!esNumeroValido || !bonosAsignados.Any(b => b.Id == seleccionBono))
                {
                    MetodosAuxiliares.MostrarMensaje("\nId de bono no válido. Inténtalo de nuevo.");
                    return;
                }

                bonosNegocio.DesasignarBonoDeEmpleado(seleccionEmpleado, seleccionBono);
                MetodosAuxiliares.MostrarMensaje("\nBono desasignado del empleado correctamente.");
            }
            catch (Exception ex)
            {
                MetodosAuxiliares.MostrarMensaje($"\nError al ejecutar la operación: {ex.Message}");
            }
        }

    }
}
