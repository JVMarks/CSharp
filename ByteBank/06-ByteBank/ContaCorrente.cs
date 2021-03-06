﻿//nossa class é um projeto/objeto
//Uma classe é a especificação para a criação de um objeto na memória do computador.
namespace _06_ByteBank
{
    class ContaCorrente
    {   
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
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
