using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10MovieList
{
    public class Movie
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private Category category;
        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        public Movie(string title, Category category)
        {
            Title = title;
            Category = category;
        }
    }
}
