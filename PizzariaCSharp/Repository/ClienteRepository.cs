using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
  public class ClienteRepository : ICrudRepository<Cliente>
  {
    private List<Cliente> _clientes;
    private int _ultimoId = 0;

    public ClienteRepository()
    {
      _clientes = new List<Cliente>();
    }

    public Cliente Adicionar(Cliente cliente)
    {
      _ultimoId++;
      cliente.Id = _ultimoId;
      _clientes.Add(cliente);

      return cliente;
    }

    public List<Cliente> ObterTodos()
    {
      return _clientes;
    }

    public Cliente ObterPorId(int id)
    {
      return _clientes.Where(b => b.Id == id).FirstOrDefault();
    }

    public Cliente Atualizar(Cliente Cliente)
    {
      var ClienteEncontrada = _clientes.Where(b => b.Id == Cliente.Id).FirstOrDefault();
      if (ClienteEncontrada == null)
      {
        throw new Exception("Não é possivel atualizar um Cliente que não existe");
      }

      _clientes.Remove(ClienteEncontrada);
      _clientes.Add(Cliente);

      return Cliente;
    }

    public void Deletar(int id)
    {
      var Cliente = ObterPorId(id);
      if (Cliente == null)
      {
        throw new Exception("Você não pode deletar um Cliente que não existe");
      }

      _clientes.Remove(Cliente);
    }
  }
}