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
    public class CargaUtilTest
    {

        [Test]
        public void CargarFurgoneta()
        {
            CargaUtil furgoneta = new CargaUtil();
            
            furgoneta.AddCarga("Vieras", 20);

            Assert.AreEqual(1, furgoneta.Carga.Count);
            Assert.AreEqual("Vieras", furgoneta.Carga[0].Key);
            Assert.AreEqual(20, furgoneta.Carga[0].Value);
        }

        [Test]
        public void ElMaximoDeLaFurgonetaEsDe200Kg()
        {
            CargaUtil carga = new CargaUtil();

            try
            {
                carga.AddCarga("Vieras", 201);
                Assert.Fail("Error en la carga");
            }
            catch(ApplicationException ex) // exception personalizada CargaMaximaException
            {
                Assert.AreEqual("Carga máxima sobrepasada, solamente se puede carga 200 kg", ex.Message);
            }
         }
    }
}
