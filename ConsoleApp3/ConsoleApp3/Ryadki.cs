using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Rydok
    {
        public string strok;
        public int count = 0;
        public Rydok(string line)
        {
            this.strok = line;
        }
        public string Stroka
        {
            get { return strok; }
            set { if (strok != null) strok = value; }
        }
        public override string ToString()
        {
            return Convert.ToString(strok);

        }
        public string Reverse()
        {

            char[] arrInput = strok.ToCharArray();
            Array.Reverse(arrInput);
            strok = new string(arrInput);
            return strok;

        }
        
        
        
    }
}
