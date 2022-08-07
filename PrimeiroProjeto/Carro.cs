namespace PrimeiroProjeto
{
  public class Carro
  {
    #region Atributos
    public string Cor { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    #endregion

    #region Construtores

    //Construtor Padrão
    //Se existem outros construtores e quiser manter esse funcionando, precisa declarar
    public Carro()
    {
    }

    public Carro(string modelo, string cor, int ano)
    {
      Modelo = modelo;
      Cor = cor;
      Ano = ano;
    }

    public Carro(string modelo)
    {
      Modelo = modelo;
    }

    #endregion
  }
}