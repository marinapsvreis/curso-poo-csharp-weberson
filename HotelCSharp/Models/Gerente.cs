using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
  public class Gerente : Pessoa, IGerente
  {
    public Gerente() : base()
    {
    }

    public Gerente(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
    {
    }

    public void ArrumarCama()
    {
      Console.WriteLine(Nome + " limpou o quarto!");
      Console.WriteLine();
    }

    public void AtenderTelefone()
    {
      Console.WriteLine(Nome + " atendeu o telefone!");
      Console.WriteLine();
    }

    public void ConhecerMuitoBemOHotel()
    {
      Console.WriteLine(Nome + " conhece muito bem o hotel!");
      Console.WriteLine();
    }

    public void FalarIngles()
    {
      Console.WriteLine(Nome + " falou ingles!");
      Console.WriteLine();
    }
    public void LimparQuarto()
    {
      Console.WriteLine(Nome + " arrumou a cama!");
      Console.WriteLine();
    }

    public override void SeApresentar()
    {
      Console.WriteLine("Prazer, sou o gerente " + Nome);
    }
  }
}