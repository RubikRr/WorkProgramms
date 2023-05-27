namespace YandexDisk
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            //code=2073424
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}