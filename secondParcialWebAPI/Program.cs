using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using secondParcialWebAPI.Mapping;
using secondParcialWebAPI.Models;
using secondParcialWebAPI.Repositories;
using secondParcialWebAPI.Repositories.Interfaces;
using secondParcialWebAPI.Servicios;
using secondParcialWebAPI.Servicios.Interfaces;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//REPO Y SERVICES
builder.Services.AddScoped<ISocioRepository, SocioRepository>();
builder.Services.AddScoped<ISocioService, SocioService>();

builder.Services.AddScoped<IDeporteRepository, DeporteRepository>();
builder.Services.AddScoped<IDeporteService, DeporteService>();

//Fluent
builder.Services.AddFluentValidation((options) =>
    options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly())
);

//AUTOMAPPER
builder.Services.AddAutoMapper(typeof(MappingProfile));

//DbContext
builder.Services.AddDbContext<DbAa579fProg3w1Context>((context) =>
{
    context.UseSqlServer(builder.Configuration.GetConnectionString("socioDB"));
});


var app = builder.Build();

//CORS
app.UseCors(options =>
{
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
    options.AllowAnyHeader();
});

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
