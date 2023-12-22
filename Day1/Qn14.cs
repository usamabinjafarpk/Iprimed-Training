using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Qn14
    {
        static void Main(string[] args)
        {
            int[] stud = new int[3];
            int i,total=0;
            Console.WriteLine("Enter the 10 marks");
            for (i = 0; i < stud.Length; i++)
            {
                stud[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < stud.Length; i++)
            {
                total = stud[i]+total;
            }
            int min = stud[0];
            int max = stud[0];

            for (i = 0; i < stud.Length; i++)
            {
                if(stud[i] < min )
                {
                    min = stud[i];
                }
                if (stud[i] > max )
                {
                    max = stud[i];
                }
            }
           
            
            for (i = 1; i < stud.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (stud[i] < stud[j])
                    {
                        int temp = stud[i];
                        stud[i] = stud[j];
                        stud[j] = temp;
                    }
                }
            }
            Console.WriteLine("Total= "+total);
            Console.WriteLine("Average= " + Convert.ToDouble(total/3));
            Console.WriteLine("Minimum= " + min);
            Console.WriteLine("Maximum= " + max);
            Console.WriteLine("Ascending order:");
            for(i = 0;i<stud.Length;i++)
            {
                Console.Write(stud[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Descending order:");
            for (i = stud.Length-1; i >=0; i--)
            {
                Console.Write(stud[i] + " ");
            }

        }
    }
}
