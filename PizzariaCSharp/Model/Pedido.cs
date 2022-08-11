namespace PizzariaCSharp.Model
{
  public class Pedido
  {
    public int Id { get; set; }
    public DateTime DataEHora { get; set; }
    public Cliente Cliente { get; set; }
    public List<Pizza> Pizzas { get; set; }
    public List<Bebida> Bebidas { get; set; }

    public Pedido(Cliente cliente)
    {
      Cliente = cliente;
      Pizzas = new List<Pizza>();
      Bebidas = new List<Bebida>();
    }

    public Pedido AdicionarPizza(Pizza pizza)
    {
      Pizzas.Add(pizza);
      return this;
    }

    public Pedido AdicionarBebida(Bebida bebida)
    {
      Bebidas.Add(bebida);
      return this;
    }

    public double ObterValorTotal()
    {
      return 10.0;
    }

    public Pedido FinalizarPedido()
    {
      DataEHora = DateTime.Now;
      return this;
    }
  }
}