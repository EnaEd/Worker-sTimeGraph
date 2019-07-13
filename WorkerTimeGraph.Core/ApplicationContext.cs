using MvvmCross;
using System.Configuration;
using System.Data.Entity;
using WorkerTimeGraph.Core.Interface;
using WorkerTimeGraph.Core.Model;

namespace WorkerTimeGraph.Core
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext():base(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
        {

        }
        DbSet<Staff> Staffs { get; set; }
    }
}
