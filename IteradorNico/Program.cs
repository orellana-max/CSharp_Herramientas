using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteradorNico
{
    class Program
    {
        static void Main(string[] args) {

            CContenedora datos = new CContenedora();

            foreach (var item in datos)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
