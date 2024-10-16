using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ReglasDelNegocio
{
    public class Salarios
    {
        public int Id { get; set; }  
       
        public decimal Monto { get; set; }
        
        public int IdCategoria { get; set; } 

        public string NombreCategoria { get; set; }
    }
}