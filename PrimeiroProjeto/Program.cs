using PrimeiroProjeto;

Console.WriteLine("Aprendendo POO");

#region Primeira aula (Atributos)
// var meuCarro = new Carro(); //instanciando um objeto
// meuCarro.Ano = 2022;
// meuCarro.Cor = "Preto";
// meuCarro.Modelo = "Fiat Toro";

// Console.WriteLine(meuCarro.Modelo);
// Console.WriteLine(meuCarro.Cor);
// Console.WriteLine(meuCarro.Ano);

// var carroDoVizinho = new Carro();
// carroDoVizinho.Ano = 2022;
// carroDoVizinho.Cor = "Vermelho";
// carroDoVizinho.Modelo = "Ford Fusion";

// Console.WriteLine(carroDoVizinho.Modelo);
// Console.WriteLine(carroDoVizinho.Cor);
// Console.WriteLine(carroDoVizinho.Ano);

// var cursoRedes = new Curso();
// cursoRedes.Materia = "Redes de Computadores";
// cursoRedes.Valor = 199.99;

// var cursoCsharp = new Curso();
// cursoCsharp.Materia = "POO com C#";
// cursoCsharp.Valor = 250.00;

//Console.ReadKey(); //espera apertar uma tecla para encerrar o programa
#endregion

#region Segunda aula (Construtores)
// var carro = new Carro("Gol", "Preto", 2022);
// var carro2 = new Carro("Uno");

// //Construtor initializer
// var carro3 = new Carro
// {
//   Modelo = "Palio",
// };

// System.Console.WriteLine(carro.Modelo);
// System.Console.WriteLine(carro2.Modelo);
// carro.LigarCarro();
// carro.TocarBuzina();
#endregion

#region Terceira aula (Metodos)

// var pessoa = new Pessoa(21);
// pessoa.Nome = "José";
// pessoa.Sobrenome = " da Silva";
// //pessoa.NomeCompleto = pessoa.Nome + pessoa.Sobrenome;
// //pessoa.AtribuirNomeCompleto();

// System.Console.WriteLine(pessoa.NomeCompleto);
// System.Console.WriteLine(pessoa.ObterIdade());

var motorista = new Motorista(29);
motorista.Sobrenome = "Silva";
motorista.AdicionarNome("José");

System.Console.WriteLine(motorista.NomeCompleto);

#endregion