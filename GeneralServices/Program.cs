var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyLocalhost", builder =>
    {
        builder.SetIsOriginAllowed(origin =>
        {
            // Permite cualquier localhost
            return new Uri(origin).Host == "localhost";
        })
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "GeneralServices API v1");
        c.RoutePrefix = "swagger";
    });
//}

app.UseCors("AllowAnyLocalhost");
//app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

// optional but important
app.MapGet("/", () => "GeneralServices API is running");

app.Run();
