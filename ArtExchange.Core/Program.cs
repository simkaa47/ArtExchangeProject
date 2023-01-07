using ArtExchange.Api;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container
ServiceBuilder.GetServiceCollection(builder.Services, builder.Configuration);




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
