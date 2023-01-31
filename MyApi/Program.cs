var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/teste", () => "Hello World!");

// O de cima é como se fosse o debaixo
// app.MapGet("/", () =>
// {
//     return "Hello World!";
// } );

app.MapGet("/", () =>
{
    return Results.Ok("Hello World"); // Results.Ok coloca o status 200
} );

// app.MapGet("/{nome}", (string nome) =>
// {
//     return Results.Ok($"Hello {nome}");
// } );

app.MapPost("/", (User user) =>
{
    return Results.Ok(user);
});

app.Run();

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
}