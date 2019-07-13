using SQLite;
using System;
using System.Collections.Generic;

using System.Text;
using WorkerTimeGraph.Core.Interface;
using WorkerTimeGraph.Core.Model;

namespace WorkerTimeGraph.Core.Reposotiries
{
    public class BaseRepository
    {
        public BaseRepository()
        {
            string applicationFolderPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "CanFindLocation");
            System.IO.Directory.CreateDirectory(applicationFolderPath);

            string databaseFileName = System.IO.Path.Combine(applicationFolderPath, "CanFindLocation.db");

            Database = new SQLiteConnection(databaseFileName);
            Database.CreateTable<Staff>();
            Database.CreateTable<TimeWorked>();
        }
        public SQLiteConnection Database { get; set; }
    }
}
