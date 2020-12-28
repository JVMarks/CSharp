using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_Lacoderepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;

            for(int contador = 1; contador <= 12; contador++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após" + contador + "mês, você terá --->" + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
