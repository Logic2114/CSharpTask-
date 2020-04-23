
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Welcome");
            Console.WriteLine("Select a Level");
            Console.WriteLine("A. Easy Level");
            Console.WriteLine("B. Medium Level");
            Console.WriteLine("C. Level Hard");
            Console.WriteLine("Enter A, B or C");
            string userDecision = Console.ReadLine();

            if (userDecision.ToUpper() == "A")
            {
                Easy();
            }else if(userDecision.ToUpper() == "B")
            {
                Medium();
            }else if(userDecision.ToUpper() == "C")
            {
                Hard();
            }

        }
        public static void Easy()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 10); 

            int numberOfGuesses = 5; 
            int guessCount = 0;
            bool outOfGueses = false;
            int count = -1;
            int guess;
  
                Console.Write("Enter Guess (a number between 1 and 10): ");
                guess = Convert.ToInt32(Console.ReadLine()  );

               while (guess != randomNumber && !outOfGueses)
                {

                    if (guessCount < numberOfGuesses)
                    {
                        count++;
                        Console.Write("Wrong! You have " + (numberOfGuesses - count) + " guess(es) left. Try again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        guessCount++;
                    }   
                    else
                    {
                        outOfGueses = true;
                    }
                    if (outOfGueses)
                    {
                        Console.WriteLine("You Lose!");
                    }
                }
                if (guess == randomNumber)
                {
                    Console.WriteLine("You win!");
                }
            

        }

        public static void Medium()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 20); 

            int numberOfGuesses = 4; 
            int guessCount = 0;
            bool outOfGueses = false;
            int count = -1;
            int guess;
  
                Console.Write("Enter Guess (a number between 1 and 20): ");
                guess = Convert.ToInt32(Console.ReadLine()  );

               while (guess != randomNumber && !outOfGueses)
                {

                    if (guessCount < numberOfGuesses)
                    {
                        count++;
                        Console.Write("Wrong! You have " + (numberOfGuesses - count) + " guess(es) left. Try again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        guessCount++;
                    }   
                    else
                    {
                        outOfGueses = true;
                    }
                    if (outOfGueses)
                    {
                        Console.WriteLine("You Lose!");
                    }
                }
                if (guess == randomNumber)
                {
                    Console.WriteLine("You win!");
                }
        }

        public static void Hard()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 50); 

            int numberOfGuesses = 3; 
            int guessCount = 0;
            bool outOfGueses = false;
            int count = -1;
            int guess;
  
                Console.Write("Enter Guess (a number between 1 and 50): "); 
                guess = Convert.ToInt32(Console.ReadLine()  );

               while (guess != randomNumber && !outOfGueses)
                {

                    if (guessCount < numberOfGuesses)
                    {
                        count++;
                        Console.Write("Wrong! You have " + (numberOfGuesses - count) + " guess(es) left. Try again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        guessCount++;
                    }   
                    else
                    {
                        outOfGueses = true;
                    }
                    if (outOfGueses)
                    {
                        Console.WriteLine("You Lose!");
                    }
                }
                if (guess == randomNumber)
                {
                    Console.WriteLine("You win!");
                }
        }
    }
}
