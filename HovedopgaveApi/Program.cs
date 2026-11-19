using Microsoft.EntityFrameworkCore;
using RestBlaaBogLib;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BlaaBogDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.
        GetConnectionString("BlaaBogDBContext"));
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<BlaaBogDBContext>();

        if (!dbContext.Database.CanConnect())
        {
            throw new NotImplementedException("Can't connect to db");
        }
}

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
