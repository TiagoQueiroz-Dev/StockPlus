using EstudosSolution.StockPlus.Domain.AggregatesModel.PessoaAggregate;
using EstudosSolution.StockPlus.Domain.Core;

namespace EstudosSolution.StockPlus.Domain.AggregatesModel.EnderecoAggregate;

public class Endereco : Entity
{
    public string Nome { get; set; }
    public string Municipio { get; set; }
    public string Uf { get; set; }
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Cep { get; set; }
    public string Complemento { get; set; }
    public int Numero { get; set; }
    public int? ModificadoPorPessoaId { get; set; }
    public DateTime? ModificadoDataHora { get; set; }

    public virtual IReadOnlyCollection<Pessoa> Pessoas { get; set; }
    public virtual Pessoa? ModificadoPor { get; set; }
}