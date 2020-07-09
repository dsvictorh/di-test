using System;

namespace UI
{
    class DependencyFour : IInterfaceTwo
    {
        private readonly IInterfaceOne service;

        public DependencyFour(IInterfaceOne service)
        {
            this.service = service;
        }

        public void DoAction() 
        {
            Console.WriteLine("Execute DependencyFour Action");
            Console.WriteLine(this.service.DoActionOne("Hello"));
            Console.WriteLine(this.service.DoActionTwo(-5));
        }
    }
}
