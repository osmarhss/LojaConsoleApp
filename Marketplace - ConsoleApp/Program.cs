var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // Adiciona suporte a Controllers
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Para documentação Swagger

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers(); // Mapeia os controllers

app.Run();