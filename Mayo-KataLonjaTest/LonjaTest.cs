using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mayo_KataLonja;
using NUnit;
using NUnit.Framework;

namespace Mayo_KataLonjaTest
{
    [TestFixture]
    public class LonjaTest
    {
        PuntoVenta Madrid;
        PuntoVenta Barcelona;
        PuntoVenta Lisboa;

        [SetUp]
        public void Init()
        {
            Madrid = new PuntoVenta("Madrid", 800);
            Madrid.AddTarifa(new TarifaProducto("Vieras", 500));
            Madrid.AddTarifa(new TarifaProducto("Pulpo", 0));
            Madrid.AddTarifa(new TarifaProducto("Centollos", 450));

            Barcelona = new PuntoVenta("Barcelona", 1100);
            Barcelona.AddTarifa(new TarifaProducto("Vieras", 450));
            Barcelona.AddTarifa(new TarifaProducto("Pulpo", 120));
            Barcelona.AddTarifa(new TarifaProducto("Centollos", 0));

            Lisboa = new PuntoVenta("Lisboa", 600);
            Lisboa.AddTarifa(new TarifaProducto("Vieras", 600));
            Lisboa.AddTarifa(new TarifaProducto("Pulpo", 100));
            Lisboa.AddTarifa(new TarifaProducto("Centollos", 500));
        }

        [Test]
        public void ObtenerPuntoVentaConMayorBeneficio()
        {
            
            List<PuntoVenta> PuntosDeVenta = new List<PuntoVenta>();
            PuntosDeVenta.Add(Madrid);
            PuntosDeVenta.Add(Barcelona);
            PuntosDeVenta.Add(Lisboa);

            CargaUtil carga = new CargaUtil();
            carga.AddCarga("Vieras", 50);
            carga.AddCarga("Pulpo", 100);
            carga.AddCarga("Centollos", 50);

            PuntoVenta PuntoVenta = new Lonja(carga, PuntosDeVenta).ObtenerPuntoVentaConMayorBeneficio();

            Assert.AreEqual("Lisboa", PuntoVenta.NombrePuntoVenta);
            

            //Gastos Madrid
            // Beneficios : 47500
            // Gastos Transporte: 800 km x 2 = 1600 € + 5 cargar furgoneta = 1605 €
            // Gastos Depreciacion: 8% de Beneficios (47500) = 3800 €
            // Beneficios Totales: 47500 + (1605 - 3800) = 42095 €

            //Gastos Barcelona
            // Beneficios : 34500
            // Gastos Transporte: 1100 km x 2 = 2200 € + 5 cargar furgoneta = 2205 €
            // Gastos Depreciacion: 11% de Beneficios (34500) = 3795 €
            // Beneficios Totales: 34500 + (2205 - 3795) =  32910€

            //Gastos Lisboa
            // Beneficios : 65000 €
            // Gastos Transporte: 600 km x 2 = 1200 € + 5 cargar furgoneta = 1205 €
            // Gastos Depreciacion: 6% de Beneficios (65000) = 3900 €
            // Beneficios Totales: 65000 + (1205 - 3900) =  59895€



        }
    }
}
