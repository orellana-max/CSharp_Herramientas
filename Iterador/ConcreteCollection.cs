using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterador
{
    public class ConcreteCollection : Collection
    {
        private List<Item> _listaItems = new List<Item>();
        private Item _item;
        private int _posicion = -1;


        public override IteratorEjemplo CreateIterator() {
            return new ConcreteIteratorEjemplo(this);
        }
        public override void Agregar(Item _item) {
            this._listaItems.Add(_item);
        }
        public override Item Index(int _idx) {
            this._item = this._listaItems[_idx];
            this._posicion = _idx;
            return this._item;
        }
        public override int Count() {
            return this._listaItems.Count();
        }
        public override int Posicion() {
            return this._posicion;
        }
    }
}
