using MvvmCross;
using System.Configuration;
using System.Data.Entity;
using System.Data.SQLite;
using WorkerTimeGraph.Core.Interface;
using WorkerTimeGraph.Core.Model;

namespace WorkerTimeGraph.Core
{
    public class ApplicationContext 
    {
        private SQLiteConnection _database;
        public ApplicationContext()
        {
            var t = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<TimeWorked> TimeWorkeds { get; set; }
    }
}
