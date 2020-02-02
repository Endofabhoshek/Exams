using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams.ServiceInterfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Init(string connectionString = "name = EFDbContext");
        IDisposable CreateTransaction();

        int SaveChanges();
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        //IRepositoryWithId<TEntity> GetRepositoryByType<TEntity>() where TEntity : class, IModelWithId;
        DbSet Set(Type type);

    }
}
