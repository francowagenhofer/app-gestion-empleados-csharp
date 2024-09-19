using System;
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
            public string Descripcion { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFin { get; set; }
            public decimal Presupuesto { get; set; }
            public string EstadoProyecto { get; set; } // esta propiedad es dudosa .. tendria que estar conectada a otra tabla que contenga las opciones de los estados posibles...
            public bool IsActive { get; set; }

            public List<Empleado> EmpleadosAsignados { get; set; } = new List<Empleado>();

        }
    }
}
