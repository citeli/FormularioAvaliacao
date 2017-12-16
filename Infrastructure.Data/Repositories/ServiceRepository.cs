using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class ServiceRepository : IServiceRepository<EntityBase>
    {
        private readonly ContextModel<EntityBase> _context;

        public ServiceRepository(ContextModel<EntityBase>)
        {
        }

        public bool Add(EntityBase obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EntityBase> GetAll()
        {
            throw new NotImplementedException();
        }

        public EntityBase GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(EntityBase obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(EntityBase obj)
        {
            throw new NotImplementedException();
        }
    }
}
