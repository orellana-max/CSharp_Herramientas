using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterador
{
    class Palabra : IEnumerable
    {
        private String pal;

        public Palabra(string pal) {
            this.pal = pal;
        }

        public IEnumerator GetEnumerator() {
            return new PalabraIterador(pal);
        }
    }
}
