using System;
using System.Collections.Generic;

namespace final_t
{
    internal class Pet : Animal
    {
        public Pet(string name, string type, DateTime dateOfBirth, List<string> command) : base(name, type, dateOfBirth, command) { }
    }
}
