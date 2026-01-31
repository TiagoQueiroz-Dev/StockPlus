using EstudosSolution.StockPlus.Domain.AggregatesModel.EnderecoAggregate;
using EstudosSolution.StockPlus.Domain.AggregatesModel.PessoaAggregate;
using EstudosSolution.StockPlus.Domain.Core;
using EstudosSolution.StockPlus.Domain.Enums;

namespace EstudosSolution.StockPlus.Domain.AggregatesModel.NotaAggregate;

public class Nota : Entity
{
    public int EnderecoId { get; set; }
    public int ContratoTipoId { get; set; }
    public int NotaStatusId { get; set; }
    public int PessoaId { get; set; }
    public DateTime PrevisaoEntregaDataHora { get; set; }
    public DateTime PrevisaoRecolhimentoDataHora { get; set; }
    public decimal ValorTotal { get; set; }
    public int? ModificadoPorPessoaId { get; set; }
    public DateTime? ModificadoDataHora { get; set; }
    public string? Observacao { get; set; }

    public virtual Pessoa? Pessoa { get; set; }
    public virtual NotaStatusTipo? NotaStatus { get; set; }
    public virtual ContratoTipo? ContratoTipo { get; set; }
    public  virtual Endereco? Endereco { get; set; }
    public virtual Pessoa? ModificadoPor { get; set; }
}