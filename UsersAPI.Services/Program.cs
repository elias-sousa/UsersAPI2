using UsersAPI.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddRouting(a=> a.LowercaseUrls = true);
builder.Services.AddSwaggerDoc();


var app = builder.Build();

app.UseSwaggerDoc();

app.UseAuthorization();

app.MapControllers();

app.Run();
