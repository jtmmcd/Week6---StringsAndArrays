using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm asendab kõik 0 tähed lauses "Hello World!" tärniga (*);

            string helloW = "Hello World!";

            /*for(int i = 0; i < helloW.Lenght; i++)
            {
                helloW[i] = '*'; // sõned on muutumatud
            }*/

            helloW = helloW.Replace('o', '*');
            helloW = helloW.Replace('!', '1');
            Console.WriteLine(helloW);
        }
    }
}
