using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterador
{
    public class Item
    {
        private String nombre;

        public Item(string nombre) {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString() {
            return base.ToString()+" "+Nombre;
        }
    }
}
