using ScreenSound.Banco;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
var app = builder.Build();

app.MapGet("/", () => 
{
    var dal = new Dal<Artista>(new ScreenSoundContext());
    return dal.Listar();
});

app.Run();
