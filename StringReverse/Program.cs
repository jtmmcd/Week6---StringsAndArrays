using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm kuvab kasutaja eesnime tagurpidi

            Console.WriteLine("Sisetage eesnimi:");
            string firstName = Console.ReadLine();

            for (int i = firstName.Length - 1; i >= 0; i--)
            {
                Console.Write(firstName[i]);
            }
        }
    }
}
