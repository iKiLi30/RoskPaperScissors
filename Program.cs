using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey consoleKey = Console.ReadKey().Key;
            while (consoleKey != ConsoleKey.Escape)
            {

                Console.WriteLine("Welcome to RPS!");
                Console.WriteLine("The rule of are simple: Rock beats Scissor, Scissor beats Paper, Pape beats Rock");
                Console.WriteLine("Choose wisely...");
                Console.WriteLine("Choose your move: 1 - rock, 2 - paper, 3 - Scissor");
                int playerMove = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(playerMove);
                Random random = new Random();
                int computerMove = random.Next(1, 4);
                string playerMoveString = "";
                switch (playerMove)
                    {
                        case 1:
                            playerMoveString = "Rock";
                            break;
                        case 2:
                            playerMoveString = "Paper";
                            break;
                        case 3:
                            playerMoveString = "Scissor";
                            break;
                        default:
                            playerMoveString = "KAMAZ";
                            break;

                    }
                Console.WriteLine($"Your chose {playerMoveString}, computer chose {computerMove}");

                if (playerMove == computerMove)
                    {
                        Console.WriteLine("Its draw");
                    }
                else if ((playerMove == 1 && computerMove == 3) || (playerMove == 2 && computerMove == 1) || (playerMove == 3 && computerMove == 2))
                    {
                        Console.WriteLine("You wшn!");
                    }
                else
                    {
                        Console.WriteLine("You lose!");
                    }
                Console.ReadLine();
                consoleKey = Console.ReadKey().Key;
                
            }   
        }
    }
}
