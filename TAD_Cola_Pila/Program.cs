using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD_Cola_Pila
{
    class Program
    {
        static void Main(string[] args) {

			Console.WriteLine("\n################ NUMERO COMPLEJO ###############\n");

			Console.WriteLine("nc1: " + new NumeroComplejo(-3, 0));
			Console.WriteLine("nc2: " +new NumeroComplejo(-6, 2));
			Console.WriteLine("nc3: " +new NumeroComplejo(-6, -2));
			Console.WriteLine("nc4: " +new NumeroComplejo(0, 2));
			Console.WriteLine("nc5: " +new NumeroComplejo(0, -2));
			Console.WriteLine("nc6: " +new NumeroComplejo(0, 0));
			Console.WriteLine("nc7: " +new NumeroComplejo(1, 2));
			Console.WriteLine("nc8: " +new NumeroComplejo(1, -2));
			Console.WriteLine("nc9: " +new NumeroComplejo(1, 0));
			


			Console.WriteLine("\n\n");
			Console.WriteLine(NumeroComplejo.Parse("-4-3i"));
			Console.WriteLine(NumeroComplejo.Parse("4-3i"));
			Console.WriteLine(NumeroComplejo.Parse("4+3i"));
			Console.WriteLine(NumeroComplejo.Parse("0-0i"));
			Console.WriteLine(NumeroComplejo.Parse("0+0i"));










			Console.WriteLine("\n################ PILA ############333\n");
			Pila c = new Pila();
			c.push(3);
			c.push("Hola Mundo");
			c.push(4);
			c.push(true);

			Pila p;
			p = reemplazo(c, 4, 5);

			while (!p.isEmpty())
			{
				Console.WriteLine(p.pop());
			}
			
			Console.ReadKey();

		}

		public static Pila reemplazo(Pila pila, int buscar, int reemplazar) {
			Pila temporal = new Pila();
			while (!pila.isEmpty())
			{
				if (pila.top().Equals(buscar))
				{
					pila.pop();
					temporal.push(reemplazar);
				} else
				{
					temporal.push(pila.pop());
				}
			}
			Pila nueva = new Pila();
			while (!temporal.isEmpty())
			{
				nueva.push(temporal.pop());
			}
			return nueva;
		}
	}
}
