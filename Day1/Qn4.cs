﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Qn4
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number:");
            n=int.Parse(Console.ReadLine());
            if(n % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else {
                Console.WriteLine("Odd");
            }
        }
    }
}
