using Dominio.Interfaces;
using Dominio.ReglasDelNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Empleado : IEmpleado 
    {  
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string DNI { get; set; }

        public string Imagen { get; set; }

        public int Categoria { get; set; }
     
        public DateTime FechaIngreso { get; set; }

        public decimal SalarioBase { get; set; }

        public Bonos Bonos { get; set; }

        public bool IsActive { get; set; }


        //// Método para validar DNI
        //public static bool ValidarDNI(string dni)
        //{
        //    // Aquí debes llamar a la capa de negocio o de datos
        //    EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
        //    return empleadoNegocio.ValidarDNI(dni);
        //}


        public virtual decimal CalcularBonos()
        {
            return Bonos.CalcularBonos();
        }

        public virtual decimal CalcularSalario()
        {
            return SalarioBase + CalcularBonos();
        }


        public int CalcularAntiguedad() // esto se puede usar en reportes ...
        {
            return (DateTime.Now - FechaIngreso).Days / 365;
        }

        public virtual void MostrarInformacion()  // esto se puede mostrar en reportes ...
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}, Edad: {FechaNacimiento}, Salario Base: {SalarioBase}");

        }

    }
}
