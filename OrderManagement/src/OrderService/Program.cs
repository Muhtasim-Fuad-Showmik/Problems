using Microsoft.EntityFrameworkCore;
using OrderService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<OrderDbContext>(opt =>
{
    opt.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.UseAuthorization();

// Middleware for directing the HTTP request to the correct API endpoint
app.MapControllers();

// Seed dummy data into the application
try
{
    DbInitializer.InitDb(app);
}
catch (Exception e)
{
    Console.WriteLine(e);
}

app.Run();
