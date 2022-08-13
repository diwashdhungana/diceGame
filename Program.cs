using System;

namespace diceGame
{
    class Program
    {
        static void Main(string[] args)
        {       
          int player1Dice;
          int player2Dice;
          Random random = new Random();

          Console.WriteLine("                ===== Dice Game =====");

          for (int i = 0; i < 10; i++)
            {
              Console.WriteLine("Press enter to roll the dice!");
              Console.ReadLine();

              player1Dice = random.Next(1,7);
              Console.WriteLine("Player1 rolled a " + player1Dice);

              player2Dice = random.Next(1,7);
              Console.WriteLine("Player2 rolled a " + player2Dice);

              if (player1Dice > player2Dice)
                {
                  Console.WriteLine("\nPlayer 1 wins");
                }
              else if (player2Dice > player1Dice)
                {
                  Console.WriteLine("\nPlayer 2 wins");
                }
              else
                {
                  Console.WriteLine("\nIts a draw");
                } 

            }
        }
    }
}




