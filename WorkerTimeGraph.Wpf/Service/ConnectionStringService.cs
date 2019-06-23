using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerTimeGraph.Core.Interface;

namespace WorkerTimeGraph.Wpf.Service
{
    public class ConnectionStringService : IConnectionStringService
    {
        public ConnectionStringService()
        {

        }
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
    }
}
