using System;

namespace faveddlccharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who's your favourite Doki Doki Literature Club character? ");
            string fave = Console.ReadLine();
            Console.WriteLine(fave + " is a good character! My favourite is Sayori. ");

            Console.WriteLine("Press any key to exit. ");
            Console.ReadKey();
        }
    }
}
