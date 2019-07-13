using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows;
using System.Windows.Forms;
using WorkerTimeGraph.Core.Model;
using WorkerTimeGraph.Core.Services;
using System.Linq;

namespace WorkerTimeGraph.Core.ViewModel
{
    public class TimeStatisticViewModel : MvxViewModel
    {
        private List<Staff> _staffs;
        private StaffService _staffService;


        public TimeStatisticViewModel()
        {
            _staffService = new StaffService();
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
