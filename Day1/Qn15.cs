using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Qn15
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter the string:");
            string s=Console.ReadLine();
            for(int i = 0;s[i]!='\0';i++)
            {
                count++;
            }
           Console.WriteLine(count);
        }
    }
}
