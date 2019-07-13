using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows;
using System.Windows.Forms;
using WorkerTimeGraph.Core.Model;
using System.Linq;
using WorkerTimeGraph.Core.Reposotiries;

namespace WorkerTimeGraph.Core.ViewModel
{
    public class TimeStatisticViewModel : MvxViewModel
    {
        private List<Staff> _staffs;
        private StaffRepository _staffService;


        public TimeStatisticViewModel()
        {
            _staffService = new StaffRepository();
            InitData();
        }

        private void InitData()
        {
            Staffs = new List<Staff>();
            Staffs = _staffService.GetAll().ToList();
        }

        public List<Staff> Staffs
        {
            get => _staffs;
            set
            {
                _staffs = value;
                RaisePropertyChanged(nameof(Staffs));
            }
        }
        ICommand ConvertToExcelCommand => new MvxCommand(ConvertToExcel);

        private void ConvertToExcel()
        {
            MessageBox.Show("Hello MessageBox");
        }
    }
}
