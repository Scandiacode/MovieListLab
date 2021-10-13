using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLab
{
    class ListOfMovies
    {
        //Fields
        private string movieName;
        private List<Movie> catalog;

        //Properties
        public string Name
        {
            get { return this.movieName; }
            set { this.movieName = value; }
        }

        public List<Movie> Inventory
        {
            get { return this.catalog; }
            set { this.catalog = value; }
        }

        //Constructor
        public ListOfMovies(string name)
        {
            this.movieName = name;
            MovieList();
        }

        private void MovieList()
        {
            List<Movie> movies = new List<Movie>
            {
            new Movie("Silent Voice", "Animated"),
            new Movie("Her", "Scifi"),
            new Movie("Chappie", "Scifi"),
            new Movie("Halloween", "Horror"),
            new Movie("Hacksaw Ridge", "Drama"),
            new Movie("8 Mile", "Drama"),
            new Movie("Hellraiser", "Horror"),
            new Movie("Weathering With You", "Animated")
            };
            this.catalog = movies;
        }

        public string Greeting()
        {
            string welcome = $"Welcome to {this.movieName} app!";
            string intro = $"\nThere are 10 movies in this list.";
            return $"{ welcome }\n{ intro }";
        }

        public void DisplayAllMovies()
        {
            string formattedList = string.Format("{0, -15} {1, 5}", "Category", "Movie Title");
            string dashesAdded = string.Format("{0, -15} {1, 5}", "--------", "-----------");
            Console.WriteLine($"{ formattedList }\n{ dashesAdded }");
            foreach (Movie movies in this.catalog)
            {
                formattedList = string.Format("{0, -15} {1, 5}", movies.Category, movies.Title);
                Console.WriteLine(formattedList);
            }
        }

        public string GetUserInput(string UserPrompt)
        {
            Console.WriteLine(UserPrompt);
            return UserPrompt = Console.ReadLine();
        }

        public Movie GetMoviesByCategory(string searching)
        {
            Movie category = null;
            foreach (Movie movies in this.Inventory)
            {
                if (movies.Category.ToLower() == searching.ToLower())
                {
                    category = movies;
                }
            }

            if (category != null)
            {
                Console.WriteLine($"Here's a list of movies from the { searching } category:");
                foreach (Movie movies in this.catalog)
                {
                    if (searching.ToLower() == movies.Category.ToLower())
                    {
                        Console.WriteLine($" { movies.Title }");
                    }
                }
            }
            else
            {
                Console.WriteLine($"No movies was found under { searching } category.\nPlease try again");
                GetMoviesByCategory(GetUserInput(null));
            }
            return category;
        }
    }
}
