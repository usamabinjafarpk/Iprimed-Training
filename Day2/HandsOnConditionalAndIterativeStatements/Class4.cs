﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalAndIterativeStatements
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            string grade = "A";
            switch (grade)
            {
                case "A++":
                    Console.WriteLine("Prize Money 10,000");
                    break;
                case "A+":
                    {
                        Console.WriteLine("Prize Money 5,000");
                        break;
                    }
                case "A":
                    Console.WriteLine("Prize Money 3,000");
                    break;
                case "B+":
                case "B":
                    Console.WriteLine("Prize Money 1,000");
                    break;
                default:
                    Console.WriteLine("Better luck next time!!");
                    break;
            }
        }
    }
}
