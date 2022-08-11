using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
  public class PedidoRepository : ICrudRepository<Pedido>
  {
    private List<Pedido> _pedidos;
    private int _ultimoId = 0;

    public PedidoRepository()
    {
      _pedidos = new List<Pedido>();
    }

    public Pedido Adicionar(Pedido pedido)
    {
      _ultimoId++;
      pedido.Id = _ultimoId;
      _pedidos.Add(pedido);

      return pedido;
    }

    public List<Pedido> ObterTodos()
    {
      return _pedidos;
    }

    public Pedido ObterPorId(int id)
    {
      return _pedidos.Where(b => b.Id == id).FirstOrDefault();
    }

    public Pedido Atualizar(Pedido Pedido)
    {
      var PedidoEncontrada = _pedidos.Where(b => b.Id == Pedido.Id).FirstOrDefault();
      if (PedidoEncontrada == null)
      {
        throw new Exception("Não é possivel atualizar um Pedido que não existe");
      }

      _pedidos.Remove(PedidoEncontrada);
      _pedidos.Add(Pedido);

      return Pedido;
    }

    public void Deletar(int id)
    {
      var Pedido = ObterPorId(id);
      if (Pedido == null)
      {
        throw new Exception("Você não pode deletar um Pedido que não existe");
      }

      _pedidos.Remove(Pedido);
    }
  }
}