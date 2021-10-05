using System;

namespace Open_Lab_02._09
{
    public class Names
    {
        public string ConcatName(string firstName, string lastName)
        {

             string Name = lastName + ", " + firstName ;
            Console.WriteLine(Name);
            return Name;

        }
    }
}
