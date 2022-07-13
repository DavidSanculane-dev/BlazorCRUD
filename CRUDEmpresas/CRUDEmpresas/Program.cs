using CRUDEmpresas.Data;
using Microsoft.EntityFrameworkCore;
using CRUDEmpresas;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CRUDEmpresas.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddDbContext<AppDBContext>(options => options.UseInMemoryDatabase("CompanyDB"));

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


builder.Services.AddScoped<ICompanyService, CompanyServices>();

await builder.Build().RunAsync();
