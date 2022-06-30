using System;

namespace MontyHall
{
    internal class Program
    {
        private static Random generator = new Random();

        private static void Main(string[] args)
        {
            int winCounter = 0;
            int winWithswitch = 0;
            int loseCounter = 0;
            int loseWithswitch = 0;

            int durchlauf = 1000;
            for (int stop = 0; stop < durchlauf; stop++)
            {
                int win = Entscheidung();
                int pcChoice = Entscheidung();
                int door = Entscheidung();
                
                while (win == door || door == pcChoice)
                {
                    door = Entscheidung();
                }

                int pcChoice2 = Entscheidung();
                
                while (pcChoice2 == door)
                {
                    pcChoice2 = Entscheidung();
                }

                if (pcChoice == pcChoice2 && win == pcChoice2)
                {
                    winCounter++;
                }
                else if (win == pcChoice2)
                {
                    winWithswitch++;
                }
                else if (pcChoice == pcChoice2)
                {
                    loseCounter++;
                }
                else if (pcChoice != pcChoice2)
                {
                    loseWithswitch++;
                }
            }
            Console.WriteLine("Umentschieden und Gewonnen: " + winWithswitch);
            Console.WriteLine("Nicht umentschieden und Gewonnen: " + winCounter);
            Console.WriteLine("Umentschieden und verloren: " + loseWithswitch);
            Console.WriteLine("Nicht umentschieden und verloren: " + loseCounter);

            Console.ReadLine();
        }
        private static int Entscheidung()
        {
            int generator0 = generator.Next(1, 4);
            return generator0;
        }


    }
}