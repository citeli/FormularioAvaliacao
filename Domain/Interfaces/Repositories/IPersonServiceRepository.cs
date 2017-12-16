using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IPersonServiceRepository : IServiceRepository<Person>
    {
        Person GetByName(string name);
    }
}
