using System;

namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Druk op enter om voor u een paswoord te creëren.");
            Console.ReadLine();
            Password();
            Repeat();
            Console.ReadLine();
        }
        private static void Password()
        {
            char[] chars = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','0','1','2','3','4','5','6','7','8','9' };
            char[] fiveChars = new char[5];
            Random rnd = new Random();
            for (int i = 0; i < fiveChars.Length; i++)
            {
                int index = rnd.Next(chars.Length);
                fiveChars[i] = chars[index];
            }
            Console.WriteLine(fiveChars);
        }
        private static void Repeat()
        {
            Console.WriteLine("Wilt u nog een paswoord creëren?");
            Console.WriteLine("Y/N");
            char answer = char.Parse(Console.ReadLine());
            while (answer == 'Y')
            {
                Password();
                Console.WriteLine("Wilt u nog een paswoord creëren?");
                Console.WriteLine("Y/N");
                answer = char.Parse(Console.ReadLine());

            }
            if (answer == 'N')
            {
                Console.WriteLine("Programma zal stoppen.");
            }
        }
    }
}
