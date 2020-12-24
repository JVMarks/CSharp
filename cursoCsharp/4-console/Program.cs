using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world. Projeto no Visual Studio!");

            double salario;
            salario = 1200.50;

            int salatioEmInterio;
            salatioEmInterio = (int)salario;

            Console.WriteLine("Seu salario é -->" + salario);

            //log é uma variavel de 64 bits 
            long idade;
            idade = 2600000000000000000;
            Console.WriteLine(idade);
            //o shot suporta 16 bits
            short quantidadeprodutos;
            quantidadeprodutos = 1200;
            Console.WriteLine(quantidadeprodutos);
            
            //suportaão casas decimais, precição muito curta 
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("a execução acabou.");
            Console.ReadLine();//espera que o usario digite algo
        }
    }
}
