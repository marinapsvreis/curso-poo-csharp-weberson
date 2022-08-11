using HotelCSharp.Exceptions;
using HotelCSharp.Interfaces;
using HotelCSharp.Models;

Console.WriteLine("***************************************************");
Console.WriteLine("******************Hotel CSharp*********************");
Console.WriteLine("***************************************************");
Console.WriteLine();

//Contratar uma camareira.

Camareira camareira1 = new Camareira("Joana da Silva", "12345678901", "24999887766");
Camareira camareira2 = new Camareira("Maria da Silva", "12345678903", "24999887755");

// camareira1.SeApresentar();
// camareira1.LimparQuarto();
// camareira1.ArrumarCama();

//Contratar uma recepcionista

Recepcionista recepcionista1 = new Recepcionista("Marcela Gonçalves", "12345678902", "24888997766");
Recepcionista recepcionista2 = new Recepcionista("Ana Clara Gonçalves", "12345678904", "24888997767");

// recepcionista1.SeApresentar();
// recepcionista1.AtenderTelefone();
// recepcionista1.FalarIngles();

//Contratar um gerente

IGerente gerente1 = new Gerente("Fulano de tal", "33344455566", "24999885544");
IGerente gerente2 = new Gerente("Ciclano de tal", "33344455510", "24999885512");

// gerente1.SeApresentar();
// gerente1.ArrumarCama();
// gerente1.LimparQuarto();
// gerente1.AtenderTelefone();
// gerente1.FalarIngles();

//Inaugurando Hotel

Hotel hotel = new Hotel("Hotel CSharp", new Endereco()
{
  CEP = "25600123",
  Rua = "Rua XYZ",
  Numero = 58,
  Complemento = "Esquina 3",
  Bairro = "Lugar nenhum",
  Cidade = "Qualquer lugar"

});

hotel.ContratarCamareira(camareira1);
hotel.ContratarCamareira(camareira2);

hotel.ContratarRecepcionista(recepcionista1);
hotel.ContratarRecepcionista(recepcionista2);

hotel.ContratarGerente(gerente1);
hotel.ContratarCamareira(gerente2);
hotel.ContratarRecepcionista(gerente2);
Console.WriteLine();

// //Gerente

// hotel.Gerente.SeApresentar();
// hotel.Gerente.ArrumarCama();
// hotel.Gerente.LimparQuarto();
// hotel.Gerente.AtenderTelefone();
// hotel.Gerente.FalarIngles();

// Console.WriteLine();
// Console.WriteLine("*********************************************************");
// Console.WriteLine();

// foreach (var camareira in hotel.Camareiras)
// {
//   camareira.SeApresentar();
//   camareira.LimparQuarto();
//   camareira.ArrumarCama();
//   Console.WriteLine();
//   Console.WriteLine("*********************************************************");
//   Console.WriteLine();
// }

// foreach (var recepcionista in hotel.Recepcionistas)
// {
//   recepcionista.SeApresentar();
//   recepcionista.AtenderTelefone();
//   recepcionista.FalarIngles();
//   Console.WriteLine();
//   Console.WriteLine("*********************************************************");
//   Console.WriteLine();
// }

IRHTerceirizado rh = new RH("RH CSharp", hotel);

// Contratações
Camareira camareira3 = new Camareira
{
  Nome = "Eugenia Ferraz"
};

rh.ContratarCamareira(camareira3);

Recepcionista recepcionista3 = new Recepcionista
{
  Nome = "Joice Lima",
  CPF = "00011122233"
};

rh.ContratarRecepcionista(recepcionista3);

hotel.Gerente.SeApresentar();

try
{
  rh.PromoverParaGerente(camareira3);

}
catch (DocumentosInvalidosException ex)
{
  Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
  Console.WriteLine("DEU RUIM!");
}

hotel.Gerente.SeApresentar();

try
{
  rh.PromoverParaGerente(recepcionista3);

}
catch (DocumentosInvalidosException ex)
{
  Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
  Console.WriteLine("DEU RUIM!");
}

hotel.Gerente.SeApresentar();


