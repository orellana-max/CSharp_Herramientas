using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterador
{
    class PalabraIterador : IEnumerator
    {
        private char[] pal;
        private int pos;

        public PalabraIterador(String pal) {
            this.pal = pal.ToCharArray();
            this.pos = -1;
        }

        public object Current => pal[pos];

        public bool MoveNext() {
            if(pos < pal.Length - 1)
            {
                pos++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset() {
            pos = -1;
        }
    }
}
