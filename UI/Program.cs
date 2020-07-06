using System;
using System.Runtime.Loader;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DependencyOne dOne = new DependencyOne();
            DependencyTwo dTwo = new DependencyTwo();

            DependantObject obj1 = new DependantObject(dOne);
            DependantObject obj2 = new DependantObject(dTwo);*/

            DependencyInjector injector = new DependencyInjector();
            injector.Register<IInterfaceOne, DependencyTwo>();
            injector.Register<IInterfaceTwo, DependencyThree>();

            DependantObject obj1 = injector.Instantiate<DependantObject>();
            obj1.ActionService();
        }
    }
}
