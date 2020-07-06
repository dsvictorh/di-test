using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DependantObject
    {
        private readonly IInterfaceTwo service;

        public DependantObject(IInterfaceTwo service)
        {
            this.service = service;
        }

        public void ActionService()
        {
            this.service.DoSomething();
        }
    }
}
