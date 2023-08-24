using BackEnd.Project.DataAccess.Data;
using BackEnd.Project.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Project.DataAccess.Repository
{
    public class UnitOfWork :IUnitOfWork
    {
        private AppDbContext _db;
        public IProductRepository Product { get; private set; }
        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            Product = new ProductRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
