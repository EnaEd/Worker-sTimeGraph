using MvvmCross;
using System.Data.Entity;
using WorkerTimeGraph.Core.Interface;
using WorkerTimeGraph.Core.Model;

namespace WorkerTimeGraph.Core
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext():base(Mvx.IoCProvider.Resolve<IConnectionStringService>().GetConnectionString())
        {

        }
        DbSet<Staff> Staffs { get; set; }
    }
}
