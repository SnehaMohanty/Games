using System;

namespace rockpaperscissors
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string inputPlayer, inputComp;
            int randomInt;
                            

            while (true) {
                Console.Write("Choose between ROCK, PAPER , SCISSORS");

                inputPlayer = Console.ReadLine();

                            Random rnd = new Random();

                            randomInt = rnd.Next(1, 4);

                            switch (randomInt)
                            {

                                case 1:
                                    inputComp = "ROCK";
                                    Console.WriteLine("Computer has selected Rock");

                                    if (inputPlayer == "ROCK")
                                    {
                                        Console.WriteLine("Draw situation !");

                                    }

                                    else if (inputPlayer == "PAPER")
                                    {
                                        Console.WriteLine("You Win !!");
                                    }

                                    else
                                    {
                                        Console.WriteLine("The Computer Wins !!");

                                    }
                                    break;

                                case 2:
                                    inputComp = "PAPER";
                                    Console.WriteLine("Computer has selected Paper");

                                    if (inputPlayer == "PAPER")
                                    {
                                        Console.WriteLine("Draw Situation !!");

                                    }

                                    else if (inputPlayer == "ROCK")
                                    {
                                        Console.WriteLine("The Computer Wins!!");
                                    }

                                    else
                                    {

                                        Console.WriteLine("You Win!!");
                                    }
                                    break;

                                case 3:
                                    inputComp = "SCISSORS";
                                    Console.WriteLine("Computer has selected Scissors");

                                    if (inputPlayer == "SCISSORS")
                                    {
                                        Console.WriteLine("Draw Situation !!");
                                    }

                                    else if (inputPlayer == "ROCK")
                                    {
                                        Console.WriteLine("You Win!!");
                                    }

                                    else
                                    {
                                        Console.WriteLine("The Computer Wins!!");
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Invalid Entry !!");
                                    break;

                            }

                            Console.WriteLine("Play Again? [Y or N]");

                            string answer = Console.ReadLine().ToUpper();

                            if (answer == "Y")
                            {
                                continue;
                            }
                            else if (answer == "N")
                            {
                                return;
                            }

                            
                        }
                    
                }
        }

}
