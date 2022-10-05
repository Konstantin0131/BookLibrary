using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Author : Person
    {
      
        public int age { get; set; }
        public Author(string __firstName, string _sekondName, int _age) : base(__firstName, _sekondName)
        {
            firstName = __firstName;
            firstName = _sekondName;
            age = _age;
        }

        public Author(string _firstName, string _sekondName) : base(_firstName, _sekondName)
        {
            firstName = _firstName;
            sekondName = _sekondName;
            age = 0;
        }
    }

















}













