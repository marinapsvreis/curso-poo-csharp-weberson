using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
  public class SaborRepository : ICrudRepository<Sabor>
  {
    private List<Sabor> _sabores;
    private int _ultimoId = 0;

    public SaborRepository()
    {
      _sabores = new List<Sabor>();
    }

    public Sabor Adicionar(Sabor Sabor)
    {
      _ultimoId++;
      Sabor.Id = _ultimoId;
      _sabores.Add(Sabor);

      return Sabor;
    }

    public List<Sabor> ObterTodos()
    {
      return _sabores;
    }

    public Sabor ObterPorId(int id)
    {
      return _sabores.Where(b => b.Id == id).FirstOrDefault();
    }

    public Sabor Atualizar(Sabor Sabor)
    {
      var SaborEncontrada = _sabores.Where(b => b.Id == Sabor.Id).FirstOrDefault();
      if (SaborEncontrada == null)
      {
        throw new Exception("Não é possivel atualizar uma Sabor que não existe");
      }

      _sabores.Remove(SaborEncontrada);
      _sabores.Add(Sabor);

      return Sabor;
    }

    public void Deletar(int id)
    {
      var Sabor = ObterPorId(id);
      if (Sabor == null)
      {
        throw new Exception("Você não pode deletar um Sabor que não existe");
      }

      _sabores.Remove(Sabor);
    }
  }
}