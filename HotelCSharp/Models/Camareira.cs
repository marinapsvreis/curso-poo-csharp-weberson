using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
  public class Camareira : Pessoa, ICamareira
  {
    public Camareira() : base()
    {
    }

    public Camareira(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
    {
    }

    public void ArrumarCama()
    {
      Console.WriteLine(Nome + " arrumou a cama!");
      Console.WriteLine();
    }

    public void LimparQuarto()
    {
      Console.WriteLine(Nome + " limpou o quarto!");
      Console.WriteLine();
    }

    public override void SeApresentar()
    {
      Console.WriteLine("Prazer, sou a camareira " + Nome);
      Console.WriteLine();
    }

  }
}