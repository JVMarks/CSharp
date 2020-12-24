using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world. Projeto no Visual Studio!");
            int idadedeJoao = 16;
            int quantidadedepessoas = 2;

            if (idadedeJoao >= 18)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                if (quantidadedepessoas >= 2)
                {
                    Console.WriteLine("João está acompanhado pode entrar");
                }
                else
                {
                    Console.WriteLine("VAI EMBORA");
                }

                Console.WriteLine("VAZA!");
            }


            Console.WriteLine("a execução acabou.");
            Console.ReadLine();//espera que o usario digite algo
        }
    }
}
