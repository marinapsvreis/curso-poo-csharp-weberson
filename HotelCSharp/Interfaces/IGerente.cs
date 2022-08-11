namespace HotelCSharp.Interfaces
{
  public interface IGerente : IPessoa, ICamareira, IRecepcionista
  {
    void ConhecerMuitoBemOHotel();
  }
}