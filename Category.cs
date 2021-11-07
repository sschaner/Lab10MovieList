using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10MovieList
{
    public class Category
    {
        private string animated;
        public string Animated
        {
            get { return animated; }
            set { animated = value; }
        }
        private string drama;
        public string Drama
        {
            get { return drama; }
            set { animated = value; }
        }
        private string horror;
        public string Horror
        {
            get { return horror; }
            set { horror = value; }
        }
        private string scifi;
        public string Scifi
        {
            get { return scifi; }
            set { scifi = value; }
        }

        public Category(string animated, string drama, string horror, string scifi)
        {
            Animated = animated;
            Drama = drama;
            Horror = horror;
            Scifi = scifi;
        }
    }
}
