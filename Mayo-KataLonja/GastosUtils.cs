using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mayo_KataLonja
{
    public class GastosUtils
    {
        protected const int GastosXKm = 2;
        protected const int GastosXCargarFurgoneta = 5;

        public static int ObtenerGastoTransporte(PuntoVenta puntoVenta)
        {
            return (puntoVenta.Distancia * GastosXKm) + GastosXCargarFurgoneta;
        }

        public static int ObtenerGastoDepreciacion(int ValorDeCarga, PuntoVenta Madrid)
        {
            int PorcetajeAplicar = Madrid.Distancia / 100;

            int GastosDepreciacion = (PorcetajeAplicar * ValorDeCarga) / 100;

            return GastosDepreciacion;   
        }
    }
}
