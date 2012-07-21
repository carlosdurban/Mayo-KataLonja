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
    public class GastosUtilsTest
    {
        [Test]
        public void CalcularGastosXKmRecorrido()
        {
            PuntoVenta Madrid = new PuntoVenta("Madrid", 800);
            Madrid.AddTarifa(new TarifaProducto("Vieras", 500));
            Madrid.AddTarifa(new TarifaProducto("Pulpo", 0));
            Madrid.AddTarifa(new TarifaProducto("Centollos", 450));

            var GastosTransporte = GastosUtils.ObtenerGastoTransporte(Madrid);

            Assert.AreEqual(1605, GastosTransporte);

        }

        [Test]
        public void CalcularDepreciacionX100KmRecorroridos()
        {
            PuntoVenta Madrid = new PuntoVenta("Madrid", 500);

            int ValorDeCarga = 1000;

            var GastosDepreciacion = GastosUtils.ObtenerGastoDepreciacion(ValorDeCarga,Madrid);

            Assert.AreEqual(50, GastosDepreciacion);
        }
    }
}
