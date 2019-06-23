using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
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
    }
}
