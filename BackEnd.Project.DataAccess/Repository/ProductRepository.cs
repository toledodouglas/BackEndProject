using BackEnd.Project.DataAccess.Data;
using BackEnd.Project.DataAccess.Repository.IRepository;
using BackEnd.Project.Models;
using Microsoft.Data.SqlClient;
using NuGet.Protocol.Plugins;

namespace BackEnd.Project.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext _db;
        public ProductRepository(AppDbContext db) : base(db)
        {
            _db = db;

        }

        public IEnumerable<Product> GetAll()
        {
            return _db.Products.AsEnumerable();
        }

        


    }
}
