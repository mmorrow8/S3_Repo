namespace S3_Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            builder.Services.AddHttpClient();  // Register HttpClient for DI

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapRazorPages();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=USStateDocumentOutput}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
