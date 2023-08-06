using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7E11
{

    abstract class Expresion
    {
        abstract public double evaluar();
    }

    class Valor : Expresion
    {
        Double valor;

        public Valor(int n) {
            this.valor = n * 1.0;
        }

        public override double evaluar() {
            return valor;
        }
    }

    class Operacion : Expresion
    {
        Expresion exp1;
        Expresion exp2;
        char operacion;


        public Operacion(Expresion valor1, Expresion valor2, char operacion) {
            this.exp1 = valor1;
            this.exp2 = valor2;
            this.operacion = operacion;
        }

        public override double evaluar() {
            double resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = this.exp1.evaluar() + this.exp2.evaluar();
                    break;

                case '-':
                    resultado = this.exp1.evaluar() - this.exp2.evaluar();
                    break;

                case '*':
                    resultado = this.exp1.evaluar() * this.exp2.evaluar();
                    break;

                case '/':
                    if (this.exp2.evaluar() == 0)
                    {
                        Console.WriteLine("Error: Division por cero");
                    } else
                    {
                        resultado = this.exp1.evaluar() / this.exp2.evaluar();
                    }
                    break;
            }
            return resultado;
        }
    }

    class Program
    {
        static void Main(string[] args) {

            Expresion e1, e2, e3, e4, e5, e6, e7;

            e1 = new Operacion(new Valor(2), new Valor(3), '+'); //5
            e2 = new Operacion(e1, new Valor(8), '*'); //40
            e3 = new Operacion(new Valor(4), new Valor(5), '/'); // 0.8
            e4 = new Operacion(e3, new Valor(7), '*'); //5.6
            e5 = new Operacion(e2, e4, '-'); // 40 - 5.6 = 34.4
            e6 = new Operacion(new Valor(3), new Valor(11), '-'); // -8
            e7 = new Operacion(e5, e6, '+'); // 26.4 

            Console.WriteLine(e7.evaluar());

            e1 = new Operacion(new Valor(4), new Valor(2), '-'); // 2
            e2 = new Operacion(new Valor(8), new Valor(10), '/'); //0.8
            e3 = new Operacion(e1, e2, '*'); //1.6
            e4 = new Operacion(new Valor(3), new Valor(2), '+'); // 5
            e5 = new Operacion(e4, e3, '*'); // 5 * 1,6 = 8

            Expresion expresion = new Operacion(e7, e5, '/'); //  26.4 / 8 = 3.3

            //El resultado de evaluar esta expresión es 3.3
            Console.WriteLine(expresion.evaluar());

            Console.ReadLine();

        }
    }
}
