using System;
using System.Collections.Generic;
using Domain.Interfaces.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Data.DataContext;

namespace Infrastructure.Data.Repositories
{
    public class PersonServiceRepository : IPersonServiceRepository
    {
        private readonly ContextModel<Person> _context;

        public PersonServiceRepository()
        {
            _context = context;
        }

        public bool Add(Person obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Person GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Person obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Person obj)
        {
            throw new NotImplementedException();
        }
    }
}
