using System;
using System.Collections.Generic;

namespace Golf_game
{
    class Program
    {
        static void Main(string[] args)
        {


            PlayGolf p = new PlayGolf();
            p.SendStartInfoToUser();

            while (p.NoOfSwings <= 10)
            {
                p.AskUserForValues();
                p.SimulateSwing();

                if ((int)p.StopCondition == 0)
                {
                    Console.WriteLine("You play like a professional! Congratulations!");
                    break;
                }

                if ((int)p.StopCondition < 0)
                {
                    Console.WriteLine("Unlucky! Better luck next time!");
                    break;
                }

            }
            p.DisplayEndingStausToUser();
            Console.ReadLine();


        }
        
    }
}
