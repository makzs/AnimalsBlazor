using AnimalsBlazor.Components;
using AnimalsBlazor.Services;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMudServices();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient("DogApi", client =>
{
    client.BaseAddress = new Uri("https://dog.ceo/api/");

});

builder.Services.AddHttpClient("DuckApi", client =>
{
    client.BaseAddress = new Uri("https://random-d.uk/api/v2");

});

builder.Services.AddHttpClient("FoxApi", client =>
{
    client.BaseAddress = new Uri("https://randomfox.ca/");

});

builder.Services.AddScoped<IAnimalService, AnimalService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
