using EstudosSolution.StockPlus.Domain.AggregatesModel.PessoaAggregate;
using EstudosSolution.StockPlus.Domain.AggregatesModel.ProdutoAggregate;
using EstudosSolution.StockPlus.Domain.Core;

namespace EstudosSolution.StockPlus.Domain.AggregatesModel.EstoqueAggregate;

public class Estoque : Entity
{
    public int ProdutoId { get; set; }
    public int QuantidadeAtual { get; set; }
    public int QuantidadeMinima { get; set; }
    public int QuantidadeMaxima { get; set; }
    public int? ModificadoPorPessoaId { get; set; }
    public DateTime? ModificadoDataHora { get; set; }

    public virtual Pessoa? ModificadoPor { get; set; }
    public virtual Produto? Produto { get; set; }
}