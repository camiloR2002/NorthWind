using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;
using Microsoft.Extensions.DependencyInjection;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices();


using IHost AppHost = Builder.Build();

IAppLoger Logger = AppHost.Services.GetRequiredService<IAppLoger>();
Logger.WriteLog("Application started");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.Add("Demo", "Azucar refinada");
