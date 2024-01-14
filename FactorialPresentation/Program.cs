using MathService;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! 10! = " + FactorialService.factorial(10)  + " 5! = " + FactorialService.factorial(5));

app.Run();
