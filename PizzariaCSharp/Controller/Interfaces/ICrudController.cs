namespace PizzariaCSharp.Controller.Interfaces
{
  /// <summary>
  /// Interface generica para os Cruds de controllers
  /// </summary>
  /// <typeparam name="T">Modelo que será controlado</typeparam>
  public interface ICrudController<T>
  {

    /// <summary>
    /// Metodo para adicionar um modelo
    /// </summary>
    /// <param name="modelo">Modelo a ser adicionado</param>
    /// <returns>Retorna o modelo a ser adicionado</returns>
    T Adicionar(T modelo);

    /// <summary>
    /// Metodo para obter a lista de modelos
    /// </summary>
    /// <returns>Retorna a lista de modelos encontrados</returns>
    List<T> ObterTodos();

    /// <summary>
    /// Metodo para encontrar modelo pelo seu id
    /// </summary>
    /// <param name="id">Id do modelo a ser encontrado</param>
    /// <returns>Retorna o modelo encontrado pelo seu id</returns>
    T ObterPorId(int id);

    /// <summary>
    /// Metodo que atualiza um modelo no banco de dados
    /// </summary>
    /// <param name="id">Id do modelo que será atualizado</param>
    /// <param name="modelo">Modelo que será atualizado</param>
    /// <returns>Retorna modelo após a atualização</returns>
    T Atualizar(int id, T modelo);

    /// <summary>
    /// Metodo para deletar o modelo pelo id.
    /// </summary>
    /// <param name="id">Id do modelo a ser deletado</param>
    void Deletar(int id);
  }
}