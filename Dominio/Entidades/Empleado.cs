using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Empleado : IEmpleado 
    {
        // se podra poner una propiedade de que sea de la fecha de ingreso del empleado? 
        // se podria poner otra propiedad que sea de imagen 

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Edad { get; set; }

        public bool EsOperativo { get; set; }
     
        public Empleado(bool esOperativo)
        {
            EsOperativo = esOperativo;
        }

        public decimal SalarioBase { get; set; }

        public decimal BonoAsistencia { get; set; }

        public decimal BonoHorasExtra { get; set; }

        public decimal BonoDesempeño { get; set; }


        public virtual decimal CalcularBonos()
        {
            return BonoAsistencia + BonoHorasExtra + BonoDesempeño;
        }

        public virtual decimal CalcularSalario()
        {
            return SalarioBase + CalcularBonos();
        }

        public static int ContarEmpleador(List<Empleado> lista)
        {
            return lista.Count;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}, Edad: {Edad}, Salario Base: {SalarioBase}");

        }

    }
}
