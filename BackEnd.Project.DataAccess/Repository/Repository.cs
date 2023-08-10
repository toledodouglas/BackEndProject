using BackEnd.Project.DataAccess.Data;
using BackEnd.Project.DataAccess.Repository.IRepository;
using BackEnd.Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Project.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
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
            IQueryable<T> query = DbSet;
            return query.FirstOrDefault();
        }

      
    }
}
