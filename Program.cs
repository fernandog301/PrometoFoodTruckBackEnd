var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<AppServices>();
builder.Services.AddScoped<UserServices>();
builder.Services.AddScoped<PasswordService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
var connectionString = builder.Configuration.GetConnectionString("PrometoString")

builder.Services.AddDbContext<DataContext>(Options => Options.UseSQLServer(connectionString));

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
