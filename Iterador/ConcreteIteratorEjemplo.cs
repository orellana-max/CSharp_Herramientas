using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterador
{
    class ConcreteIteratorEjemplo : IteratorEjemplo
    {
        private Collection _aggregate;
        private Item _item;

        public ConcreteIteratorEjemplo(Collection _agregado) {
            this._aggregate = _agregado;
            
        }

        public override Item CurrentItem() {
            return this._item;
        }

        public override void First() {
            if (!IsDone())
            {
            this._item = _aggregate.Index(0);
            }
        }

        public override bool IsDone() {
            return this._aggregate.Count() == this._aggregate.Posicion() + 1;
        }

        public override void Netx() {
            this._item = _aggregate.Index(_aggregate.Posicion() + 1);
        }
    }
}
