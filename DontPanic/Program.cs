using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm asendab kõik 'o' tähed lauses "Don't Panic" nulliga - 0
            // programm asendab kõik 'a' tähed lauses 4-ga

            string panic = "Don't Panic";

            panic = panic.Replace('o', '0');
            panic = panic.Replace('a', '4');

            Console.WriteLine(panic);
        }
    }
}
