using System;
using System.Collections.Generic;
using System.Text;

namespace Vlak
{
    class Person
    {
        string firstName; 
        string lastname;

        public Person(string firstName, string lastname)
        {
            FirstName = firstName;
            Lastname = lastname;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string Lastname { get => lastname; set => lastname = value; }

        public override string ToString()
        {
            return $"{firstName} {lastname}";
        }
    }
}
