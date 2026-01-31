using EstudosSolution.StockPlus.Domain.Core;
using EstudosSolution.StockPlus.Domain.Core.Repositories;

namespace EstudosSolution.StockPlus.Domain.Services;

public interface IServiceBase<T> 
    where T : Entity
{
    void Adicionar(T pEntity);
    void Editar(T pEntity);
    void Excluir(T pEntity);
    IQueryable<T> ObterTodos();
    T? ObterPorId(int pId);
}

public abstract class ServiceBase<T> : IServiceBase<T> 
    where T : Entity
{
    private IRepository<T> _repository;

    public ServiceBase(IRepository<T> pRepository)
    {
        _repository = pRepository;
    }
    public void Adicionar(T pEntity)
    {
        _repository.Adicionar(pEntity);
    }

    public void Editar(T pEntity)
    {
        _repository.Editar(pEntity);
    }

    public void Excluir(T pEntity)
    {
        _repository.Excluir(pEntity);
    }

    public IQueryable<T> ObterTodos()
    {
        return _repository.ObterTodos();
    }

    public T? ObterPorId(int pId)
    {
        return _repository.ObterPorId(pId);
    }
}