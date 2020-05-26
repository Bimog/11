using System;

namespace ConsoleApp4
{
     public class Person
    {
        public string SecondName { get; set; }
        public string Name { get; set; }

        public Person(string secondName, string name)
        {
             

                SecondName = secondName;
                        Name=name;
        }
    }
}
