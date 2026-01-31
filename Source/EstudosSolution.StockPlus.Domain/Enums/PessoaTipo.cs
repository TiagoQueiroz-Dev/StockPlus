using EstudosSolution.StockPlus.Domain.Core;

namespace EstudosSolution.StockPlus.Domain.Enums;

public class PessoaTipo : Enumeration
{
    public static readonly PessoaTipo Tiago = new PessoaTipo(EPessoaTipo.Tiago, "Tiago");
    public static readonly PessoaTipo Pessoa = new PessoaTipo(EPessoaTipo.Pessoa, "Pessoa");
    public static readonly PessoaTipo PessoaFisica = new PessoaTipo(EPessoaTipo.PessoaFisica, "PessoaFisica");

    public PessoaTipo(EPessoaTipo pId, string pNome) 
        : base((int)pId, pNome)
    {
    }
}