using Microsoft.EntityFrameworkCore;
using System;
namespace task
{
    class Program
    {
        public static void Main(string[] args)
        {
            //using (var context = new Context())
            //{
            //    context.categories.Add(new Category() { Name = "Horror" });
            //    context.categories.Add(new Category() { Name = "Sci fi" });
            //    context.SaveChanges();
            //    context.basicLists.Add(new BasicList() { Name = "Smile", Cat = context.categories.First(it => it.Name == "Horror") });
            //    context.basicLists.Add(new BasicList() { Name = "No", Cat = context.categories.First(it => it.Name == "Horror") });
            //    context.basicLists.Add(new BasicList() { Name = "Pearl", Cat = context.categories.First(it => it.Name == "Horror") });
            //    context.basicLists.Add(new BasicList() { Name = "Interstellar", Cat = context.categories.First(it => it.Name == "Sci fi") });
            //    context.basicLists.Add(new BasicList() { Name = "Dune", Cat = context.categories.First(it => it.Name == "Sci fi") });
            //    context.SaveChanges();

            //}
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddRazorPages();

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

            app.Run();
        }
    }
}