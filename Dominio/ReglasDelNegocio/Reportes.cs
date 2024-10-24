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
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string Categoria { get; set; }
        public decimal SalarioActual { get; set; }
        public decimal TotalBonos { get; set; }
        public string ProyectosAsignados { get; set; }
        public string RolesAsignados { get; set; }
        public string TareasAsignadas { get; set; }
        public DateTime FechaGeneracion { get; set; }
    }

    public class ReporteProyecto
    {
        public int Id { get; set; }
        public int IdProyecto { get; set; }
        public string NombreProyecto { get; set; }
        public decimal Presupuesto { get; set; }
        public string EstadoProyecto { get; set; }
        public string AsignacionesEmpleados { get; set; }
        public string TareasAsignadas { get; set; }
        public string RolesAsignados { get; set; }
        public decimal TiempoEstimado { get; set; }
        public DateTime FechaGeneracion { get; set; }
    }

    public class ReporteFinanzas
    {
        public int Id { get; set; }
        public decimal TotalSalarios { get; set; }
        public decimal TotalBonos { get; set; }
        public decimal TotalPresupuestosProyectos { get; set; }
        public decimal TotalGastos { get; set; }
        public DateTime FechaGeneracion { get; set; }
    }
}
