using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Calculapolpanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;

            int contador = 1;

            while (contador <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após"+ contador + "mês, você terá --->" + valorInvestido);

                //contador = contador + 1; 
                //contador += 1;
                contador++;
            }

            Console.ReadLine();
        }
    }
}
