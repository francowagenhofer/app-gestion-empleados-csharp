using Dominio.Entidades.Dominio.Entidades;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Dominio.ReglasDelNegocio
{
    public class Tareas
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }

        public DateTime ?FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public string Estado { get; set; }

        public List<Proyectos> ProyectosAsignados { get; set; }
        public List<Empleado> EmpleadosAsignados { get; set; }

        public int IdTareaProyecto { get; set; }        
        public DateTime? FechaAsignacion { get; set; }    

    }

}
