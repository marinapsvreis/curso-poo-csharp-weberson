using PizzariaCSharp.Controller;
using PizzariaCSharp.Enum;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository;

Console.WriteLine("Simulando uma API");
Console.WriteLine();

//Criando os controllers
var controllerBebida = new BebidaController(new BebidaRepository());
var controllerSabor = new SaborController(new SaborRepository());
var controllerPizza = new PizzaController(new PizzaRepository());
var controllerPedido = new PedidoController(new PedidoRepository());
var controllerCliente = new ClienteController(new ClienteRepository());

//Simulando uma API

//Cadastrar duas bebidas
var bebida1 = controllerBebida.Adicionar(new Bebida("Coca Cola 2lt", 10.0));
var bebida2 = controllerBebida.Adicionar(new Bebida("H2O Limoneto", 8.5));

//Cadastrar quatro sabores
var sabor1 = controllerSabor.Adicionar(new Sabor("4 Queijos", ""));
var sabor2 = controllerSabor.Adicionar(new Sabor("Portuguesa", ""));
var sabor3 = controllerSabor.Adicionar(new Sabor("Calabresa", ""));
var sabor4 = controllerSabor.Adicionar(new Sabor("Frango com Catupiry", ""));

//Cadastrar pizza
var pizza1 = controllerPizza.Adicionar(new Pizza(ETipoPizza.GIGANTE, ETipoBorda.COM_CHEDDAR, 50.0, new List<Sabor>() { sabor1, sabor2 }));
var pizza2 = controllerPizza.Adicionar(new Pizza(ETipoPizza.SUPER_GIGANTE, ETipoBorda.SEM_BORDA, 65.0, new List<Sabor>() { sabor2, sabor3 }));
var pizza3 = controllerPizza.Adicionar(new Pizza(ETipoPizza.MEDIA, ETipoBorda.COM_CATUPIRY, 40.0, new List<Sabor>() { sabor1 }));
var pizza4 = controllerPizza.Adicionar(new Pizza(ETipoPizza.PEQUENA, ETipoBorda.COM_MUSSARELA, 30.0, new List<Sabor>() { sabor4 }));

//Cadastrar dois clientes
var cliente1 = controllerCliente.Adicionar(new Cliente() { Nome = "José Francisco", Telefone = "22999887766" });
var cliente2 = controllerCliente.Adicionar(new Cliente() { Nome = "Maria Aparecida", Telefone = "22999887755" });

var pedido1 = new Pedido(cliente1);

var valor1 = pedido1
  .AdicionarBebida(bebida1)
  .AdicionarBebida(bebida2)
  .AdicionarPizza(pizza1)
  .AdicionarPizza(pizza2)
  .ObterValorTotal();

pedido1.FinalizarPedido();
controllerPedido.Adicionar(pedido1);

var pedido2 = new Pedido(cliente2);

var valor2 = pedido2
  .AdicionarBebida(bebida2)
  .AdicionarPizza(pizza4)
  .ObterValorTotal();

pedido1.FinalizarPedido();
controllerPedido.Adicionar(pedido2);
