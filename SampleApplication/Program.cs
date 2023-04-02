namespace SampleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddMvc();

            var app = builder.Build();

           app.UseStaticFiles();
           app.UseRouting();
           app.UseEndpoints(d => d.MapControllers());

           app.Run();
        }
    }
}