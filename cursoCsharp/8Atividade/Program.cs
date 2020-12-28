using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo");
            Console.WriteLine();
            Console.WriteLine("Tubuada de cadá número");
            Console.WriteLine();

            for (int contadorLinha = 0; contadorLinha <= 100; contadorLinha++)
            {
                if(contadorLinha % 3 == 0)
                {
                    Console.Write("Esse é o numero Primo -->" + contadorLinha);
                } 
                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
