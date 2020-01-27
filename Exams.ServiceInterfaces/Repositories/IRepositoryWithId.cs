using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams.ServiceInterfaces.Repositories
{
    public interface IRepositoryWithId<TEntityWithId> : IRepository<TEntityWithId> where TEntityWithId : class, IModel
    {
        void RemoveById(int id);
        void RemoveByIds(IEnumerable<int> ids);
        TEntityWithId GetById(int id);
        List<TEntityWithId> GetAll();
    }
}
