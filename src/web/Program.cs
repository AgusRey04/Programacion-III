using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
