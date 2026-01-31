using EstudosSolution.StockPlus.Domain.AggregatesModel.EnderecoAggregate;
using EstudosSolution.StockPlus.Domain.Core;
using EstudosSolution.StockPlus.Domain.Enums;

namespace EstudosSolution.StockPlus.Domain.AggregatesModel.PessoaAggregate;

public class Pessoa : Entity
{
    public string Nome { get; set; }
    public string Apelido { get; set; }
    public string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Telefone { get; set; }
    public int PessoaTipoId { get; set; }
    public bool Situacao { get; set; }
    public int? ModificadoPorPessoaId { get; set; }
    public DateTime? ModificadoDataHora { get; set; }

    public virtual IReadOnlyCollection<Endereco> Enderecos { get; set; }
    public virtual Pessoa? ModificadoPor { get; set; }
    public PessoaTipo? PessoaTipo { get; set; }
}