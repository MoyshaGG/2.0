using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class liters : Rydok
    {
        char[] str;

        public liters(string line) : base(line)
        {
            this.strok = line;
            str = line.ToCharArray();
        }

        public int Longest(liters liters)
        {
            count = liters.str.Length;
            return count;
        }
        
        

    }
}



