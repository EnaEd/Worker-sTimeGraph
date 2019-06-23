using System;
using System.Collections.Generic;
using System.Text;
using WorkerTimeGraph.Core.Model;

namespace WorkerTimeGraph.Core.Interface
{
    public interface IStaffService
    {
        IEnumerable<Staff> GetAll();
        Staff Get(int Id);
        void Update(Staff staff);
        void Delete(int id);
        void Create(Staff staff);
    }
}
