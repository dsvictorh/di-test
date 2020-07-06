using System;

namespace ConsoleApp1
{
    class DependencyOne : IInterfaceOne
    {
        public string Word { get; private set; }
        public int Number { get;  private set; }

        public string DoActionOne(string word)
        {
            if (!string.IsNullOrWhiteSpace(word)) 
            {
                this.Word = word;
                return "Word " + word + " saved";
            }

            return "Word is empty. Cannot save";
        }

        public string DoActionTwo(int num)
        {
            if (num >= 0)
            {
                this.Number = num;
                return "Number " + num + " saved";
            }

            return "Number is not a positive number. Cannot save";
        }
    }
}
