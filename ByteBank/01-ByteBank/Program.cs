using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // o que é imporante pra gente
            //criação de uma instancia
            //new ContaCorrente();

            ContaCorrente contaDeJoao = new ContaCorrente();

            contaDeJoao.titular = "João";
            contaDeJoao.agencia = 836;
            contaDeJoao.numero = 863452;
            contaDeJoao.saldo = 100;

            Console.WriteLine(contaDeJoao.titular);
            Console.WriteLine("Agência: " + contaDeJoao.agencia);
            Console.WriteLine("Número: " + contaDeJoao.numero);
            Console.WriteLine("Saldo: " + contaDeJoao.saldo);
            contaDeJoao.saldo += 200;

            Console.WriteLine("Saldo: " + contaDeJoao.saldo);
            Console.ReadLine();
        }
    }
}
