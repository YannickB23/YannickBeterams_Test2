using System;

namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipCodes();
            Console.ReadLine();
        }
        private static void ZipCodes()
        {
            int[] zipCodes = { 9300, 2000, 1000, 9200, 9000, 8500, 9700, 2300 };
            string[] city = { "Aalst", "Antwerpen", "Brussel", "Dendermonde", "Gent", "Kortrijk", "Oudenaarde", "Turnhout" };
            Console.WriteLine("Geef de postcode in waarvan u de plaatsnaam wil weten: ");
            int search = int.Parse(Console.ReadLine());
            bool cityFound = false;
            int zipCity = 0;
            for (int i = 0; i < zipCodes.Length; i++)
            {
                if (search == zipCodes[i])
                {
                    cityFound = true;
                    zipCity = i;
                }
            }
            if (cityFound)
            {
                Console.WriteLine($"De stad die bij deze postcode hoort is {city[zipCity]}.");
            }
            else
            {
                Console.WriteLine("###\tDe postcode werd NIET terug gevonden\t###");
            }
        }
    }
}
