using System;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using WorkerTimeGraph.Core.ViewModel;

namespace WorkerTimeGraph.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            RegisterAppStart<TimeStatisticViewModel>();
            
        }

        
    }
}
