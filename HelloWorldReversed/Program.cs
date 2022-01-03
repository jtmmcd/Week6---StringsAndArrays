using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm kuvab lauset "Hello World!" tagurpidi

            string lause = "Hello World!";

            for(int i = lause.Length-1; i >= 0; i--)
            {
                Console.Write(lause[i]);
            }
        }
    }
}
