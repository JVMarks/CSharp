
//nossa class é um projeto/objeto
//Uma classe é a especificação para a criação de um objeto na memória do computador.
class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    //FUNÇÃO representa ação
    public bool Sacar(double valor)
    {
        //this server em funcoes para 
        if(this.saldo < valor)
        {
            //devolver valor
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

    //função sem retorno
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }

}