using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MoodJournal;
using MoodJournal.Services;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

var builder1 = WebAssemblyHostBuilder.CreateDefault(args);
builder1.Services.AddBlazorise(options => { options.Immediate = true; })
                .AddBootstrapProviders()
                .AddFontAwesomeIcons();

builder1.RootComponents.Add<App>("#app");
await builder1.Build().RunAsync();


var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Specify the root component (App.razor) and attach it to the HTML <body>
builder.RootComponents.Add<App>("#app");

// Optional: Attach a <HeadOutlet /> for modifying the document head (e.g., <title>)
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register services
builder.Services.AddSingleton<MoodService>();

// Build and run the application
await builder.Build().RunAsync();

