using System;
using System.Collections.Generic;

namespace final_t
{
    internal class Hamster : Pet
    {
        public Hamster(string name, string type, DateTime dateOfBirth, List<string> command) : base(name, type, dateOfBirth, command)
        {
        }
    }
}
