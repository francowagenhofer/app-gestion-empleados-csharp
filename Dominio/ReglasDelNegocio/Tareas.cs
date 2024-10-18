using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ReglasDelNegocio
{
    public class Tareas
    {
        public int Id { get; set; }
        
        public int IdProyecto { get; set; }

        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public string Estado { get; set; } 

    }
}
