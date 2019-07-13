using System;
using System.Collections.Generic;
using System.Text;
using WorkerTimeGraph.Core.Model;

namespace WorkerTimeGraph.Core.Interface
{
    public interface ICRUDService<T> where T:class
    {
        IEnumerable<T> GetAll();
        T Get(int Id);
        void Update(T staff);
        void Delete(int id);
        void Create(T staff);
    }
}
