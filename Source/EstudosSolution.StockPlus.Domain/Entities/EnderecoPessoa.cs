using EstudosSolution.StockPlus.Domain.AggregatesModel.EnderecoAggregate;
using EstudosSolution.StockPlus.Domain.AggregatesModel.PessoaAggregate;
using EstudosSolution.StockPlus.Domain.Core;

namespace EstudosSolution.StockPlus.Domain.Entities;

public class EnderecoPessoa : Entity
{
    public int EnderecoId { get; set; }
    public int PessoaId { get; set; }

    public virtual Endereco? Endereco { get; set; }
    public virtual Pessoa? Pessoa { get; set; }
}