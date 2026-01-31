using EstudosSolution.StockPlus.Domain.AggregatesModel.PessoaAggregate;

namespace EstudosSolution.StockPlus.Domain.Core;

public abstract class Entity
{
    public int Id { get; set; }
    public DateTime CriadoDataHora { get; set; }
    public int CriadoPorPessoaId { get; set; }
    public bool Excluido { get; set; }

    public Pessoa? CriadoPorPessoa { get; set; }
}