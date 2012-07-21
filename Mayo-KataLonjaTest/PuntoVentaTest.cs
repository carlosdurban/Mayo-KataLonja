using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;
using Mayo_KataLonja;


namespace Mayo_KataLonjaTest
{
    [TestFixture]
    public class PuntoVentaTest
    {
        PuntoVenta Madrid;
        PuntoVenta Barcelona;
        PuntoVenta Lisboa;

        [SetUp]
        public void Init()
        {
            Madrid = new PuntoVenta("Madrid",800);
            Madrid.AddTarifa(new TarifaProducto("Vieras", 500));
            Madrid.AddTarifa(new TarifaProducto("Pulpo", 0));
            Madrid.AddTarifa(new TarifaProducto("Centollos", 450));

            Barcelona = new PuntoVenta("Barcelona",1100);
            Barcelona.AddTarifa(new TarifaProducto("Vieras ", 450));
            Barcelona.AddTarifa(new TarifaProducto("Pulpo", 120));
            Barcelona.AddTarifa(new TarifaProducto("Centollos", 0));

            Lisboa = new PuntoVenta("Lisboa", 600);
            Lisboa.AddTarifa(new TarifaProducto("Vieras", 600));
            Lisboa.AddTarifa(new TarifaProducto("Pulpo", 100));
            Lisboa.AddTarifa(new TarifaProducto("Centollos", 500));
        }

        [Test]
        public void EstablecerNombreAlmercado()
        {
            Assert.AreEqual("Madrid", Madrid.NombrePuntoVenta);
        }

        [Test]
        public void AddTarifasAlMercado()
        {   
            Assert.AreEqual(3, Madrid.Tarifas.Count);
        }


        [Test]
        public void ObtenerBeneficioDeMercado()
        {
            CargaUtil carga = new CargaUtil();
            carga.AddCarga("Vieras", 50);
            carga.AddCarga("Pulpo", 100);
            carga.AddCarga("Centollos", 50);

            int BeneficioMadrid = Madrid.ObtenerBeneficioCarga(carga);

            Assert.AreEqual(47500,BeneficioMadrid);

        }

       
    }
}
