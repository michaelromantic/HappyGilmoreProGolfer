using System;

namespace Happy_Gilmore
{
    public class Program
    {
        static public void Main(string[] args)
        {
            ProGolfer myGolfer = new ProGolfer();

            Console.WriteLine("........:: HAPPY GILMORE'S PRO GOLFER ::........");

            bool keepPlaying = true;

            while (keepPlaying)
            {
                Console.WriteLine("\n1. Name/Rename Your Character");
                Console.WriteLine("2. Get golf lessons from Chubbs Peterson");
                Console.WriteLine("3. Go to the batting cages");
                Console.WriteLine("4. Go to the driving range");
                Console.WriteLine("5. Fight Bob Barker");
                Console.WriteLine("6. Find your Happy Place");
                Console.WriteLine("7. Eat a cold cut combo");
                Console.WriteLine("8. Go head to head vs Shooter McGavin");
                Console.WriteLine("9. Directions/Breakdown");
                Console.WriteLine("10. Quit Game");

                string userChoice = Console.ReadLine();
                {
                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine("Enter Name:");
                            string userName = Console.ReadLine();
                            myGolfer.SetName(userName);
                            Console.WriteLine($"Twenty bucks says you can't hit a ball past that tree, {userName}.");
                            break;
                        case "2":
                            myGolfer.AllInTheHips();
                            Console.WriteLine("It's all in the hips!");
                            break;
                        case "3":
                            myGolfer.BattingCages();
                            Console.WriteLine("Argh, that hurt a little!  Only 364 more days until next year's hockey tryouts.  I gotta toughen up.");
                            break;
                        case "4":
                            myGolfer.DrivingRange();
                            Console.WriteLine("Come see the amazing Golf Ball ugh Whacker Guy!");
                            break;
                        case "5":
                            myGolfer.PriceIsWrong();
                            Console.WriteLine("The Price is Wrong, Bobby!");
                            break;
                        case "6":
                            Console.WriteLine("\n1. Spend the day with Grandma");
                            Console.WriteLine("2. Go ice skating with Virginia.");
                            Console.WriteLine("3. Grab a drink with Mr. Larson.");
                            string happyChoice = Console.ReadLine();
                            switch (happyChoice)
                            {
                                case "1":
                                    myGolfer.HappyPlace();
                                    Console.WriteLine("Mista Mista get this off of me!");
                                    break;
                                case "2":
                                    myGolfer.HappyPlace();
                                    Console.WriteLine("What? Friends listen to Endless Love in the dark.");
                                    break;
                                case "3":
                                    myGolfer.HappyPlace();
                                    Console.WriteLine("And YOU can count on ME waiting for YOU in the parking lot.");
                                    break;
                                default:
                                    Console.WriteLine("Now you're backs going to hurt because you just pulled landscaping duty.  Try again and enter a number between 1-3");
                                    break;
                            }
                            break;
                        case "7":
                            myGolfer.ColdCut();
                            Console.WriteLine("Let me just enjoy the one thing that makes me a little bit happy. \nThis fresh, cold, delicious, turkey-filled, cold-cut combo from Subway!  \nI eat three every day to keep me strong.");
                            break;
                        case "8":
                            Shooter newGame = new Shooter();
                            newGame.ShooterGame();
                            break;
                        case "9":
                            Directions();
                            break;
                        case "10":
                            keepPlaying = false;
                            Console.WriteLine("Hey, you don't want breakfast?!");
                            break;
                        default:
                            Console.WriteLine("Invalid selection.  Enter a number between 1-9, or I will put you to sleep.  You're in my world now, grandma!");
                            break;
                    }
                }

                Console.WriteLine("\npress any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("........:: HAPPY GILMORE'S PRO GOLFER ::........");
                Console.WriteLine($"\n{myGolfer.Name.ToUpper()}'S STATS:");
                Console.WriteLine($"TOUGHNESS LEVEL | {myGolfer.GetToughness()}");
                Console.WriteLine($"HAPPY PLACE LEVEL | {myGolfer.GetHappyness()}");
                Console.WriteLine($"PUTTING ACCURACY | {myGolfer.GetAccuracy()}");
                Console.WriteLine($"DRIVER DISTANCE | {myGolfer.GetDistance()}");
                Console.WriteLine($"ENERGY LEVEL | {myGolfer.GetEnergy()}");
            }

            static void Directions()
            {
                Console.Clear();
                Console.WriteLine(".:DIRECTIONS/BREAKDOWN:.");
                Console.WriteLine("\nNAME/RENAME | This is where you name and rename your character.");
                Console.WriteLine("\nGOLF LESSONS | Putting Accuracy(+15) Happyness(+5) Toughness(-10) Energy(-5)");
                Console.WriteLine("\nBATTING CAGES | Toughness(+20) Energy Level(-20) Accuracy(-1) Driving Distance(-1)");
                Console.WriteLine("\nDRIVING RANGE | Driving Distance(+25) Happyness(+5) Energy(-10) Toughness(-5)");
                Console.WriteLine("\nFIGHT BOB BARKER | Toughness(+10) Energy(-5) Happyness(-5) Distance(-1) Accuracy(-1)");
                Console.WriteLine("\nHAPPY PLACE | Happyness(+55) Toughness(-15) Energy(-5)");
                Console.WriteLine("\nCOLD-CUT COMBO | Energy(+50) Happyness(+5) Distance(-1) Accuracy(-1)");
                Console.WriteLine("\nSHOOTER MCGAVIN | Distance(+10) Accuracy(+10) Happyness(-25) Energy(-15)");
            }
        }
    }
}