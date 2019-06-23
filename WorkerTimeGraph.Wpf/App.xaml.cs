using System.Windows;
using MvvmCross;
using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;
using WorkerTimeGraph.Core.Interface;
using WorkerTimeGraph.Wpf.Service;

namespace WorkerTimeGraph.Wpf
{
    
    public partial class App : MvxApplication
    {
        public App()
        {
            this.RegisterSetupType<MvxWpfSetup<Core.App>>();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            //Mvx.IoCProvider.RegisterSingleton<IConnectionStringService>(() => new ConnectionStringService());
        }
    }
}
