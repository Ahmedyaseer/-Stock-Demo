using Microsoft.EntityFrameworkCore;
using Small_Stock_Project.Repos.ItemRepo;
using Small_Stock_Project.Repos.StoreRepo;

namespace Small_Stock_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region Database 

            string? connectionString = builder.Configuration.GetConnectionString("StockConnectionString");

            builder.Services.AddDbContext<StockContext>(options =>
            options.UseSqlServer(connectionString));

            #endregion

            builder.Services.AddScoped<IStoreRepo, StoreRepo>();
            builder.Services.AddScoped<IItemRepo, ItemRepo>();
            builder.Services.AddScoped<IStoreItemRepo, StoreItemRepo>();    

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}