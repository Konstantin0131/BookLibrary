using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Person
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public Person(string firstName, string sekondName)
        {
            FirstName = firstName;
            SecondName = sekondName;
        }
    }
}
