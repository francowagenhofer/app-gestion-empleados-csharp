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
        public override decimal CalcularSalario()
        {
            // Llama al método específico de la clase Bonos para calcular bonos de gerente
            return base.CalcularSalario() + Bonos.CalcularBonosGerente(true, true, true);
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Bono Meta Equipo: {Bonos.BonoMetaEquipo}");
            Console.WriteLine($"Bono Reducción Costos: {Bonos.BonoReduccionCostos}");
            Console.WriteLine($"Bono Satisfacción Cliente: {Bonos.BonoSatisfaccionCliente}");
            Console.WriteLine($"Salario final Gerente: {CalcularSalario}");
        }


    }
}
