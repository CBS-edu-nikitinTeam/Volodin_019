using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    enum Post : int
    {
        Manager = 160,
        Programmer = 150,
        Accounant = 140,

    }
    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            return hours > (int)worker;
        }
    }
}
