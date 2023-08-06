using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine(sumar(5));
            Console.WriteLine(invertir("RECURSION"));

            Console.Write("\nARRAY DE NUMEROS:\t[ ");
            int[] arr = new int[] { 5, 6, 8, 2, 1 };
            foreach (var item in arr)
                Console.Write(item.ToString() + " ");
            Console.WriteLine("]");

            int sum = sumaArray(arr);
            Console.WriteLine("\nSUMA NUMEROS DEL ARRAY: {0}", sum);

            int max = maxArray(arr);
            Console.WriteLine("\nMAXIMO VALOR DEL ARRAY: {0}", max);

            double pro = promArray(arr, arr.Length);
            Console.WriteLine("\nPROMEDIO DE VALORES DEL ARRAY: {0}", pro);


            Console.ReadKey();
        }
        static int sumar(int n) {
            if (n == 1)
                return 1;
            else
                return n + sumar(n - 1);
        }
        static string invertir(string palabra) {
            if (palabra.Length == 1)
                return palabra;
            else {
                char inv = palabra[0];
                string resto = palabra.Substring(1);
                return invertir(resto) + inv;
            }
        }


        /*
         * 6) Escriba una función recursiva que reciba un arreglo de números y devuelva la suma de los mismos.
         */
        static int sumaArray(int[] array) {
            int num = array[0];

            if (array.Length == 1)
                return num;
            else {
                int[] aux = new int[array.Length - 1];
                Array.ConstrainedCopy(array, 1, aux, 0, array.Length - 1);
                return sumaArray(aux) + num;
            }
        }

        /*7) Escriba una función recursiva que reciba un arreglo de números y devuelva el valor máximo. */
        static int maxArray(int[] array) {

            if (array.Length == 1)
                return array[0];
            else {
                int[] aux = new int[array.Length - 1];
                Array.ConstrainedCopy(array, 1, aux, 0, array.Length - 1);
                if (maxArray(aux) >= array[0]) {
                    return maxArray(aux);
                } else {
                    return array[0];
                }
            }
        }
        /* 8) Escriba una función recursiva que reciba un arreglo de números y devuelva el promedio de los mismos. */
        static double promArray(int[] array, int tamanio) {
            double num = (double)array[0] / tamanio;
            if (array.Length == 1)
                return num;
            else {
                int[] aux = new int[array.Length - 1];
                Array.ConstrainedCopy(array, 1, aux, 0, array.Length - 1);
                return promArray(aux, tamanio) + num;
            }
        }

        /*  9) Escriba una función recursiva que reciba un string como parámetro y devuelva si es o no palíndromo. */
        public static bool EsPalindromo(String cadena) {
            bool bandera 
            return (EsPalindromo(cadena.Substring(1, cadena.Length - 2)) && bandera );
        }

    }
}
