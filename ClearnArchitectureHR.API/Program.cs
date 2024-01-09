using CleanArchitectureHR.Application.Extensions;
using ClearnArchitectureHR.Infrastructure.Extensions;
using ClearnArchitectureHR.Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);

//1- Add services to the container.
builder.Services.AddApplicationLayer();
builder.Services.AddInfrastructureLayer();
builder.Services.AddPersistenceLayer(builder.Configuration);

//2-Eviter l'erreur cors
builder.Services.AddCors(o => o.AddPolicy(name: "HrSystem",
    policy =>
    {
        policy
        .WithOrigins("http://localhost:4200")
        .AllowAnyMethod()
        .AllowAnyHeader();
    }));

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

app.UseAuthorization();

app.MapControllers();

//Eviter erreur cors
app.UseCors("HrSystem");

app.Run();
