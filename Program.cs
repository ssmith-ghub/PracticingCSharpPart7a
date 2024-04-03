using System;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogNameOne = "Boomer";
            Console.WriteLine("How many friends does " + dogNameOne + " have?");
            string friends = Console.ReadLine();
            int friends3 = Convert.ToInt32(friends);
            Console.WriteLine(dogNameOne + " has " + friends + " friends!");
            Console.ReadKey();
            string dogNameTwo = "Ace";
            Console.WriteLine("How many friends does " + dogNameTwo + " havee\b?");
            string friends2 = Console.ReadLine();
            int friends4 = Convert.ToInt32(friends2);
            Console.ReadKey();
           
            Console.WriteLine(dogNameOne + " and " + dogNameTwo + " have " + (friends3 + friends4)  + " friends together");
            Console.ReadKey();
            int friends5 = (friends3 + friends4);
            int friends6 = friends5 + 1;
            Console.WriteLine("If they make another friend, they will have " + friends6);
            Console.ReadKey();
           
            Console.WriteLine("Are " + dogNameOne + " and " + dogNameTwo + " good at making friends? true or false?");
            string goodFriends = Console.ReadLine();
            bool goodFriends2 = Convert.ToBoolean(goodFriends);
            Console.WriteLine(goodFriends2);
            
            Console.ReadKey();
            Console.Beep();

        }
    }
}
