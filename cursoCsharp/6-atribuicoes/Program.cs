using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_atribuicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world. Projeto no Visual Studio!");

            int idade = 32;
            int idadegustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadegustavo);

            Console.WriteLine("a execução acabou.");
            Console.ReadLine();//espera que o usario digite algo
        }
    }
}
