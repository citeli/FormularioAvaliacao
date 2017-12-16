using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.DataContext
{
    public class ContextModel<T> where T : EntityBase
    {
        private static List<T> people = new List<T>();

        public void Add(T obj)
        {
            people.Add(obj);
        }

    }
}
