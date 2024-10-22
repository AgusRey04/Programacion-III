using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = new SqliteConnection("Data source=DB-Ejemplo.db");
connection.Open();
using (var command = connection.CreateCommand())
{
    command.CommandText = "PRAGMA journal_mode = DELETE;";
    command.ExecuteNonQuery();
}
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlite(connection, b => b.MigrationsAssembly("Infrastructure"))
);


builder.Services.AddSingleton<IProfesorRepository, ProfesorRepository>();
builder.Services.AddSingleton<IProfesorService, ProfesorService>();
builder.Services.AddSingleton<IUsuarioService,UsuarioService>();
builder.Services.AddSingleton<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddSingleton<IAdministradorRepository, AdministradorRepository>();
builder.Services.AddSingleton<IAdministradorService, AdministradorService>();
builder.Services.AddSingleton<IClaseService, ClaseService>();
builder.Services.AddSingleton<IClasesRepository,ClaseRepository>();
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
