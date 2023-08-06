using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterador
{
    public abstract class IteratorEjemplo
    {
        public abstract void First(); //Volver desde el principio
        public abstract void Netx(); // recorrer uno a uno
        public abstract Item CurrentItem(); // saber item actual
        public abstract bool IsDone(); // saber si es el final de la iteracion

    }
}
