using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Enum;

namespace PizzariaCSharp.Model
{
  public class Pizza
  {
    public int Id { get; set; }
    public ETipoPizza TipoPizza { get; set; }
    public ETipoBorda TipoBorda { get; set; }
    public List<Sabor> Sabores { get; set; }
    public double Valor { get; set; }

    public Pizza()
    {

    }

    public Pizza(ETipoPizza tipoPizza, ETipoBorda tipoBorda, double vaLor, List<Sabor> sabores)
    {
      TipoPizza = tipoPizza;
      TipoBorda = tipoBorda;
      Valor = Valor;
      Sabores = sabores;
    }

  }
}