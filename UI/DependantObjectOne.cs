using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    class DependantObjectOne
    {
        private readonly IInterfaceOne service;

        public DependantObjectOne(IInterfaceOne service)
        {
            this.service = service;
        }

        public void UseServiceAction()
        {
            Console.WriteLine(this.service.DoActionOne("Hello"));
            Console.WriteLine(this.service.DoActionTwo(-5));
        }
    }
}
