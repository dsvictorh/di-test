using System;

namespace UI
{
    class DependencyOne : IInterfaceOne
    {
        public string DoActionOne(string word)
        {
            return "Execute DependencyOne ActionOne with parameter: " + word;
        }

        public string DoActionTwo(int num)
        {
            return "Execute DependencyOne ActionTwo with parameter: " + num;
        }
    }
}
