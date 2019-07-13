using System;
using System.Collections.Generic;
using System.Text;
using WorkerTimeGraph.Core.Interface;
using WorkerTimeGraph.Core.Model;

namespace WorkerTimeGraph.Core.Reposotiries
{
    public class StaffRepository :BaseRepository, ICRUDService<Staff>
    {
        public void Create(Staff staff)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Staff Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Staff> GetAll()
        {
            return Database.Table<Staff>().ToList();
        }

        public void Update(Staff staff)
        {
            throw new NotImplementedException();
        }
    }
}
