using EstudosSolution.StockPlus.Infra.Contexts;

namespace EstudosSolution.StockPlus.Infra.Repositories;

public class RepositoryBase
{
    private readonly StockPlusContext _db;

    public RepositoryBase(StockPlusContext db)
    {
        _db = db;
    }
}