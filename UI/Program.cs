using System;
using System.Runtime.Loader;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            DependencyInjector injector = new DependencyInjector();
            injector.Register<IInterfaceOne, DependencyTwo>();
            injector.Register<IInterfaceTwo, DependencyFour>();

            DependantObjectTwo obj1 = injector.Instantiate<DependantObjectTwo>(); 
            obj1.UseServiceOneAction();
            obj1.UseServiceTwoAction();
        }
    }
}
