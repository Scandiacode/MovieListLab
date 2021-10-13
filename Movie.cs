using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLab
{
    class Movie
    {
        private string movieTitle;
        private string movieCategory;

        public string Title
        {
            get { return movieTitle; }
            set { this.movieTitle = value; }
        }

        public string Category
        {
            get { return movieCategory; }
            set { this.movieCategory = value; }
        }

        public Movie(string title, string category)
        {
            this.movieCategory = category;
            this.movieTitle = title;
        }
    }
}
