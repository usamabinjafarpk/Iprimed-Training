﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    interface IComputer
    {
        void Discount();
        void M1();
    }
    interface IMobile
    {
        void Discount();
        void M2();
    }
    class EShop : IComputer, IMobile //Multiple Inheritance
    {
        public void M1() {
            Console.WriteLine("M1");
        }
        public void M2() { 
            Console.WriteLine("M2");
        }
        //explicit implementation
        void IComputer.Discount()
        {
            Console.WriteLine("IComputer:DisCount()");
        }
        void IMobile.Discount()
        {
            Console.WriteLine("IMobile:DisCount()");

        }
    }
    internal class Demo5
    {
        static void Main()
        {
            IComputer computer = new EShop();
            computer.M1();
            computer.Discount();
            IMobile mobile = new EShop();
            mobile.M2();
            mobile.Discount();
        }
    }
}