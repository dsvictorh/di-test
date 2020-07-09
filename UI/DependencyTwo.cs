using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    class DependencyTwo : IInterfaceOne
    {
        public string DoActionOne(string word)
        {
            return "Execute DependencyTwo ActionOne with parameter: " + word;
        }

        public string DoActionTwo(int num)
        {
            return "Execute DependencyTwo ActionTwo with parameter: " + num;
        }
    }
}
