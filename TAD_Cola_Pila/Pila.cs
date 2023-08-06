using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD_Cola_Pila
{
    public class Pila
    {
        private ArrayList lista;

        public Pila() {
            this.lista = new ArrayList();
        }

        public void push(Object obj) {
            lista.Add(obj);
        }

        public Object pop() {
            Object o = lista[lista.Count - 1];
            lista.RemoveAt(lista.Count - 1);
            return o;
        } 

        public Object top() {
            return lista[lista.Count - 1];
        }

        public bool isEmpty() {
            return lista.Count == 0;
        }
    }
}
