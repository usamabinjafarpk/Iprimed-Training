using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Qn2
    {
        static void Main(string[] args)
        {
            // Write an Arraylist that will hold the names of all students and display them in descending order
            ArrayList list = new ArrayList();
            list.Add("Usama");
            list.Add("Anu");
            list.Add("Manu");
            list.Add("Hari");

            list.Sort();
            list.Reverse();
            foreach (var i in list)
            {
                Console.WriteLine(i);
            } 
        }
    }
}
