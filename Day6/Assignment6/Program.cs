namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Accept 10 numbers and sort the data in ascending order and display it
            List<int> list = new List<int>();
            Console.WriteLine("Enter 10 numbers:");
            for(int i = 0; i < 10; i++)
            {
                int num=int.Parse(Console.ReadLine());
                list.Add(num);
            }
            list.Sort();
            Console.WriteLine("List elements are");
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
