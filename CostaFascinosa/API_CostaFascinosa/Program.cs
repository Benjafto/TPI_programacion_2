using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Implementacion;
using CostaFascinosa.Servicio.Interfaz;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using CostaFascinosa.Repositorio.Implementacion;
using CostaFascinosa.Repositorio.Interfaz;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<COSTA_FASCINOSAContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDefault")));


builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.WithOrigins("*")
           .AllowAnyMethod()
           .AllowAnyHeader();


}));


//INYECCIONES REPOSITORIOS
builder.Services.AddScoped<ICategoria_repository, Categoria_repository>();
builder.Services.AddScoped<ICodVestimenta_repository, CodVestimenta_repository>();
builder.Services.AddScoped<IZona_repository, Zona_repository>();
builder.Services.AddScoped<ITurno_repository, Turno_repository>();
builder.Services.AddScoped<IDestinatario_repository, Destinatario_repository>();
builder.Services.AddScoped<ICordinadore_repository, Cordinadore_repository>();
builder.Services.AddScoped<IPreferenciaAlimenticia, PreferenciasAlimenticias_repository>();
builder.Services.AddScoped<ITematica_repository, Tematica_repository>();
builder.Services.AddScoped<ITiposProducto_repository, TiposProducto_repository>();
builder.Services.AddScoped<ITiposServicio_repository, TiposServicio_repository>();
builder.Services.AddScoped<IPasajero_repository, Pasajero_repository>();
builder.Services.AddScoped<IActividade_repository, Actividade_repository>();
builder.Services.AddScoped<IAmenity_repository, Amenity_repository>();



//INYECCIONES SERVICIOS
builder.Services.AddScoped<ICategoria_service, Categoria_service>();
builder.Services.AddScoped<ICodVestimenta_service, CodVestimenta_service>();
builder.Services.AddScoped<IZona_service, Zona_service>();
builder.Services.AddScoped<ITurno_service, Turnos_serivce>();
builder.Services.AddScoped<IDestinatario_service, Destinatario_service>();
builder.Services.AddScoped<ICordinadore_service, Cordinadore_service>();
builder.Services.AddScoped<IPreferenciaAlimenticia_service, PreferenciaAlimenticia_service>();
builder.Services.AddScoped<ITematica_service, Tematica_service>();
builder.Services.AddScoped<ITiposProducto_service, TiposProducto_service>();
builder.Services.AddScoped<ITiposServicio_service, TiposServicio_service>();
builder.Services.AddScoped<IPasajero_service, Pasajero_service>();
builder.Services.AddScoped<IActividade_service, Actividade_service>();
builder.Services.AddScoped<IAmenity_service, Amenity_service>();


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



app.UseCors("MyPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
