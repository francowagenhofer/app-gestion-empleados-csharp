using Dominio.ReglasDelNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Empleado 
    {  
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string DNI { get; set; }

        public string Imagen { get; set; }

        public DateTime FechaIngreso { get; set; }
     
        public int Categoria { get; set; } // Id de la categoría
     
        public string NombreCategoria { get; set; } // Nombre de la categoría
        
        public int Salario { get; set; } // Id del salario
        
        public decimal MontoSalario { get; set; } // Monto del salario

        public bool IsActive { get; set; }


    }
}
