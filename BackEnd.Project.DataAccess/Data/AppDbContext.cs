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
                new Product { Id = 1, Name = "Mouse", Description = "Mouse", Price = 180, Quantity = 5, ImageUrl = "" },
                new Product { Id = 2, Name = "Teclado", Description = "Teclado", Price = 200, Quantity = 10, ImageUrl = "" },
                new Product { Id = 3, Name = "Monitor", Description = "Monitor", Price = 1500, Quantity = 10, ImageUrl = "" },
                new Product { Id = 4, Name = "Fone", Description = "Fone sem fio", Price = 150, Quantity = 20, ImageUrl = "" },
                new Product { Id = 5, Name = "Notebook", Description = "Notebook gamer", Price = 4000, Quantity = 15, ImageUrl = "" },
                new Product { Id = 6, Name = "Celular", Description = "IPhone", Price = 5000, Quantity = 8, ImageUrl = "" }
            );
            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, CPF = "139.142.890-07", CellPhone = "(49) 97382-6076", City = "Florianópolis", Email = "douglas1@gmail.com", Name = "Douglas", State = "Santa Catarina", Street = "Rua guilherme jacobe buch" },
                new Client { Id = 2, CPF = "817.839.909-10", CellPhone = "(47) 98391-7448", City = "Florianópolis", Email = "liryel1@gmail.com", Name = "Liryel", State = "Santa Catarina", Street = "Rua João Jorge Mussi" },
                new Client { Id = 3, CPF = "138.626.369-92", CellPhone = "(47) 98812-4127", City = "Florianópolis", Email = "lucca1@gamil.com", Name = "Lucca", State = "Santa Catarina", Street = "Rua Sergio Candido" },
                new Client { Id = 4, CPF = "181.347.109-64", CellPhone = "(47) 97994-6368", City = "Florianópolis", Email = "beatriz1@gmail.com", Name = "Beatriz", State = "Santa Catarina", Street = "Av Rio Branco" },
                new Client { Id = 5, CPF = "186.759.379-38", CellPhone = "(47) 99143-4539", City = "Florianópolis", Email = "amanda1@gmail.com", Name = "Amanda", State = "Santa Catarina", Street = "Rua Tenente Silveira" }

            );
        }

        public static implicit operator AppDbContext(string v)
        {
            throw new NotImplementedException();
        }
    }
}
