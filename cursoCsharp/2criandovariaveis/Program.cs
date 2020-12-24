using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2criandovariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando variaveis");

            int idade;
            idade = 32;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);
            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é -->" + idade + "!");//Write não pula linhas


            Console.WriteLine("Execução finalizada.");
            Console.ReadLine();
        }
    }
}
