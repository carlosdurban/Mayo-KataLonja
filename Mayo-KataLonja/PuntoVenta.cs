using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mayo_KataLonja
{
    public class PuntoVenta
    {

        public string NombrePuntoVenta { get; private set; }

        public int Distancia { get; private set; }

        public List<TarifaProducto> Tarifas { get; private set; }

        public PuntoVenta(string nombrePuntoVenta, int distancia)
        {
            Tarifas = new List<TarifaProducto>();
            this.NombrePuntoVenta = nombrePuntoVenta;
            this.Distancia = distancia;
        }

        public void AddTarifa(TarifaProducto tarifa)
        {
            Tarifas.Add(tarifa);
        }

    
        public int ObtenerBeneficioCarga(CargaUtil carga)
        {
            int Beneficio = 0;
            
            foreach(var c in carga.Carga)
                Beneficio += Tarifas.Single(x => x.Nombre == c.Key).Precio * c.Value;
            return Beneficio;
        }
    }
}
