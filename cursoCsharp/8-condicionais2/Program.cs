using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world. Projeto no Visual Studio!");
            int idadedeJoao = 16;
            int quantidadedepessoas = 2;
            bool acompanhado = quantidadedepessoas >= 2;

            if (idadedeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("VAZA!");
            }

            Console.WriteLine("a execução acabou.");
            Console.ReadLine();//espera que o usario digite algo
        }
    }
}

