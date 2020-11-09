using System;

namespace Oefening4
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int xPossition = 0;
            int yPossition = 0;
            int userInputX = -1;
            int userInputY = -1;
            bool restartGame = false;
            bool playGame = true;
            char[,] roster = new char[11, 11];
            do
            {
                playGame = true;
                restartGame = false;
                xPossition = rnd.Next(roster.GetLength(0));
                yPossition = rnd.Next(roster.GetLength(0));
                for (int i = 0; i < roster.GetLength(0); i++)
                {
                    for (int j = 0; j < roster.GetLength(1); j++)
                    {
                        roster[i, j] = '-';
                    }
                }
                do
                {
                    CheckInput(userInputX, xPossition, 'x');
                    CheckInput(userInputY, yPossition, 'y');
                    for (int i = 1; i < roster.GetLength(0); i++)
                    {
                        for (int j = 1; j < roster.GetLength(1); j++)
                        {
                            Console.Write($"{roster[j, i]}\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Vind het paasei");
                    Console.WriteLine("Geef een kolom (1-10)");
                    userInputX = int.Parse(Console.ReadLine());
                    Console.WriteLine("Geef een rij (1-10)");
                    userInputY = int.Parse(Console.ReadLine());
                    roster[userInputX, userInputY] = 'x';
                    Console.Clear();
                    if (userInputX == xPossition && userInputY == yPossition)
                    {
                        Console.WriteLine("Je hebt het ei gevonden!");
                        Console.WriteLine("Druk <enter> om opnieuw to spelen");
                        Console.WriteLine("Type e om af te sluiten");
                        if (Console.ReadLine() == "e")
                        {
                            playGame = false;
                            Console.Clear();
                        }
                        else
                        {
                            restartGame = true;
                            playGame = false;
                            userInputX = -1;
                            userInputY = -1;
                            Console.Clear();
                        }
                    }
                } while (playGame);
            } while (restartGame);
        }
        static void CheckInput(int inputUser, int pos, char orientation)
        {
            if (inputUser != -1)
            {
                if (orientation == 'x')
                {
                    if (inputUser > pos)
                    {
                        Console.WriteLine("Het ei ligt meer in het westen.");
                    }
                    else if (inputUser < pos)
                    {
                        Console.WriteLine("Het ei ligt meer in het oosten.");
                    }
                }
                else if (orientation == 'y')
                {
                    if (inputUser > pos)
                    {
                        Console.WriteLine("Het ei ligt meer in het noorden.");
                    }
                    else if (inputUser < pos)
                    {
                        Console.WriteLine("Het ei ligt meer in het zuiden.");
                    }
                }
            }

        }
    }
}