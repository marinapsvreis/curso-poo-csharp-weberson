namespace BancoCSharp.Models
{
  public class ContaInvestimento : ContaBancaria
  {

    public double ValorInvestido { get; private set; }
    public ContaInvestimento(Titular titular) : base(titular)
    {
    }

    public ContaInvestimento(Titular titular, double saldo) : base(titular, saldo)
    {
    }

    public override void ImprimirExtrato()
    {
      Console.WriteLine("********************************");
      Console.WriteLine("** Extrato Conta Investimento **");
      Console.WriteLine("********************************");
      Console.WriteLine();

      Console.WriteLine("Gerado em: " + DateTime.Now);
      Console.WriteLine();

      foreach (var movimentacao in Movimentacoes)
      {
        Console.WriteLine(movimentacao.ToString());
      }

      Console.WriteLine("Saldo atual: R$" + Saldo);
      Console.WriteLine();
      Console.WriteLine("Limite atual disponível: R$" + LimiteDisponivel);
      Console.WriteLine();
      Console.WriteLine("********************************");
      Console.WriteLine("******** Fim do extrato ********");
      Console.WriteLine("********************************");
      Console.WriteLine();
    }
  }
}