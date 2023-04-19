//using Serilog;

var builder = WebApplication.CreateBuilder(args);

//Log.Logger = new LoggerConfiguration().MinimumLevel.Information().WriteTo.File("log/villaLogs.txt", rollingInterval: RollingInterval.Hour).CreateLogger(); 
// Add services to the container.
//builder.Host.UseSerilog();

/// <summary>
/// B�l�m 4 ders 29,30a kurs sonunda bir daha bak. Gelen contentin ve d�nen contentin tipini ayarlamak i�in 30.kursa postman i�in 29. kursa bak.
/// </summary>
builder.Services.AddControllers(option => { 
    //option.ReturnHttpNotAcceptable = true; 
}).AddNewtonsoftJson();
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
