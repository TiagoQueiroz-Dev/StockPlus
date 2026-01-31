using EstudosSolution.StockPlus.Application.Logging;
using EstudosSolution.StockPlus.Infra;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(p =>
        {
            p.EnableAnnotations();
        }
    );
    builder.Services.AddControllers();
    builder.Services.AdicionarServicosStockPlus();
    builder.Host.UseNLog();

    var xTeste = builder.Configuration.GetConnectionString("NetunoContext");
}

var app = builder.Build();
{
    app.Use(ResponseLogging.Log);
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapControllers();

    app.Run();
}
