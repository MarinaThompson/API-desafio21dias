using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace API_Pais
{
    public class Program
    {
        public static string AlunoApi = null;
        public static string MongoCnn = null;

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
