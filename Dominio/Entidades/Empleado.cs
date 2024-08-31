using Dominio.Interfaces;
using Dominio.ReglasDelNegocio;
using System;
using System.Collections.Generic;
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

        public int Edad { get; set; }

        public string Imagen { get; set; }

        public string Categoria { get; set; }

        public bool EsOperativo { get; set; }
     
        public DateTime FechaIngreso { get; set; }

        public decimal SalarioBase { get; set; }

        public Bonos Bonos { get; set; }

        public Empleado(bool esOperativo)
        {
            EsOperativo = esOperativo;
            Bonos = new Bonos();  // Instancia de la clase Bonos 
        }

        public virtual decimal CalcularBonos()
        {
            return Bonos.CalcularBonos();
        }

        public virtual decimal CalcularSalario()
        {
            return SalarioBase + CalcularBonos();
        }


        public static int ContarEmpleados(List<Empleado> lista) => lista.Count;


        public int CalcularAntiguedad()
        {
            return (DateTime.Now - FechaIngreso).Days / 365;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}, Edad: {Edad}, Salario Base: {SalarioBase}");

        }

    }
}
