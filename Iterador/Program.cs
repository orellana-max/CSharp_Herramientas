using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterador
{
    class Program
    {
        static void Main(string[] args) {

            
            Collection _coleccion = new ConcreteCollection();
            IteratorEjemplo _ite = _coleccion.CreateIterator();

            _ite.First();

            Item _item = _ite.CurrentItem();

            Console.WriteLine("item: "+ _item);

            Console.ReadKey();

        }
    }
}
