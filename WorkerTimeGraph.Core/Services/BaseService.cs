using SQLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;

using System.Diagnostics;
using System.Linq;
using System.Text;
using WorkerTimeGraph.Core.Interface;
using WorkerTimeGraph.Core.Model;

namespace WorkerTimeGraph.Core.Services
{
    public class BaseService<T> : ICRUDService<T> where T : class
    {
        private SQLiteConnection  _context;
        public BaseService()
        {
            string applicationFolderPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "CanFindLocation");
            System.IO.Directory.CreateDirectory(applicationFolderPath);

            string databaseFileName = System.IO.Path.Combine(applicationFolderPath, "CanFindLocation.db");

            _context = new SQLiteConnection(databaseFileName);
            _context.CreateTable<Staff>();
            _context.CreateTable<TimeWorked>();
        }
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
            IEnumerable<Staff> staffs = _context.Table<Staff>().ToList();

            return staffs as IEnumerable<T>;
        }

        public void Update(T staff)
        {
            throw new NotImplementedException();
        }
    }
}
