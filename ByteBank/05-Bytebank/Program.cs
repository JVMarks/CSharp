using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cliente joao = new Cliente();

            //joao.nome = "João";
            //joao.profissao = "Desenvolvedor";
            //joao.cpf = "519.811.794-95";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = joao;

            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela";
            conta.titular.cpf = "519.811.794-95";
            conta.titular.profissao = "Desenvolvedor";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            if(conta.titular == null)
            {
                Console.WriteLine("Não a nem uma referencia com esse nome");
            }

            Console.WriteLine();
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
