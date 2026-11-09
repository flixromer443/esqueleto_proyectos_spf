using Data;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Npgsql;
using Slamdunk.WebApi.Hubs;

var builder = WebApplication.CreateBuilder(args);

// 1. Configurar Servicios y Dependencias PRIMERO
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();

var configuration = builder.Configuration;

var frontendUrl = configuration["FRONTEND_URL"];

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Configuraci�n de CORS (�Antes de builder.Build()!)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AngularApp", policyBuilder =>
    {
        policyBuilder.WithOrigins(
            frontendUrl ?? ""
        )
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
    });
});

// Configuraci�n de Base de Datos
var dbHost = configuration["DB_HOST"];
var dbPort = configuration["DB_PORT"];
var dbName = configuration["DB_NAME"];
var dbUser = configuration["DB_USER"];
var dbPass = configuration["DB_PASSWORD"];

var builderDb = new NpgsqlConnectionStringBuilder
{
    Host = string.IsNullOrWhiteSpace(dbHost) ? "sigcap-postgres" : dbHost,
    Port = int.TryParse(dbPort, out var parsedPort) ? parsedPort : 5432,
    Database = string.IsNullOrWhiteSpace(dbName) ? "SIGCAP_V02" : dbName,
    Username = string.IsNullOrWhiteSpace(dbUser) ? "admin" : dbUser,
    Password = string.IsNullOrWhiteSpace(dbPass) ? "admin" : dbPass
};

var connectionString = builderDb.ConnectionString;

builder.Services.AddDbContext<SigcapDbContext>(options =>
    options.UseNpgsql(connectionString));

// 2. Construir la aplicaci�n UNA SOLA VEZ
var app = builder.Build();

// 3. Registrar Logs de inicio
var logger = app.Logger;
logger.LogInformation("======================================");
logger.LogInformation("INICIANDO BACKEND");
logger.LogInformation("======================================");
logger.LogInformation("Environment: {Environment}", app.Environment.EnvironmentName);
logger.LogInformation("FRONTEND_URL: {frontendUrl}", frontendUrl);
logger.LogInformation("Connection string configurada correctamente");   
logger.LogInformation("======================================");

// 4. Configurar el Pipeline HTTP (�El orden de los Use... importa much�simo!)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// CORS DEBE IR ANTES de MapControllers y MapHub
app.UseCors("AngularApp");

app.MapControllers();
app.MapHub<BingoHub>("/bingoHub");

// =======================================================================
// NUEVO: EJECUTAR MIGRACIONES AUTOM�TICAS EN LA BASE DE DATOS DE RENDER
// =======================================================================
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<SigcapDbContext>();

        logger.LogInformation("Verificando si existen migraciones pendientes...");
        if (context.Database.GetPendingMigrations().Any())
        {
            logger.LogInformation("Aplicando migraciones en la base de datos de Render...");
            context.Database.Migrate();
            logger.LogInformation("�Migraciones aplicadas con �xito!");
        }
        else
        {
            logger.LogInformation("La base de datos ya est� actualizada. No se requieren cambios.");
        }
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "ERROR FATAL: No se pudieron aplicar las migraciones al iniciar.");
    }
}
// =======================================================================

app.Run();
