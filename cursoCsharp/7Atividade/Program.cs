using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo");
            Console.WriteLine();
            Console.WriteLine("Tubuada de cadá número");
            Console.WriteLine();

            for (int contadorLinha = 1; contadorLinha <= 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= 10; contadorColuna++)
                {
                    Console.WriteLine(contadorLinha + " * " + contadorColuna + " = " + contadorLinha * contadorColuna);
                    Console.WriteLine();
                }
                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
