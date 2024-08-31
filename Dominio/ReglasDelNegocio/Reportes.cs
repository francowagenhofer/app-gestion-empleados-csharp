using Dominio.Entidades.Dominio.Entidades;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ReglasDelNegocio
{
    public class ReporteEmpleado
    {
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public decimal Salario { get; set; }
        public decimal Bonos { get; set; }
    }

    public class ReporteProyecto
    {
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Presupuesto { get; set; }
    }

    public class ReporteFinanzas
    {
        public decimal TotalSalarios { get; set; }
        public decimal TotalBonos { get; set; }
        public decimal TotalPresupuestosProyectos { get; set; }
        public decimal TotalGastos { get; set; }

        //public List<DetalleFinanciero> Detalles { get; set; } = new List<DetalleFinanciero>();

    }

    //public class DetalleFinanciero
    //{
    //    public string Concepto { get; set; }
    //    public decimal Monto { get; set; }
    //}

}
