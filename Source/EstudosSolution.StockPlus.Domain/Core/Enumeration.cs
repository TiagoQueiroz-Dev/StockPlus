namespace EstudosSolution.StockPlus.Domain.Core;

public abstract class Enumeration
{
    protected Enumeration(int pId, string pNome)
    {
        Id = pId;
        Nome = pNome;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
}