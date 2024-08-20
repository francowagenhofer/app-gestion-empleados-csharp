using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Director: Empleado, IEmpleado
    {
        public decimal BonoDesempenoEmpresa { get; set; }
        public decimal BonoCrecimientoMercado { get; set; }
        public decimal StockOptions { get; set; } // para que es? -> tipos de acciones de una empresa


        public decimal CalcularBonosDirector(bool desempeñoAlto, bool crecimientoMercadoAlto)
        {
            if (desempeñoAlto)
                BonoDesempenoEmpresa = 10000; 
            
            if (crecimientoMercadoAlto) BonoCrecimientoMercado = 7000;
            
            StockOptions = 15000; // Ejemplo de asignación fija para StockOptions

            return CalcularSalario();
        }

        public override decimal CalcularSalario()
        {
            return base.CalcularSalario() + BonoDesempenoEmpresa + BonoCrecimientoMercado + StockOptions;
        }


        public override void MostrarInformacion() 
        {
            base.MostrarInformacion();
            Console.WriteLine($"Stock Options: {StockOptions}");
        }
    }
}