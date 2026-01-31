using EstudosSolution.StockPlus.Domain.Core;
using EstudosSolution.StockPlus.Domain.Core.Repositories;
using EstudosSolution.StockPlus.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EstudosSolution.StockPlus.Infra.Repositories;

public class Repository<T> : RepositoryBase, IRepository<T>
    where T : Entity
{
    protected readonly DbSet<T> DbSet;
    public Repository(StockPlusContext db) : base(db)
    {
        DbSet = db.Set<T>();
    }

    public void Adicionar(T pEntity)
    {
        DbSet.Add(pEntity);
    }

    public void Editar(T pEntity)
    {
        DbSet.Update(pEntity);
    }

    public void Excluir(T pEntity)
    {
        pEntity.Excluido = true;
        DbSet.Update(pEntity);
    }

    public IQueryable<T> ObterTodos()
    {
        return DbSet
            .Where(p => !p.Excluido)
        ;
    }

    public T? ObterPorId(int pId)
    {
        return DbSet.Find(pId);
    }
}