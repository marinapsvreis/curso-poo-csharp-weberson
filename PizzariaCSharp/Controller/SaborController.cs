using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository;

namespace PizzariaCSharp.Controller
{
  public class SaborController : ICrudController<Sabor>
  {
    private SaborRepository _repositorySabor;

    public SaborController(SaborRepository repositorySabor)
    {
      _repositorySabor = repositorySabor;
    }

    public List<Sabor> ObterTodos()
    {
      return _repositorySabor.ObterTodos();
    }

    public Sabor ObterPorId(int id)
    {
      return _repositorySabor.ObterPorId(id);
    }

    public Sabor Adicionar(Sabor sabor)
    {
      return _repositorySabor.Adicionar(sabor);
    }

    public void Deletar(int id)
    {
      _repositorySabor.Deletar(id);
    }

    public Sabor Atualizar(int id, Sabor sabor)
    {
      sabor.Id = id;
      return _repositorySabor.Atualizar(sabor);
    }
  }
}