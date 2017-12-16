using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IServiceRepository<T> where T : class
    {
        bool Add(T obj);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        bool Update(T obj);
        bool Remove(T obj);
    }
}
