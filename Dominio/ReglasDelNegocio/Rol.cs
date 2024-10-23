using Dominio.Entidades.Dominio.Entidades;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ReglasDelNegocio
{
    public class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public List<Proyectos> ProyectosAsignados { get; set; } = new List<Proyectos>();
        public List<Empleado> EmpleadosAsignados { get; set; } = new List<Empleado>();

    }

}
