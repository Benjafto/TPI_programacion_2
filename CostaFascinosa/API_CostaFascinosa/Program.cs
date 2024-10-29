using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Implementacion;
using CostaFascinosa.Servicio.Interfaz;
using CostaFascinosa.Servicio.Interfaz;
using CostaFascinosa.Servicio.Implementacion;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using CostaFascinosa.Repositorio.Implementacion;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<COSTA_FASCINOSAContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDefault")));

//INYECCIONES REPOSITORIOS
builder.Services.AddScoped<ICategoria_repository, Categoria_repository>();
builder.Services.AddScoped<ICodVestimenta_repository, CodVestimenta_repository>();
builder.Services.AddScoped<IZona_repository, Zona_repository>();
builder.Services.AddScoped<ITurno_repository, Turno_repository>();

//INYECCIONES SERVICIOS
builder.Services.AddScoped<ICategoria_service, Categoria_service>();
builder.Services.AddScoped<ICodVestimenta_service, CodVestimenta_service>();
builder.Services.AddScoped<IZona_service, Zona_service>();
builder.Services.AddScoped<ITurno_service, Turnos_serivce>();



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
