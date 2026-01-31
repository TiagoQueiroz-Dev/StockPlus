using EstudosSolution.StockPlus.Domain.AggregatesModel.PessoaAggregate;
using EstudosSolution.StockPlus.Domain.Core;
using EstudosSolution.StockPlus.Domain.Enums;

namespace EstudosSolution.StockPlus.Domain.AggregatesModel.ProdutoAggregate;

public class Produto : Entity
{
    public int ProdutoTipoId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal ValorUnitario { get; set; }
    public decimal ValorAluguel { get; set; }
    public bool Ativo { get; set; }
    public int? ModificadoPorPessoaId { get; set; }
    public DateTime? ModificadoDataHora { get; set; }

    public virtual ProdutoTipo? ProdutoTipo { get; set; }
    public virtual Pessoa? ModificadoPor { get; set; }
}