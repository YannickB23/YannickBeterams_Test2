using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            double percent = 0;
            Console.WriteLine("Geef het totaal bedrag van uw factuur in: ");
            double totaal = double.Parse(Console.ReadLine());
            Korting(ref percent);

            if (totaal > 5000)
            {
                Console.WriteLine($"Het totaal bedrag na de korting is {totaal * percent} EUR.");
            }
            else
            {
                Console.WriteLine("Uw totaal bedrag is niet hoog genoeg voor een korting.");
            }
            Console.ReadLine();

        }
        private static void Korting(ref double vijfPercent)
        {
           vijfPercent = 0.95;
        }
    }
}
