using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
  public class Pessoa
  {
    //public string Nome { get; set; }
    protected string Nome { get; set; }

    public string Sobrenome { get; set; }

    //public int Idade { get; set; }
    //public int Idade { get; private set; }
    private int Idade { get; set; }

    public string NomeCompleto => Nome + Sobrenome; //propriedade

    public Pessoa(int idade)
    {
      Idade = idade;
    }


    // public void AtribuirNomeCompleto(){
    //     NomeCompleto = Nome + Sobrenome;
    // }

    public int ObterIdade()
    {
      return Idade;
    }
  }
}