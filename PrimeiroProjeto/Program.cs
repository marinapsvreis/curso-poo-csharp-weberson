using PrimeiroProjeto;

Console.WriteLine("Aprendendo POO");

var meuCarro = new Carro(); //instanciando um objeto
meuCarro.Ano = 2022;
meuCarro.Cor = "Preto";
meuCarro.Modelo = "Fiat Toro";

Console.WriteLine(meuCarro.Modelo);
Console.WriteLine(meuCarro.Cor);
Console.WriteLine(meuCarro.Ano);

var carroDoVizinho = new Carro();
carroDoVizinho.Ano = 2022;
carroDoVizinho.Cor = "Vermelho";
carroDoVizinho.Modelo = "Ford Fusion";

Console.WriteLine(carroDoVizinho.Modelo);
Console.WriteLine(carroDoVizinho.Cor);
Console.WriteLine(carroDoVizinho.Ano);

var cursoRedes = new Curso();
cursoRedes.Materia = "Redes de Computadores";
cursoRedes.Valor = 199.99;

var cursoCsharp = new Curso();
cursoCsharp.Materia = "POO com C#";
cursoCsharp.Valor = 250.00;

//Console.ReadKey(); //espera apertar uma tecla para encerrar o programa
