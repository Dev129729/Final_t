using System;
using System.Collections.Generic;

namespace final_t
{
    internal class Horse : PackAnimal
    {
        public Horse(string name, string type, DateTime dateOfBirth, List<string> command) : base(name, type, dateOfBirth, command)
        {
        }
    }
}
