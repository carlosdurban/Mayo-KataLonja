using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mayo_KataLonja
{
    public class CargaUtil
    {
        public List<KeyValuePair<string, int>> Carga { get; private set; }

        protected  const int MaximosKilos = 200;

        public CargaUtil()
        {
            Carga =  new List<KeyValuePair<string, int>>();
        }

        public void AddCarga(string producto, int kilos)
        {
            if (LimiteDePesoAlcanzado(kilos))
                 throw new ApplicationException("Carga máxima sobrepasada, solamente se puede carga 200 kg");


            Carga.Add(new KeyValuePair<string, int>(producto, kilos));
        }

        private bool LimiteDePesoAlcanzado(int kilos)
        {
            return Carga.Sum(x => x.Value) + kilos > MaximosKilos;
        }
    }
}
