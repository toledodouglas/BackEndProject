using BackEnd.Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace BackEnd.Project.DataAccess.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Mouse", Description = "Mouse", InStock = true, Price = 180, Quantity = 5, ImageUrl = "" },
                new Product { Id = 2, Name = "Teclado", Description = "Teclado", InStock = true, Price = 200, Quantity = 10, ImageUrl = "" },
                new Product { Id = 3, Name = "Monitor", Description = "Monitor", InStock = true, Price = 1500, Quantity = 10, ImageUrl = "" },
                new Product { Id = 4, Name = "Fone", Description = "Fone sem fio", InStock = true, Price = 150, Quantity = 20, ImageUrl = "" },
                new Product { Id = 5, Name = "Notebook", Description = "Notebook gamer", InStock = true, Price = 4000, Quantity = 15, ImageUrl = "" },
                new Product { Id = 6, Name = "Celular", Description = "IPhone", InStock = true, Price = 5000, Quantity = 8, ImageUrl = "" }
            );
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Client>().HasData(
                new Client {Id = 1, Name = "", CPF = "", Email = "", CellPhone = "", City = "", State = "", Street = "" }
                new Client { Id = 2, Name = "", CPF = "", Email = "", CellPhone = "", City = "", State = "", Street = "" }
                new Client { Id = 3, Name = "", CPF = "", Email = "", CellPhone = "", City = "", State = "", Street = "" }
                new Client { Id = 4, Name = "", CPF = "", Email = "", CellPhone = "", City = "", State = "", Street = "" }
                new Client { Id = 5, Name = "", CPF = "", Email = "", CellPhone = "", City = "", State = "", Street = "" }
            );
        }
    }
}
