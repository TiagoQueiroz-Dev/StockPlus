using EstudosSolution.StockPlus.Domain.Core;

namespace EstudosSolution.StockPlus.Domain.Enums;

public class NotaStatusTipo : Enumeration
{
    public static readonly NotaStatusTipo Recolhido = new NotaStatusTipo(ENotaStatusTipo.Recolhido, "Recolhido");
    public static readonly NotaStatusTipo EmUso = new NotaStatusTipo(ENotaStatusTipo.EmUso, "EmUso");
    public static readonly NotaStatusTipo AguardandoCarregamento = new NotaStatusTipo(ENotaStatusTipo.AguardandoCarregamento, "AguardandoCarregamento");

    public NotaStatusTipo(ENotaStatusTipo pId, string pNome) 
        : base((int)pId, pNome)
    {
    }
}