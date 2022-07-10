using CleanArchitectureDemo.Fahrzeug.Adapter.Out.ServiceClient;
using CleanArchitectureDemo.Fahrzeug.Domain.Service;
using CleanArchitectureDemo.Fahrzeug.UseCase.In;
using CleanArchitectureDemo.Fahrzeug.UseCase.Out;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<FetchFahrzeug, FahrzeugService>();
builder.Services.AddScoped<FetchExternalFahrzeug, FahrzeugServiceClient>();

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
