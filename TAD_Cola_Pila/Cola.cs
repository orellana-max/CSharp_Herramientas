using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD_Cola_Pila
{
    public class Cola

    {
        private ArrayList lista;

        public Cola() {
            this.lista = new ArrayList();
        }

        public void push(Object obj) {
            lista.Add(obj);
        }

        public Object pop() {
            Object o = lista[0];
            lista.RemoveAt(0);
            return o;
        }

        public Object top() {
            return lista[0];
        }

        public bool isEmpty() {
            return lista.Count == 0;
        }
    }
}
