using System;
namespace projet
{
    class program
    {
        static void Main(string[] args)
        {
            bool game = true;
            while (game)
            {
                string user;
                string answer;
                int r;
                string systm = "";
                Console.WriteLine("Welcome To Game");
                System.Console.WriteLine("Pleas Choose Rock / Paper / Scissors ! ");
                user = Console.ReadLine();
                Random rnd = new Random();
                r = rnd.Next(1, 4);
                switch (r)
                {
                    case 1:
                        systm = "Rock";

                        if (user == "Rock" || user == "rock")
                        {
                            System.Console.WriteLine($"Computer Choose {systm}");
                            System.Console.WriteLine("Drow!!");
                        }
                        else if (user == "paper" || user == "Paper")
                        {
                            System.Console.WriteLine($"Computer Choose {systm}");
                            System.Console.WriteLine("u win this Game (:");
                        }
                        else if (user == "Scissors" || user == "scissors")
                        {
                            System.Console.WriteLine($"Computer Choose {systm}");
                            System.Console.WriteLine("u Lose this Game");
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid Entry ):");
                        }
                        break;
                    case 2:
                        systm = "Paper";


                        if (user == "Paper" || user == "Paper")
                        {
                            System.Console.WriteLine($"Computer Choose {systm}");
                            System.Console.WriteLine("Drow!!");
                        }
                        else if (user == "Scissors" || user == "scissors")
                        {
                            System.Console.WriteLine($"Computer Choose {systm}");
                            System.Console.WriteLine("u win this Game (:");
                        }
                        else if (user == "Rock" || user == "rock")
                        {
                            System.Console.WriteLine($"Computer Choose {systm}");
                            System.Console.WriteLine("u Lose this Game");
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid Entry ):");
                        }
                        break;
                    case 3:
                        systm = "Scissors";
                        if (user == "Scissors" || user == "scissors")
                        {
                            System.Console.WriteLine($"Computer Choose {systm}");
                            System.Console.WriteLine("Drow!!");
                        }
                        else if (user == "Rock" || user == "rock")
                        {
                            System.Console.WriteLine($"Computer Choose {systm}");
                            System.Console.WriteLine("u win this Game (:");
                        }
                        else if (user == "Paper" || user == "Paper")
                        {
                            System.Console.WriteLine($"Computer Choose {systm}");
                            System.Console.WriteLine("u Lose this Game");
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid Entry ):");
                        }
                        break;
                }
                bool welcome = true;

                System.Console.WriteLine("Can you play game again?  No or Yes");
                answer = Console.ReadLine();
                while (welcome)
                {
                    if (answer == "Yes" || answer == "yes")
                    {
                        game = true;
                        break;
                    }
                    else if (answer == "No" || answer == "no")
                    {
                        game = false;
                        welcome = false;
                        System.Console.WriteLine("Thanks for palying game ... Goodluck(:");
                    }
                }
            }
        }
    }

}