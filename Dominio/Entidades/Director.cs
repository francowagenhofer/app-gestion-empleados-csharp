using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Director : Empleado, IEmpleado
    {
        public Director() : base(false) { } // No es Empleado Operativo

        public override decimal CalcularSalario()
        {
            // Llama al método específico de la clase Bonos para calcular bonos de director
            return base.CalcularSalario() + Bonos.CalcularBonosDirector(true, true); 
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Stock Options: {Bonos.StockOptions}");
        }

    }
}