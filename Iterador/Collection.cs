using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterador
{
    public abstract class Collection
    {
        public abstract IteratorEjemplo CreateIterator();
        public abstract void Agregar(Item _item);
        public abstract Item Index(int _idx);
        public abstract int Count();
        public abstract int Posicion();


    }
}
