using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using pruebas_tickets.Data;
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<pruebas_ticketsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("pruebas_ticketsContext")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Tickets", Version = "v1" });
});

var app = builder.Build();
app.UseCors(options =>
{
    options.WithOrigins("https://localhost:7051");
    options.AllowAnyMethod();
    options.AllowAnyHeader();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("../swagger/v1/swagger.json", "Tickets V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseRouting(); 

app.UseAuthorization();


app.Run();
