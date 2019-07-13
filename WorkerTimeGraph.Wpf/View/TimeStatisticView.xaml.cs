using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using System.Windows.Forms;
using WorkerTimeGraph.Core.ViewModel;

namespace WorkerTimeGraph.Wpf.View
{
    [MvxViewFor(typeof(TimeStatisticViewModel))]
    public partial class TimeStatisticView : MvxWpfView
    {
        public TimeStatisticView()
        {
            InitializeComponent();
        }

        private void Excel_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MessageBox.Show("Hello MessageBox");
        }
    }
}
