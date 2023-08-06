using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteradorNico
{
    class ContenedorEnum : IEnumerator
    {
        public int[] arreglo;
        private int pos = -1;

        public ContenedorEnum(int[] pArreglo) {
            this.arreglo = pArreglo;
        }

        public object Current => arreglo[pos];

        public bool MoveNext() {
            pos++;
            if (pos < arreglo.Length)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void Reset() {
            pos = -1;
        }
    }
}

