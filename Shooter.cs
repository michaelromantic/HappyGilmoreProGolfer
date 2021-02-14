using System;
using System.Collections.Generic;
using System.Text;

namespace Happy_Gilmore
{
    public class Shooter : ProGolfer
    {
        public Shooter()
        {
            Win = 0;
            Loss = 0;
        }

        public int Win { get; set; }
        public int Loss { get; set; }
        public int GameNumber { get; set; }

        public int UserTries()
        {
            return Win;
        }

        public int ShooterScore()
        {
            Random randomScore = new Random();
            int shooterScore = randomScore.Next(2, 10);
            return shooterScore;
        }
        
        public void WinHole()
        {
            Win++;
        }

        public void LossHole()
        {
            Loss++;
        }

        public int SetNumber()
        {
            Random number = new Random();
            int randoNumber = number.Next(1, 10);
            GameNumber = randoNumber;
            return randoNumber;
        }

        public void ShooterGame()
        {
            Console.Clear();
            int userNumber = 0;
            Shooter newGame = new Shooter();
            int setScore = newGame.SetNumber();
            int mcgavinScore = ShooterScore();

            Console.WriteLine(":::::TOUR CHAMPIONSHIP - HOLE 18:::::");
            Console.WriteLine($"\nSHOOTER MCGAVIN'S SCORE | {mcgavinScore}");

            Console.WriteLine("\n\nBeat Shooter McGavin's score.  Guess the winning number between 1-10. ");
            do {
                string userGuess = Console.ReadLine();
                if (userGuess == "1" || userGuess == "2" || userGuess == "3" || userGuess == "4" || userGuess == "5" || userGuess == "6" || userGuess == "7" || userGuess == "8" | userGuess == "9" | userGuess == "10")
                {
                    userNumber = Convert.ToInt32(userGuess);
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Invalid Entry.  Guess a number between 1-10.");
                        userGuess = Console.ReadLine();
                    } while (userGuess != "1" && userGuess != "2" && userGuess != "3" && userGuess != "4" && userGuess != "5" && userGuess != "6" && userGuess != "7" && userGuess != "8" && userGuess != "9" && userGuess != "10");
                
                }
                Console.WriteLine("Guess Again!");
                Win++;
            } while (userNumber != setScore);

            if (userNumber == setScore)
            {
                Console.WriteLine("That Is Correct!");
            }

            if (UserTries() < mcgavinScore)
            {
                Console.WriteLine($"\nIt took you {UserTries()} tries.  YOU WIN!");
            }

            else if (UserTries() > mcgavinScore)
            {
                Console.WriteLine($"\nIt took you {UserTries()} tries.  SHOOTER WINS!");
            }
            else
            {
                Console.WriteLine($"\nIt took you {UserTries()} tries.  YOU TIED.");
            }
        }
    }
}
