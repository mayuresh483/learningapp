using Microsoft.FeatureManagement;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration.AddAzureAppConfiguration(
    option =>
    {
        option.Connect("Endpoint=https://learningazure-appconfig.azconfig.io;Id=s4F7;Secret=1h0nr3oG5gdGfkWVqowUAHsdhx1SVSOqIaZeOdWQTPhc6fxskLweJQQJ99BEACi5YpzJUGLxAAACAZAC2cpz");
        option.UseFeatureFlags();
    }
);
builder.Services.AddFeatureManagement();

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
