using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {

            static bool par(int numero)
            {
                int resto = numero % 2;
                if (resto == 0)
                    return true;
                else
                    return false;
            }

            static string Par2(int numero)
            {
                int resto = numero % 2;
                if (resto == 0)
                    return "Par";
                else
                    return "Impar";

            }

            static int Maior2(int a, int b)
            {
                return (a > b) ? a : b;
            }

            static void Main(string[] args)
            {
                Console.WriteLine(Maior2(1, 2));
                Console.WriteLine(Maior2(4, 5));
                Console.ReadKey();

            }

            class IMC
        {
            private double peso;
            private double altura;

            public IMC()
            {
                this.peso = 0,0;
                this.altura = 0,0;
            }

            public IMC(double peso , double altura)
            {

                this.peso = peso;
                this.altura = altura;
            }

            public double Calcular(double peso, double altura)
            {

                return peso / (altura * altura);
            }

            public double Clasificar(double imc)
            {
                return 0,0;
            }

        }
        }
    }
}
