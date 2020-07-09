using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    class DependantObjectTwo
    {
        private readonly IInterfaceOne serviceOne;
        private readonly IInterfaceTwo serviceTwo;

        public DependantObjectTwo(IInterfaceOne serviceOne, IInterfaceTwo serviceTwo)
        {
            this.serviceOne = serviceOne;
            this.serviceTwo = serviceTwo;
        }

        public void UseServiceOneAction()
        {
            Console.WriteLine(this.serviceOne.DoActionOne("Hello"));
            Console.WriteLine(this.serviceOne.DoActionTwo(-5));
        }

        public void UseServiceTwoAction()
        {
            this.serviceTwo.DoAction();
        }
    }
}
