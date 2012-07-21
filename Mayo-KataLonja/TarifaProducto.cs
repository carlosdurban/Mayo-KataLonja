using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mayo_KataLonja
{
    public class TarifaProducto
    {
        public string Nombre { get; private set; }
        public int Precio { get; private set; }

        public TarifaProducto(string nombre, int precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }

        
    }
}
