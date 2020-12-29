//nossa class é um projeto/objeto
//Uma classe é a especificação para a criação de um objeto na memória do computador.
namespace _06_ByteBank
{
    class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;

        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }
            else
            {
                this.saldo = saldo;
            }
        }

        public double ObterSaldo()
        {
            return saldo;
        }

        //FUNÇÃO representa ação
        public bool Sacar(double valor)
        {
            //this server em funcoes para 
            if (saldo < valor)
            {
                //devolver valor
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        //função sem retorno
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
