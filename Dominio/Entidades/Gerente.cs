using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Gerente : Empleado, IEmpleado
    {
        // Llama al constructor base con el valor predeterminado 
        public Gerente() : base(false) { } // no es Empleado Operativo

        public decimal BonoMetaEquipo { get; set; }

        public decimal BonoReduccionCostos { get; set; }

        public decimal BonoSatisfaccionCliente { get; set; }

        public decimal CalcularBonosGerente(bool metaAlcanzada, bool costosReducidos, bool satisfaccionClienteAlta)
        {
            if (metaAlcanzada) 
                BonoMetaEquipo = 5000; 
            
            if (costosReducidos)
                BonoReduccionCostos = 3000; 
            
            if (satisfaccionClienteAlta)
                BonoSatisfaccionCliente = 2000; 

            return CalcularSalario();
        }

        public override decimal CalcularSalario()
        {
            return base.CalcularSalario() + BonoMetaEquipo + BonoReduccionCostos + BonoSatisfaccionCliente;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Bono: {CalcularBonosGerente}");
            Console.WriteLine($"Salario final: {CalcularSalario}");
        }

    }
}
