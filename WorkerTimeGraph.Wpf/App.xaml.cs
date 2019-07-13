using System.Windows;
using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;

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
            //Mvx.IoCProvider.RegisterType<IConnectionStringService, ConnectionStringService>();
            //Mvx.IoCProvider.RegisterSingleton<IConnectionStringService>(() => new ConnectionStringService());
        }
    }
}
