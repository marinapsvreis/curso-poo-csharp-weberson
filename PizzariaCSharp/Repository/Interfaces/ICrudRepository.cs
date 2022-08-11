namespace PizzariaCSharp.Repository.Interfaces
{
  /// <summary>
  /// Interface do repositório genérico baseado na construção do modelo
  /// </summary>
  /// <typeparam name="T">Modelo, entidade a qual será persistida</typeparam>

  public interface ICrudRepository<T>
  {

    /// <summary>
    /// Metodo que adiciona um modelo ao banco de dados.
    /// </summary>
    /// <param name="modelo"> Modelo que será adicionado</param>
    /// <returns>Retorna o modelo após ser adicionado</returns>
    T Adicionar(T modelo);

    /// <summary>
    /// Metodo que retorna uma lista com todos os modelos encontrados no banco de dados
    /// </summary>
    /// <returns>Retorna a lista com todos os modelos</returns>
    List<T> ObterTodos();

    /// <summary>
    /// Metodo que retorna o modelo encontrado pelo seu id.
    /// </summary>
    /// <param name="id">Id do modelo a ser encontrado</param>
    /// <returns>Retorna o modelo encontrado pelo id</returns>
    T ObterPorId(int id);

    /// <summary>
    /// Metodo para atualizar um modelo no banco de dados
    /// </summary>
    /// <param name="modelo">Modelo a ser atualizado</param>
    /// <returns>Retorna o modelo após a atualização</returns>
    T Atualizar(T modelo);

    /// <summary>
    /// Deleta o modelo pelo seu id
    /// </summary>
    /// <param name="id">Id do modelo a ser deletado</param>
    void Deletar(int id);
  }
}