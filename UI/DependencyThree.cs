using System;

namespace UI
{
    class DependencyThree : IInterfaceTwo
    {
        public void DoAction() 
        {
            Console.WriteLine("Execute DependencyThree Action");
        }
    }
}
