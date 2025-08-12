using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ReglasDelNegocio
{
    public class CategoriaConSalario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }

        public decimal Salario { get; set; }

        public int IdSalario { get; set; }

        public override string ToString() => Nombre;
    }
}
