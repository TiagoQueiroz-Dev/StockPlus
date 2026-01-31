using EstudosSolution.StockPlus.Domain.Core;

namespace EstudosSolution.StockPlus.Domain.Enums;

public class ContratoTipo : Enumeration
{
    public static readonly ContratoTipo Completa = new ContratoTipo(EContratoTipo.Completa, "Completa");
    public static readonly ContratoTipo Mensal = new ContratoTipo(EContratoTipo.Mensal, "Mensal");
    public static readonly ContratoTipo Semanal = new ContratoTipo(EContratoTipo.Semanal, "Semanal");
    public static readonly ContratoTipo Diario = new ContratoTipo(EContratoTipo.Diario, "Diario");

    public ContratoTipo(EContratoTipo pId, string pNome) 
        : base((int)pId, pNome)
    {
    }
}