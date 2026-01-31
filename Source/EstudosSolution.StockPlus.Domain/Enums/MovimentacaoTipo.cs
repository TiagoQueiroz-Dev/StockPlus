using EstudosSolution.StockPlus.Domain.Core;

namespace EstudosSolution.StockPlus.Domain.Enums;

public class MovimentacaoTipo : Enumeration
{
    private static readonly MovimentacaoTipo RecolhimentoParcial = new MovimentacaoTipo(EMovimentacaoTipo.RecolhimentoParcial, "RecolhimentoParcial");
    private static readonly MovimentacaoTipo Recolhimento = new MovimentacaoTipo(EMovimentacaoTipo.Recolhimento, "Recolhimento");
    private static readonly MovimentacaoTipo Ajuste = new MovimentacaoTipo(EMovimentacaoTipo.Ajuste, "Ajuste");
    private static readonly MovimentacaoTipo Aluguel = new MovimentacaoTipo(EMovimentacaoTipo.Aluguel, "Aluguel");
    private static readonly MovimentacaoTipo Saida = new MovimentacaoTipo(EMovimentacaoTipo.Saida, "Saida");
    private static readonly MovimentacaoTipo Entrada = new MovimentacaoTipo(EMovimentacaoTipo.Entrada, "Entrada");

    public MovimentacaoTipo(EMovimentacaoTipo pId, string pNome) 
        : base((int)pId, pNome)
    {
    }
}