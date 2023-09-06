using System.Text.RegularExpressions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

var categorias = new List<Categoria>
{
    new Categoria { Id = 1, Nombre = "Categor�a 1" },
    new Categoria { Id = 2, Nombre = "Categor�a 2" },
};

app.MapGet("/categorias", () =>
{


return categorias;
});

app.Run();

internal class Categoria
{
    public int Id { get; set; }
    public string Nombre { get; set; }
}