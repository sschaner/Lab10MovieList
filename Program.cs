using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab10MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;

            Console.Title = "Lab 10: Movie List!";

            List<Movie> movieList = CreateAndStoreEachMovieInAList();

            movieList.Sort();

            Console.WriteLine("Welcome to the Movie List Applicaton!\n");
            Console.WriteLine("There are 10 movies in this list");

            int getCategory = GetCategory(isValidInput);

            Console.WriteLine(ListOfMoviesByCategory(getCategory, movieList));
            

            
            
            Console.ReadKey();
        }

        // Create the movies
        public static List<Movie> CreateAndStoreEachMovieInAList()
        {
            // Create a list to store the movies
            List<Movie> movieList = new List<Movie>();

            Movie movieOne = new Movie("The Matrix", Category.Scifi);
            Movie movieTwo = new Movie("The Holiday", Category.Drama);
            Movie movieThree = new Movie("Star Trek", Category.Scifi);
            Movie movieFour = new Movie("Planes", Category.Animated);
            Movie movieFive = new Movie("The Nightmare on Elm Street", Category.Horror);
            Movie movieSix = new Movie("The Lion King", Category.Animated);
            Movie movieSeven = new Movie("Star Wars Episode III - The Revenge of the Sith", Category.Scifi);
            Movie movieEight = new Movie("Man of Steel", Category.Scifi);
            Movie movieNine = new Movie("The Greatest Showman", Category.Drama);
            Movie movieTen = new Movie("Coco", Category.Animated);

            movieList.Add(movieOne);
            movieList.Add(movieTwo);
            movieList.Add(movieThree);
            movieList.Add(movieFour);
            movieList.Add(movieFive);
            movieList.Add(movieSix);
            movieList.Add(movieSeven);
            movieList.Add(movieEight);
            movieList.Add(movieNine);
            movieList.Add(movieTen);

            return movieList;
        }

        // Get a category from the user and check if it's valid.
        public static int GetCategory(bool isValidInput)
        {
            int categoryNumber = -1;
            do
            {
                // Ask the user what category they are interested in
                Console.Write("What category are you interested in? ");
                string userInput = Console.ReadLine();

                // Assign an int value, determined by the users input. 
                switch (userInput.ToLower().Trim())
                {
                    case "animated":
                        categoryNumber = 1;
                        break;
                    case "drama":
                        categoryNumber = 2;
                        break;
                    case "horror":
                        categoryNumber = 3;
                        break;
                    case "scifi":
                        categoryNumber = 4;
                        break;
                    default:
                        break;
                }

                // Do validation on the users input
                switch (categoryNumber)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        isValidInput = true;
                        break;
                    default:
                        Console.WriteLine("Please enter one of the following categories: animated, drama, horror, scifi.");
                        break;
                }
            } while (isValidInput == false);
            return categoryNumber;
        }

        public static string ListOfMoviesByCategory(int getCategory, List<Movie> movieList)
        {
            string message = "";
            switch (getCategory)
            {
                case 1:
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == Category.Animated)
                        {
                            message += $"{movie.Title}\n";
                        }
                    }
                    break;
                case 2:
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == Category.Drama)
                        {
                            message += $"{movie.Title}\n";
                        }
                    }
                    break;
                case 3:
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == Category.Horror)
                        {
                            message += $"{movie.Title}\n";
                        }
                    }
                    break;
                case 4:
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == Category.Scifi)
                        {
                            message += $"{movie.Title}\n";
                        }
                    }
                    break;
                default:
                    break;
            }


            return message;
        }
        
    }
}
