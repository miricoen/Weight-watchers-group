using Microsoft.EntityFrameworkCore;
using Serilog;
using Subscriber.Weight_Watchers.Configuration;
using Subscriber_.Services;
using Subscriberr.data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//���� �� ����� APPSETIINGS
ConfigurationManager configuration = builder.Configuration;

builder.Services.ConfigurationServices();

builder.Host.UseSerilog((context, configuration) =>
{

    ///����� �� ������ �������d 
    configuration.ReadFrom.Configuration(context.Configuration);

});


builder.Services.AddDbContext<SubacriberContext>(option =>
{
    ///������ ����� DB ������ 
    option.UseSqlServer(builder.Configuration.GetConnectionString("SubscriberData"), b => b.MigrationsAssembly("Weight Watchers"));
}
       );


builder.Services.AddControllers();
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

app.UseSerilogRequestLogging();

app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});


app.UseAuthorization();

app.MapControllers();

app.UseMiddleware(typeof(ErrorHandlingMiddleware));

app.Run();
