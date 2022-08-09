using BancoCSharp.Enums;

namespace BancoCSharp.Models
{
  //classe abstrata não permite ser instanciada
  public abstract class ContaBancaria
  {
    #region Atributos
    public Titular Titular { get; set; }
    public double Saldo { get; private set; }
    public DateTime DataAbertura { get; private set; }
    protected List<Movimentacao> Movimentacoes { get; set; }
    protected readonly double VALOR_MINIMO = 10.0;

    #endregion

    #region Construtores
    public ContaBancaria(Titular titular)
    {
      Titular = titular;
      Saldo = 0;
      DataAbertura = DateTime.Now;
      Movimentacoes = new List<Movimentacao>()
      {
        new Movimentacao(TipoMovimentacao.ABERTURA_CONTA, Saldo)
      };
    }

    public ContaBancaria(Titular titular, double saldo)
    {
      Titular = titular;
      Saldo = saldo;
      DataAbertura = DateTime.Now;

      Movimentacoes = new List<Movimentacao>()
      {
        new Movimentacao(TipoMovimentacao.ABERTURA_CONTA, saldo)
      };
    }

    #endregion

    #region Metodos
    public void Depositar(double valor)
    {
      if (valor < VALOR_MINIMO)
      {
        throw new Exception("O valor mínimo para deposito é " + VALOR_MINIMO);
      }

      Saldo += valor;
      Movimentacoes.Add(new Movimentacao(TipoMovimentacao.DEPOSITO, valor));
    }

    public double Sacar(double valor)
    {
      if (valor < VALOR_MINIMO)
      {
        throw new Exception("O valor mínimo para saque é " + VALOR_MINIMO);
      }
      else if (Saldo < valor)
      {
        throw new Exception("O seu saldo é insuficiente para efetuar o saque. Seu saldo atual é de: R$ " + Saldo);
      }

      Saldo -= valor;
      Movimentacoes.Add(new Movimentacao(TipoMovimentacao.SAQUE, valor));
      return valor;
    }

    public void Transferir(ContaBancaria contaDestino, double valor)
    {
      if (valor < VALOR_MINIMO)
      {
        throw new Exception("O valor mínimo para transferência é " + VALOR_MINIMO);
      }
      else if (Saldo < valor)
      {
        throw new Exception("O seu saldo é insuficiente para realizar a transferência. Seu saldo atual é de: R$ " + Saldo);
      }
      contaDestino.Depositar(valor);
      Saldo -= valor;
      Movimentacoes.Add(new Movimentacao(TipoMovimentacao.TRANSFERENCIA, valor));
    }

    //abstract obriga todo mundo a implementar
    //metodo virtual da a opção dos filhos implementarem o metodo de outra maneira ou aproveitar o do pai
    public virtual void ImprimirExtrato()
    {
      Console.WriteLine("Imprimindo extrato da Conta!");
    }
    #endregion
  };
}