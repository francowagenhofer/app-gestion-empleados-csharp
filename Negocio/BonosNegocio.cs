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
    public class BonosNegocio
    {
        // tendria que adaptar la esencia de estos metodos para que sean universales y asi poder llamarlos desde cualquier app

        //public static void AsignarBonos(List<Empleado> empleados)
        //{
        //    // Pedimos el ID del empleado
        //    Console.Write("Ingrese el ID del empleado al que desea asignar un bono:");
        //    int empleadoId = int.Parse(Console.ReadLine());

        //    // Buscamos el empleado por ID
        //    var empleado = empleados.FirstOrDefault(e => e.Id == empleadoId);
        //    if (empleado == null)
        //    {
        //        Console.WriteLine("Empleado no encontrado.");
        //        return;
        //    }

        //    // Según el tipo de empleado, mostramos el menú de bonos correspondientes
        //    if (empleado is Empleado) // General para todos los empleados
        //    {
        //        Console.WriteLine("Empleado encontrado: Asignando bonos generales...");
        //        empleado.Bonos.BonoAsistencia = LeerYAsignarBono("Bono Asistencia");
        //        empleado.Bonos.BonoAsistencia = LeerYAsignarBono("Bono Horas Extra");
        //        empleado.Bonos.BonoAsistencia = LeerYAsignarBono("Bono Desempeño");
        //    }
        //    else if (empleado is Gerente gerente)
        //    {
        //        Console.WriteLine("Gerente encontrado: Asignando bonos de gerente...");
        //        gerente.Bonos.BonoAsistencia = LeerYAsignarBono("Bono Meta Equipo");
        //        gerente.Bonos.BonoAsistencia = LeerYAsignarBono("Bono Reducción Costos");
        //        gerente.Bonos.BonoAsistencia = LeerYAsignarBono("Bono Satisfacción Cliente");
        //    }
        //    else if (empleado is Director director)
        //    {
        //        Console.WriteLine("Director encontrado: Asignando bonos de director...");
        //        director.Bonos.BonoDesempeñoEmpresa = LeerYAsignarBono("Bono Desempeño Empresa");
        //        director.Bonos.BonoAsistencia = LeerYAsignarBono("Bono Crecimiento Mercado");
        //        director.Bonos.BonoAsistencia = LeerYAsignarBono("Stock Options");
        //    }

        //    Console.WriteLine("Bonos asignados correctamente.");
        //}

        //// Método para desasignar bonos
        //public static void DesasignarBonos(Empleado empleado)
        //{
        //    // Según el tipo de empleado, desasignamos los bonos correspondientes
        //    if (empleado is Empleado)
        //    {
        //        empleado.Bonos.BonoAsistencia = 0;
        //        empleado.Bonos.BonoAsistencia = 0;
        //        empleado.Bonos.BonoAsistencia = 0;
        //    }
        //    else if (empleado is Gerente gerente)
        //    {
        //        gerente.Bonos.BonoAsistencia = 0;
        //        gerente.Bonos.BonoAsistencia = 0;
        //        gerente.Bonos.BonoAsistencia = 0;
        //    }
        //    else if (empleado is Director director)
        //    {
        //        director.Bonos.BonoAsistencia = 0;
        //        director.Bonos.BonoAsistencia = 0;
        //        director.Bonos.BonoAsistencia = 0;
        //    }

        //    Console.WriteLine("Bonos desasignados correctamente.");
        //}


        //// Método auxiliar para leer y asignar un bono
        //private static decimal LeerYAsignarBono(string tipoBono)
        //{
        //    Console.Write($"Ingrese el monto del {tipoBono}:");
        //    return Convert.ToDecimal(Console.ReadLine());
        //}

    }
}
