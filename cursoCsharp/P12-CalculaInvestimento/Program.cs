using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimento
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 12");

            double fatorRenda = 1.0036;
            double valorinvestido = 1000;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorinvestido *= fatorRenda;
                }
                fatorRenda += 0.0010;
            }

            Console.WriteLine("Ao término do investimento, você tera R$" + valorinvestido);

            Console.ReadLine();
        }
    }
}
