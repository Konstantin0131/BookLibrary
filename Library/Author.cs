using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Author : Person
    {      
        public int Age { get; set; }
        
        public Author(string firstName, string secondName) : base(firstName, secondName)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = 0;
        }
    }
}