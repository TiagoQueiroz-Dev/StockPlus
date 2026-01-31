namespace EstudosSolution.StockPlus.Domain.Core.Repositories;

public interface IRepository<T>
    where T : Entity
{
    void Adicionar(T pEntity);
    void Editar(T pEntity);
    void Excluir(T pEntity);
    IQueryable<T> ObterTodos();
    T? ObterPorId(int pId);
}