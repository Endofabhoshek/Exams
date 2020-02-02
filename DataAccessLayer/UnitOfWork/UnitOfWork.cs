using Exams.ServiceInterfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed = false;

        public IDisposable CreateTransaction()
        {
            throw new NotImplementedException();
        }

        public void Dispose(bool disposing)
        {
            if (_disposed)
            {
                if (disposing)
                {
                    if (_context != null)
                    {
                        
                    }
                }
            }
        }

        public void Init(string connectionString = "name=Exams")
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public DbSet Set(Type type)
        {
            throw new NotImplementedException();
        }
    }
}
