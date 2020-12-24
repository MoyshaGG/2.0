using System;

namespace ConsoleApp3
{
    class Program
    {
       
        static void Main(string[] args)
        {

            ;


            char[] liter = { 'S', 'Y', 'M', 'B', 'O', 'L' };
            string bukv = new string(liter);
            Console.WriteLine(bukv);
            string string1 = bukv;
            int length;
            length = string1.Length;  
            Rydok ryadok = new Rydok(string1);
           
            Console.WriteLine(ryadok.ToString());

            Console.WriteLine("лiтер - " + length);
            ryadok.Reverse();
            Console.WriteLine("перевернутий рядок");
            Console.WriteLine(ryadok.ToString());
            

            Console.ReadLine();

        }
    }
}
