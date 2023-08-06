using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD_Cola_Pila
{
    class NumeroComplejo
    {
        private double real;
        private double imaginaria;

        public NumeroComplejo(double real, double imaginaria) {
            this.real = real;
            this.imaginaria = imaginaria;
        }

        public double parteReal
        {
            get { return real; }
        }

        public double parteImaginaria
        {
            get { return imaginaria; }
        }

        public NumeroComplejo sumar(NumeroComplejo nc) {
            return new NumeroComplejo(this.real + nc.parteReal,
            this.imaginaria + nc.parteImaginaria);
        }

        public NumeroComplejo restar(NumeroComplejo nc) {
            return new NumeroComplejo(this.real - nc.parteReal,
            this.imaginaria - nc.parteImaginaria);
        }


        public override string ToString() {
            if (real == 0 && imaginaria == 0)
            {
                return "0";
            } else
            {
                string StReal, StImg, signo;
                StReal = real == 0 ? "" : this.real.ToString();
                signo = imaginaria > 0 ? "+" : "";
                StImg = imaginaria == 0 ? "" : this.imaginaria.ToString() + "i";

                return (StReal + (real == 0 ? "" : signo) + StImg);
            }
        }

        public bool Equals(NumeroComplejo nc) {

            return (this.real == nc.parteReal && this.imaginaria == nc.parteImaginaria);
        }

        public static NumeroComplejo Parse(String nc) { //x+-yi
            nc = nc.Remove(nc.Length -1, 1);
            Double pReal, pImg;
            bool RealNegativo = nc[0] == '-';
            if (RealNegativo) { nc = nc.Substring(1); }
            
            string[] partes = nc.Split(new char[] { '-', '+' });

            pReal = Double.Parse(partes[0]);
            if (RealNegativo) { pReal *= -1; }
            
            pImg = Double.Parse(partes[1]);
            if (nc.IndexOf('+') < 0) { pImg *= -1; }

            NumeroComplejo ncomplejo = new NumeroComplejo(pReal, pImg);

            return ncomplejo;
        }
        
            
        public static NumeroComplejo i() {
            return new NumeroComplejo(0, 1);
        }





    }
}
