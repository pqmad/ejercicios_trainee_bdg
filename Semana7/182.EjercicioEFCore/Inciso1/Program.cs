using Inciso1.Context;
using Inciso1.Services;
using Microsoft.EntityFrameworkCore;

namespace Inciso1;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddTransient<IAppDbContext, AppDbContext>();
        builder.Services.AddTransient<IColegioService, ColegioService>();

        // Configurar la configuración desde appsettings.json
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        // Leer la cadena de conexión desde appsettings.json
        var connectionString =
            configuration.GetConnectionString("DefaultConnection");

        // Agregar el contexto de la base de datos
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));


        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}

