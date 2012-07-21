using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mayo_KataLonja
{
    public class Lonja
    {
        protected List<PuntoVenta> PuntosDeVenta { get; set; }
        protected CargaUtil Carga { get; set; }

        public Lonja(CargaUtil carga, List<PuntoVenta> puntosDeVenta)
        {
            PuntosDeVenta = puntosDeVenta;
            Carga = carga;
        }
           

        public PuntoVenta ObtenerPuntoVentaConMayorBeneficio()
        {
            List<KeyValuePair<int, PuntoVenta>> PVentas = new  List<KeyValuePair<int, PuntoVenta>>();

            foreach (PuntoVenta PuntoVenta in PuntosDeVenta)
            {

                int ValorDeCarga = PuntoVenta.ObtenerBeneficioCarga(Carga);
                int GastosTransporte = GastosUtils.ObtenerGastoTransporte(PuntoVenta);
                int GastosDepreciacion = GastosUtils.ObtenerGastoDepreciacion(ValorDeCarga, PuntoVenta);

                int BeneficioTotal = ValorDeCarga - (GastosDepreciacion + GastosTransporte);

                PVentas.Add(new KeyValuePair<int, PuntoVenta>(BeneficioTotal, PuntoVenta));

            }

            return (from p in PVentas
                    where (p.Key == (PVentas.Max(p1 => p1.Key)))
                    select p).Single().Value;
        
        }
    }
}
