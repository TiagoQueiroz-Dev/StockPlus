using EstudosSolution.StockPlus.Domain.AggregatesModel.PessoaAggregate;
using EstudosSolution.StockPlus.Domain.AggregatesModel.ProdutoAggregate;
using EstudosSolution.StockPlus.Domain.Core;

namespace EstudosSolution.StockPlus.Domain.AggregatesModel.NotaAggregate;

public class NotaItem : Entity
{
    public int NotaId { get; set; }
    public int ProdutoId { get; set; }
    public int Quantidade { get; set; }
    public decimal ValorUnitario { get; set; }
    public decimal ValorTotal { get; set; }
    public int? ModificadoPorPessoaId { get; set; }
    public DateTime? ModificadoDataHora { get; set; }

    public virtual Pessoa? ModificadoPor { get; set; }
    public virtual Produto? Produto { get; set; }
    public virtual Nota? Nota { get; set; }
}