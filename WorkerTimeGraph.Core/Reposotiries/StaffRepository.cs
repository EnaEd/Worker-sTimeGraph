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
            Staff staffTemp = Database.Find<Staff>(staff.Id);
            if (staffTemp is null)
            {
                Database.Insert(staff);
            }
        }

        public void Delete(Staff staff)
        {
            Database.Delete(staff);
        }

        public Staff Get(int id)
        {
            Staff staff = Database.Find<Staff>(id);
            if (staff is null)
            {
                return null;
            }
            return staff;

        }

        public IEnumerable<Staff> GetAll()
        {
            return Database.Table<Staff>().ToList();
        }

        public void Update(Staff staff)
        {
            Staff staffTemp = Database.Find<Staff>(staff.Id);
            if (staffTemp is null)
            {
                return;
            }
                Database.Update(staff);
        }
    }
}
