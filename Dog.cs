using System;
using System.Collections.Generic;

namespace final_t
{
    internal class Dog : Pet
    {
        public Dog(string name, string type, DateTime dateOfBirth, List<string> command) : base(name, type, dateOfBirth, command)
        {
        }
    }
}
