using HotelCSharp.Models;

namespace HotelCSharp.Interfaces
{
  public interface IRHTerceirizado
  {
    void ContratarCamareira(ICamareira camareira);
    void ContratarRecepcionista(IRecepcionista recepcionista);
    void PromoverParaGerente(Camareira camareira);
    void PromoverParaGerente(Recepcionista recepcionista);
  }
}