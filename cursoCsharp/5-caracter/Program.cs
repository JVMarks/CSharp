using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_caracter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world. Projeto no Visual Studio!");

            //character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra +1);
            Console.WriteLine(primeiraLetra);

            //t
            string titulo = "Alura Cursos de tecnologias" + 2020;
            Console.WriteLine(titulo);

            string cursosprogramacao = 
                @" - .NET
- JAVA
- JAVASCRIPT";
            Console.WriteLine(cursosprogramacao);

            Console.WriteLine("a execução acabou.");
            Console.ReadLine();//espera que o usario digite algo           
        }
    }
}
