using System;


namespace Loop_Console_Application
{
    class Program
    {
        static void Main()
        {
            // DO WHILE LOOP WITH A SWITCH STATEMENT : 

            Console.WriteLine("what is your favorite color?");
            string color = Console.ReadLine();
            bool guess = true;

            do
            {
                switch (color.ToUpper())
                {
                    case "BLUE":
                        Console.WriteLine("You guessed correctly!!");
                        guess = false;
                        break;
                    case "RED":
                        Console.WriteLine("You guessed Red \nTry again.");
                         color = Console.ReadLine();
                        break;
                    case "BLACK":
                        Console.WriteLine("You guessed Black \nTry again.");
                        color = Console.ReadLine();
                        break;
                    case "GREEN":
                        Console.WriteLine("You guessed Green \nTry again.");
                        color = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You guess incorrectly \nTry again");
                        color = Console.ReadLine();
                        break;
                }
            }
            while (guess);



            // WHILE LOOP 
            Console.WriteLine("Guess a number between 1 and 20");
            int guessNum = Convert.ToInt32(Console.ReadLine());
            while (guessNum != 7)
            {

                Console.WriteLine("You guessed incorrectly \nTry again");
                guessNum = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You guess 7. You are correct!!");
            Console.ReadKey();
        }
    }
}
