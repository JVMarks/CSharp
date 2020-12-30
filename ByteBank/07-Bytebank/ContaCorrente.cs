//nossa class é um projeto/objeto
//Uma classe é a especificação para a criação de um objeto na memória do computador.
namespace _07_Bytebank
{
    class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }
       
        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; set; }

        private double _saldo = 100;

        //argumento
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    this._saldo = value;
                }
            }
        }

        //regra de iniciação e codigo
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

           TotalDeContasCriadas++;
        }

        //FUNÇÃO representa ação
        public bool Sacar(double valor)
        {
            //this server em funcoes para 
            if (_saldo < valor)
            {
                //devolver valor
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        //função sem retorno
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
