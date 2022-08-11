using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
  public class PizzaRepository : ICrudRepository<Pizza>
  {
    private List<Pizza> _pizzas;
    private int _ultimoId = 0;

    public PizzaRepository()
    {
      _pizzas = new List<Pizza>();
    }

    public Pizza Adicionar(Pizza Pizza)
    {
      _ultimoId++;
      Pizza.Id = _ultimoId;
      _pizzas.Add(Pizza);

      return Pizza;
    }

    public List<Pizza> ObterTodos()
    {
      return _pizzas;
    }

    public Pizza ObterPorId(int id)
    {
      return _pizzas.Where(b => b.Id == id).FirstOrDefault();
    }

    public Pizza Atualizar(Pizza Pizza)
    {
      var PizzaEncontrada = _pizzas.Where(b => b.Id == Pizza.Id).FirstOrDefault();
      if (PizzaEncontrada == null)
      {
        throw new Exception("Não é possivel atualizar uma Pizza que não existe");
      }

      _pizzas.Remove(PizzaEncontrada);
      _pizzas.Add(Pizza);

      return Pizza;
    }

    public void Deletar(int id)
    {
      var Pizza = ObterPorId(id);
      if (Pizza == null)
      {
        throw new Exception("Você não pode deletar um Pizza que não existe");
      }

      _pizzas.Remove(Pizza);
    }
  }
}