using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo");

            int contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine("Ola mundo!");
                contador++;
            }
            Console.WriteLine();

            for (int contadorr = 0; contadorr <= 10; contadorr++)
            {
                Console.WriteLine("Hello it is me!");
            }
            Console.WriteLine();

            for (int contadorLinha = 0; contadorLinha <= 5; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 5; contadorColuna++)
                {
                    Console.Write(contadorColuna + 1);
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
