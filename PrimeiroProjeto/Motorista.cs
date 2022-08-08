using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
  public class Motorista : Pessoa
  {
    public Motorista(int idade) : base(idade)
    {
    }

    public void AdicionarNome(string nome)
    {
      Nome = nome;
    }
  }
}