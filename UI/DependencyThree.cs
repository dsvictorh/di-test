using System;

namespace ConsoleApp1
{
    class DependencyThree : IInterfaceTwo
    {
        private readonly IInterfaceOne service;

        public DependencyThree(IInterfaceOne service)
        {
            this.service = service;
        }

        public void DoSomething() 
        {
            Console.WriteLine(this.service.DoActionOne("Hello"));
            Console.WriteLine(this.service.DoActionTwo(-5));
        }
    }
}
