namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag=0;
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            int l=str.Length;
            for(int i = 0,j=l-1; i < l; i++,j--)
            {
                if (str[i] != str[j])
                {
                    flag++;
                }

            }
            if(flag == 0)
            {
                Console.WriteLine("Palidrom");
            }
            else
            {
                Console.WriteLine("Not palindrom");
            }
        }
    }
}
