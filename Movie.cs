using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10MovieList
{
    class Movie
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string category;
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}
