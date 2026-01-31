using EstudosSolution.StockPlus.Domain.AggregatesModel.EnderecoAggregate;
using EstudosSolution.StockPlus.Domain.AggregatesModel.EstoqueAggregate;
using EstudosSolution.StockPlus.Domain.AggregatesModel.NotaAggregate;
using EstudosSolution.StockPlus.Domain.AggregatesModel.PessoaAggregate;
using EstudosSolution.StockPlus.Domain.AggregatesModel.ProdutoAggregate;
using EstudosSolution.StockPlus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstudosSolution.StockPlus.Infra.Contexts;

public class StockPlusContext : DbContext
{
    private StockPlusContext(DbContextOptions<StockPlusContext> pDbContextOptions) 
        : base(pDbContextOptions)
    {
    }

    public DbSet<Pessoa> Pessoas => Set<Pessoa>();
    public DbSet<Produto> Produtos => Set<Produto>();
    public DbSet<Endereco> Enderecos => Set<Endereco>();
    public DbSet<Estoque> Estoques => Set<Estoque>();
    public DbSet<Nota> Notas => Set<Nota>();
    public DbSet<NotaItem> NotaItens => Set<NotaItem>();
    public DbSet<EnderecoPessoa> EnderecoPessoa => Set<EnderecoPessoa>();
}
