using BancoCSharp.Enums;

namespace BancoCSharp.Models
{
  public class Movimentacao
  {

    private DateTime DataHoraMovimentacao { get; set; }
    private TipoMovimentacao TipoMovimentacao { get; set; }
    private double Valor { get; set; }

    public Movimentacao(TipoMovimentacao tipoMovimentacao, double valor)
    {
      TipoMovimentacao = tipoMovimentacao;
      Valor = valor;
      DataHoraMovimentacao = DateTime.Now;
    }

    public override string ToString()
    {
      var valor = (this.TipoMovimentacao == TipoMovimentacao.DEPOSITO || this.TipoMovimentacao == TipoMovimentacao.ABERTURA_CONTA) ? "R$ " + Valor : " -R$ " + Valor;
      return $"{DataHoraMovimentacao}hs | {TipoMovimentacao} | {valor}";
    }
  }
}