using System;

namespace MovieLab
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfMovies viewAList = new ListOfMovies("Welcome to the Movie List Application");
            Console.WriteLine(viewAList.Greeting());

            bool reRunProgram = true;
            while (reRunProgram)
            {
                viewAList.DisplayAllMovies();
                string userSearch = viewAList.GetUserInput("What category are you interested in? ");
                viewAList.GetMoviesByCategory(userSearch);

                Console.WriteLine("Continue? (y/n)");
                while (true)
                {
                    string tryAgain = Console.ReadLine();
                    if (tryAgain.Equals("y"))
                    {
                        Console.Clear();
                        break;
                    }
                    else if (tryAgain.Equals("n"))
                    {
                        reRunProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please choose (y/n)");
                    }
                }
            }
        }
    }
}
