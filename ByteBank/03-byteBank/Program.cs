using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_byteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDeJoao = new ContaCorrente();
            contaDeJoao.titular = "Joao";
            contaDeJoao.agencia = 863;
            contaDeJoao.numero = 863452;

            ContaCorrente contaDeJoaoVictor = new ContaCorrente();
            contaDeJoaoVictor.titular = "Joao";
            contaDeJoaoVictor.agencia = 863;
            contaDeJoaoVictor.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referencia: "
                + (contaDeJoao == contaDeJoaoVictor));

            Console.WriteLine("Igualdade de tipo de valor: "
                + (contaDeJoao == contaDeJoaoVictor));


            contaDeJoao = contaDeJoaoVictor;
            Console.WriteLine("Igualdade de tipo de referencia: "
                + (contaDeJoao == contaDeJoaoVictor));


            contaDeJoaoVictor.saldo = 300;
            Console.WriteLine(contaDeJoao.saldo);
            Console.WriteLine(contaDeJoaoVictor.saldo);

            if(contaDeJoao.saldo >= 100)
            {
             contaDeJoao.saldo -= 100;
            }

            Console.ReadLine();
        }
    }
}
