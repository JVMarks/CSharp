using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13Consoleconta
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contadorLinha = 0; contadorLinha <= 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            //forma diferente
            for (int contadorLinha = 0; contadorLinha <= 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < contadorLinha; contadorColuna++)
                    Console.Write("*");

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
