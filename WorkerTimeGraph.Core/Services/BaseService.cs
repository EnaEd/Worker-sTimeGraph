using System;
using System.Collections.Generic;
using System.Text;
using WorkerTimeGraph.Core.Interface;

namespace WorkerTimeGraph.Core.Services
{
    public class BaseService<T> : ICRUDService<T> where T : class
    {
        public void Create(T staff)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T staff)
        {
            throw new NotImplementedException();
        }
    }
}
