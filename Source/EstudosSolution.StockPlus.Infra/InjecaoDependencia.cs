using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EstudosSolution.StockPlus.Infra;

public static class InjecaoDependencia
{
    public static IServiceCollection AdicionarServicosStockPlus(this IServiceCollection pServiceCollection)
    {
        // return pServiceCollection
        //     .AddScoped<>();

        var xRetorno = new ServiceCollection();
        return xRetorno;
    }
}
