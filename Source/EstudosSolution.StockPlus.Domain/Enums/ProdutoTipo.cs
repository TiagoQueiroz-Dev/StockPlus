using EstudosSolution.StockPlus.Domain.Core;

namespace EstudosSolution.StockPlus.Domain.Enums;

public class ProdutoTipo : Enumeration
{
    public static readonly ProdutoTipo Andaime = new ProdutoTipo(EProdutoTipo.Andaime, "Andaime");
    public static readonly ProdutoTipo Estronca = new ProdutoTipo(EProdutoTipo.Estronca, "Estronca");
    public static readonly ProdutoTipo Pranchao = new ProdutoTipo(EProdutoTipo.Pranchao, "Pranchao");
    public static readonly ProdutoTipo Rodana = new ProdutoTipo(EProdutoTipo.Rodana, "Rodana");

    public ProdutoTipo(EProdutoTipo pId, string pNome) 
        : base((int)pId, pNome)
    {
    }
}