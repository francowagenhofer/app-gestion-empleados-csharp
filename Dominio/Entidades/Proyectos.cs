﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    namespace Dominio.Entidades
    {
        public class Proyectos
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFin { get; set; }
            public string Descripcion { get; set; }
            public decimal Presupuesto { get; set; }
            public List<Empleado> EmpleadosAsignados { get; set; } = new List<Empleado>();

            public Proyectos(string nombre, DateTime fechaInicio, DateTime fechaFin, string descripcion, decimal presupuesto)
            {
                Nombre = nombre;
                FechaInicio = fechaInicio;
                FechaFin = fechaFin;
                Descripcion = descripcion;
                Presupuesto = presupuesto;
            }


            // estos metodos de asignacion estan bien aca o podrian ir a ProyectosNegocio
            public void AsignarEmpleado(Empleado empleado)
            {
                EmpleadosAsignados.Add(empleado);
            }

            public void DesasignarEmpleado(Empleado empleado)
            {
                EmpleadosAsignados.Remove(empleado);
            }

           
            // que onda estos ultimos dos metodos. pueden ser llamados en la logica de Proyectos? me ayudaria eso

            //public void MostrarInformacion()
            //{
            //    Console.WriteLine($"Nombre: {Nombre}, Fecha de Inicio: {FechaInicio}, Fecha de Fin: {FechaFin}, Descripción: {Descripcion}, Presupuesto: {Presupuesto}");
            //}

            //public void MostrarEmpleadosAsignados() 
            //{
            //    if (EmpleadosAsignados.Count == 0)
            //    {
            //        Console.WriteLine("No hay empleados asignados a este proyecto.");
            //        return;
            //    }

            //    Console.WriteLine("Empleados asignados:");
            //    foreach (var empleado in EmpleadosAsignados)
            //    {
            //        Console.WriteLine($"{empleado.Nombre} {empleado.Apellido}");
            //    }
            //}
        }
    }
}
