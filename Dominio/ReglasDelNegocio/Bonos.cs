using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ReglasDelNegocio
{
    public class Bonos
    {
        // Propiedades de bonos específicas para distintos cargos
    
        // propiedades de bonos para empleados operativos
        public decimal BonoAsistencia { get; set; }
        public decimal BonoHorasExtra { get; set; }
        public decimal BonoDesempeño { get; set; }

        // propiedades de bonos para gerentes
        public decimal BonoMetaEquipo { get; set; }
        public decimal BonoReduccionCostos { get; set; }
        public decimal BonoSatisfaccionCliente { get; set; }
        
        // propiedades de bonos para Director/es
        public decimal BonoDesempeñoEmpresa { get; set; }
        public decimal BonoCrecimientoMercado { get; set; }
        public decimal StockOptions { get; set; }

        public decimal CalcularBonos()
        {
            return BonoAsistencia + BonoHorasExtra + BonoDesempeño + BonoMetaEquipo + BonoReduccionCostos + BonoSatisfaccionCliente + BonoDesempeñoEmpresa + BonoCrecimientoMercado + StockOptions;
        }

        public decimal CalcularBonosGerente(bool metaAlcanzada, bool costosReducidos, bool satisfaccionClienteAlta)
        {
            if (metaAlcanzada) BonoMetaEquipo = 5000;
            if (costosReducidos) BonoReduccionCostos = 3000;
            if (satisfaccionClienteAlta) BonoSatisfaccionCliente = 2000;

            return CalcularBonos();
        }

        public decimal CalcularBonosDirector(bool desempeñoAlto, bool crecimientoMercadoAlto)
        {
            if (desempeñoAlto) BonoDesempeñoEmpresa = 10000;
            if (crecimientoMercadoAlto) BonoCrecimientoMercado = 7000;
            StockOptions = 15000;

            return CalcularBonos();
        }
    
    
    }
}
