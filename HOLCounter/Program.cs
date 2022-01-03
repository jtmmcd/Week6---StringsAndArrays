using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"

            string lause = "Hello World!";

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for(int i = 0; i < lause.Length; i++)
                if(lause.ToLower()[i] == 'h')
                {
                    hCounter++;
                }
            else if(lause.ToLower()[i] == 'o')
                {
                    oCounter++;
                }
            else if(lause.ToLower()[i] == 'l')
                {
                    lCounter++;
                }

            if(hCounter != 1)
            {
                Console.WriteLine($"Selles lauses on {hCounter} 'h' tähte.");
            }
            else
            {
                Console.WriteLine($"Selles lauses on {hCounter} 'h' täht.");
            }
            if(oCounter != 1)
            {
                Console.WriteLine($"Selles lauses on {oCounter} 'o' tähte.");
            }
            else
            {
                Console.WriteLine($"Selles lauses on {oCounter} 'o' täht.");
            }
            if(lCounter != 1)
            {
                Console.WriteLine($"Selles lauses on {lCounter} 'l' tähte.");
            }
            else
            {
                Console.WriteLine($"Selles lauses on {lCounter} 'l' tähte.");
            }
        }

    }
}
