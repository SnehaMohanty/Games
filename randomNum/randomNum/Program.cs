using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace randomNum
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string inputPlayer;
            

            Console.Write("Guess the name of a fruit ");

            while (true)
            {
                inputPlayer = Console.ReadLine();

                Random rnd = new Random();

                string GetRandomFruit()
                {
                    string[] fruits = new string[] { "apple", "mango", "papaya", "banana", "guava", "pineapple", "strawberry", "raspberry", "grapes" , "avacado" , "orange" };
                    return fruits[rnd.Next(0, fruits.Length)];
                }



                if (GetRandomFruit() == inputPlayer)
                {
                    Console.WriteLine("Hurray ! You Won !!");
                    Console.WriteLine(inputPlayer);
                }
                else
                {
                    Console.Write("Oops, you missed the fruit!");
                    Console.WriteLine(GetRandomFruit());


                }

                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }

            }
        }
    }
}
