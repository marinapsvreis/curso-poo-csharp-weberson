using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository;

namespace PizzariaCSharp.Controller
{
  public class ClienteController : ICrudController<Cliente>
  {
    private ClienteRepository _repositoryCliente;

    public ClienteController(ClienteRepository repositoryCliente)
    {
      _repositoryCliente = repositoryCliente;
    }

    public List<Cliente> ObterTodos()
    {
      return _repositoryCliente.ObterTodos();
    }

    public Cliente ObterPorId(int id)
    {
      return _repositoryCliente.ObterPorId(id);
    }

    public Cliente Adicionar(Cliente cliente)
    {
      return _repositoryCliente.Adicionar(cliente);
    }

    public void Deletar(int id)
    {
      _repositoryCliente.Deletar(id);
    }

    public Cliente Atualizar(int id, Cliente cliente)
    {
      cliente.Id = id;
      return _repositoryCliente.Atualizar(cliente);
    }
  }
}