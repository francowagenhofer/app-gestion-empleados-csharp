using Dominio.Interfaces;
using Dominio.ReglasDelNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Empleado : IEmpleado 
    {  
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Edad { get; set; } // tendria que eliminar este

        public DateTime FechaNacimiento { get; set; }

        public int DNI { get; set; }

        // [DisplayName("foto de perfil ...")] con esto se cambia el nombre
        public string Imagen { get; set; }

        public int Categoria { get; set; }
     
        public DateTime FechaIngreso { get; set; }

        public decimal SalarioBase { get; set; }

        public Bonos Bonos { get; set; }

        //public Empleado(bool esOperativo) // esto importa? es decir la base de datos lo registra en base a la propiedad categoria 
        //{
        //    EsOperativo = esOperativo;
        //    Bonos = new Bonos();  // Instancia de la clase Bonos 
        //}

        public bool IsActive { get; set; }



        public virtual decimal CalcularBonos()
        {
            return Bonos.CalcularBonos();
        }

        public virtual decimal CalcularSalario()
        {
            return SalarioBase + CalcularBonos();
        }


        public static int ContarEmpleados(List<Empleado> lista) => lista.Count; // esto se puede usar en reportes ...


        public int CalcularAntiguedad() // esto se puede usar en reportes ...
        {
            return (DateTime.Now - FechaIngreso).Days / 365;
        }

        public virtual void MostrarInformacion()  // esto se puede mostrar en reportes ...
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}, Edad: {Edad} {FechaNacimiento}, Salario Base: {SalarioBase}");

        }

    }
}
