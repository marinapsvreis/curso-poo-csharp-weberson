using BancoCSharp.Enums;

namespace BancoCSharp.Models
{
  //classe abstrata não permite ser instanciada
  public abstract class ContaBancaria
  {
    #region Atributos
    public Titular Titular { get; set; }
    public double Saldo { get; private set; }
    public double LimiteDisponivel { get; private set; }
    public double SaldoFinal => Saldo + LimiteDisponivel;
    public DateTime DataAbertura { get; private set; }
    protected List<Movimentacao> Movimentacoes { get; set; }
    protected readonly double VALOR_MINIMO = 10.0;
    protected readonly double LIMITE = 100.0;

    #endregion

    #region Construtores
    public ContaBancaria(Titular titular)
    {
      Titular = titular;
      Saldo = 0;
      LimiteDisponivel = LIMITE;
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
      LimiteDisponivel = LIMITE;
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
      else if (LimiteDisponivel < LIMITE)
      {
        var limiteFaltante = LIMITE - LimiteDisponivel;
        var depositoExtra = valor - limiteFaltante;
        if (depositoExtra > 0)
        {
          Saldo += depositoExtra;
          LimiteDisponivel = LIMITE;
          Movimentacoes.Add(new Movimentacao(TipoMovimentacao.DEPOSITO, valor));
        }
        else
        {
          Saldo = 0;
          LimiteDisponivel += valor;
          Movimentacoes.Add(new Movimentacao(TipoMovimentacao.DEPOSITO, valor));
        }
      }
      else
      {
        Saldo += valor;
        Movimentacoes.Add(new Movimentacao(TipoMovimentacao.DEPOSITO, valor));
      }
    }

    public double Sacar(double valor)
    {
      if (valor < VALOR_MINIMO)
      {
        throw new Exception("O valor mínimo para saque é " + VALOR_MINIMO);
      }
      else if (Saldo < valor)
      {
        if (SaldoFinal < valor)
        {
          throw new Exception("Você não possui saldo nem limite para efetuar esse saque, seu saldo + limite atual é R$ " + SaldoFinal);
        }
        var valorExtra = valor - Saldo;
        Saldo = 0;
        LimiteDisponivel -= valorExtra;

        Console.WriteLine("Você efetuou uma retirada no seu limite no valor de R$: " + valorExtra + " e será cobrada uma taxa de 1% ao dia sobre esse valor");
        Console.WriteLine("Resumo de saldo na sua conta é de R$: " + (0 - valorExtra));
        Console.WriteLine();

        Movimentacoes.Add(new Movimentacao(TipoMovimentacao.SAQUE, (valor - valorExtra)));
        Movimentacoes.Add(new Movimentacao(TipoMovimentacao.CHEQUE_ESPECIAL, valorExtra));
        return valor;
      }
      else
      {
        Saldo -= valor;
        Movimentacoes.Add(new Movimentacao(TipoMovimentacao.SAQUE, valor));
        return valor;
      }
    }

    public void Transferir(ContaBancaria contaDestino, double valor)
    {
      if (valor < VALOR_MINIMO)
      {
        throw new Exception("O valor mínimo para transferência é " + VALOR_MINIMO);
      }
      else if (Saldo < valor)
      {
        if (SaldoFinal < valor)
        {
          throw new Exception("Você não possui saldo nem limite para efetuar essa transferencia, seu saldo + limite atual é R$ " + SaldoFinal);
        }
        var valorExtra = valor - Saldo;
        Saldo = 0;
        LimiteDisponivel -= valorExtra;

        contaDestino.Depositar(valor);
        Movimentacoes.Add(new Movimentacao(TipoMovimentacao.TRANSFERENCIA, (valor - valorExtra)));
        Movimentacoes.Add(new Movimentacao(TipoMovimentacao.CHEQUE_ESPECIAL, valorExtra));

        Console.WriteLine("Você efetuou uma retirada no seu limite no valor de R$: " + valorExtra + " e será cobrada uma taxa de 1% ao dia sobre esse valor");
        Console.WriteLine("Resumo de saldo na sua conta é de R$: " + (0 - valorExtra));
        Console.WriteLine();
      }
      else
      {
        contaDestino.Depositar(valor);
        Saldo -= valor;
        Movimentacoes.Add(new Movimentacao(TipoMovimentacao.TRANSFERENCIA, valor));
      }
    }

    //abstract obriga todo mundo a implementar
    //metodo virtual da a opção dos filhos implementarem o metodo de outra maneira ou aproveitar o do pai
    public virtual void ImprimirExtrato()
    {
      Console.WriteLine("Imprimindo extrato da Conta!");
    }
    #endregion
  }
};
