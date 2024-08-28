using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Dominio.ReglasDelNegocio;

namespace Negocio
{
    public class BonosNegocio
    {
        public static void AsignarBonos(Empleado empleado)
        {
            if (empleado is Empleado)
            {
                empleado.BonoAsistencia = Convert.ToDecimal(MetodosAuxiliares.LeerDato("Bono Asistencia"));
                empleado.BonoHorasExtra = Convert.ToDecimal(MetodosAuxiliares.LeerDato("Bono Horas Extra"));
                empleado.BonoDesempeño = Convert.ToDecimal(MetodosAuxiliares.LeerDato("Bono Desempeño"));
            }
            else if (empleado is Gerente gerente)
            {
                gerente.BonoMetaEquipo = Convert.ToDecimal(MetodosAuxiliares.LeerDato("Bono Meta Equipo"));
                gerente.BonoReduccionCostos = Convert.ToDecimal(MetodosAuxiliares.LeerDato("Bono Reducción Costos"));
                gerente.BonoSatisfaccionCliente = Convert.ToDecimal(MetodosAuxiliares.LeerDato("Bono Satisfacción Cliente"));
            }
            else if (empleado is Director director)
            {
                director.BonoDesempeñoEmpresa = Convert.ToDecimal(MetodosAuxiliares.LeerDato("Bono Desempeño Empresa"));
                director.BonoCrecimientoMercado = Convert.ToDecimal(MetodosAuxiliares.LeerDato("Bono Crecimiento Mercado"));
                director.StockOptions = Convert.ToDecimal(MetodosAuxiliares.LeerDato("Stock Options"));
            }

            Console.WriteLine("Bonos asignados correctamente.");
        }

    }
}
