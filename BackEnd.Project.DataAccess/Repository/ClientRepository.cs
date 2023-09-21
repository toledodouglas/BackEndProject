using BackEnd.Project.DataAccess.Data;
using BackEnd.Project.DataAccess.Repository.IRepository;
using BackEnd.Project.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Project.DataAccess.Repository
{
    public class ClientRepository : Repository<Client> , IClientRepository
    {

        private readonly SqlConnection connection;
        private AppDbContext _db;
        public ClientRepository(AppDbContext db) : base(db)
        {
            _db = db;

        }

        public IEnumerable<Client> GetAll()
        {
            return _db.Clients.AsEnumerable();
        }

    }
}
