namespace MinhaApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", Ola);

            app.MapGet("/{nome}", (string nome) =>
            {
                return $"Olá {nome}, seja bem vindo";
            });

            app.MapPost("/", (Usuario usuario) =>
            {
                usuario.Id++;
                usuario.Nome = string.Concat(usuario.Nome, " Teste");
                return usuario;
            });

            app.Run();
        }
        public static string Ola()
        {
            return "Hello Word!";
        }
    }
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
    }
}

//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//
//app.MapGet("/", () => "Hello World!");
//
//app.Run();
