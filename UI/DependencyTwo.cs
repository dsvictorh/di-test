using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DependencyTwo : IInterfaceOne
    {
        public string DoActionOne(string word)
        {
            return "The word that you wrote is " + word;
        }

        public string DoActionTwo(int num)
        {
            if (num > 0)
            {
                return "This number is a positive number";
            }
            else if (num < 0)
            {
                return "This number is a negative number";
            }
            else
            {
                return "This nmber is neither a negative nor a positive number";
            }
        }
    }
}
