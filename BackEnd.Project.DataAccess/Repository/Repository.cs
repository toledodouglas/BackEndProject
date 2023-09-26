using BackEnd.Project.DataAccess.Data;
using BackEnd.Project.DataAccess.Repository.IRepository;
using BackEnd.Project.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Project.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly AppDbContext _db;
        internal DbSet<T> DbSet;
        public Repository(AppDbContext db)
        {
            this.DbSet = db.Set<T>();
            _db = db;
        }
        public T FindById(int id)
        {
            if (id == null) return null;
            IQueryable<T> query = DbSet;
            return query.FirstOrDefault(x => x.Id == id);

        }
   
        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

       
    }
}
