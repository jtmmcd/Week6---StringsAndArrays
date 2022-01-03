using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajal sisestada ees-ja perekonnanimi
            // programm kontrollib andmete pikkust (eraldi)
            // programm kuvab, kumb neist on pikem

            Console.WriteLine("Sisestage eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisestage perekonnanimi:");
            string lastName = Console.ReadLine();

            int firstNameLenght = firstName.Length;

            int lastNameLenght = lastName.Length;

            if (firstNameLenght < lastNameLenght)
            {
                Console.WriteLine("Teie perekonnanimi on pikem.");
            }
             else if(firstNameLenght > lastNameLenght)
            {
                Console.WriteLine("Teie eesnimi on pikem.");
            }
            else
            {
                Console.WriteLine("Teie eesnimi ja perekonnanimi on sama pikkusega.");
            }



            
        }
    }
}
