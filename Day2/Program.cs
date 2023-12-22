namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "The quick brown fox jumps over the lazy dog";
            //a)   	Print the character at the 12th index.
            Console.WriteLine(str[12]);
            //b)	Check whether the String contains the word “is”.
            //c)	Add the string “and killed it” to the existing string.
            string str1 = "and killed it";
            Console.WriteLine(str+" "+str1);
            //d)	Check whether the String ends with the word “dogs”.
            //e)	Check whether the String is equal to “The quick brown Fox jumps over the lazy Dog”.
            string str2 = "The quick brown Fox jumps over the lazy Dog";
            if(str.Equals(str2))
            {
                Console.WriteLine("String is equal");
            }
            else
            {
                Console.WriteLine("String is not equal");
            }
            //f)Check whether the String is equal to “THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG”.    
            string str3 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            if (str.Equals(str3))
            {
                Console.WriteLine("String is equal");
            }
            else
            {
                Console.WriteLine("String is not equal");
            }
            //g)	Find the length of the String.
            Console.WriteLine(str.Length);
        }
    }
}
