using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelCSharp.Models
{
  public class Cliente : Pessoa
  {
    public Cliente() : base()
    {
    }

    public Cliente(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
    {
    }

    public override void SeApresentar()
    {
      Console.WriteLine("Prazer, sou o cliente " + Nome);
    }
  }
}