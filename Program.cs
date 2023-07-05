using API.Context;
using API.Repositories.Data;
using API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//configurs DbContext to sql database sever
var connectionString = builder.Configuration.GetConnectionString(name: "Default Connection");
builder.Services.AddDbContext<MyContext>(optionsAction :options=>
options.UseSqlServer(connectionString));

//Add dependency injection for repository
builder.Services.AddScoped<IUniversityRepository, UniversityRepository>();

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
