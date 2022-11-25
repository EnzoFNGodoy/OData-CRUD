using Microsoft.AspNetCore.OData;
using ODataCrud.Application.Interfaces;
using ODataCrud.Application.Services;
using ODataCrud.Domain.Interfaces;
using ODataCrud.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddOData(opt =>
    {
        opt.Select().Count().Filter().OrderBy().SetMaxTop(100).SkipToken().Expand();
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerServices, CustomerServices>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();