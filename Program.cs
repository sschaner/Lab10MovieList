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

            Console.WriteLine("Welcome to the Movie List Applicaton!\n");
            Console.WriteLine("There are 10 movies in this list");

            bool enterAgain = false;
            do // Loops as long as the user wants to enter a category
            {
                List<Movie> movieList = CreateAndStoreEachMovieInAList();

                List<string> movieTitles = movieList.Select(x => x.Title).ToList();
                movieList = movieList.OrderBy(x => x.Title).ToList();                

                Category getCategory = GetCategory(isValidInput);

                Console.WriteLine(ListOfMoviesByCategory(getCategory, movieList));

                string continueInput = "";
                do // Loop for determining if the user wants to enter a category again
                {
                    // Ask the user if they would like to continue
                    Console.Write("Continue? (y/n): ");
                    string userInput = Console.ReadLine();
                    continueInput = userInput;
                    if (continueInput.ToLower().Trim() == "y")
                    {
                        enterAgain = true;
                    }
                    else if (continueInput.ToLower().Trim() == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        goto Exit;
                    }
                    else
                    {
                        Console.WriteLine("Continue? (y/n): ");
                    }
                } while (continueInput.ToLower().Trim() != "y");

            } while (enterAgain == true);

        Exit:
            
            Console.ReadKey();
        }

        // Create the movies and store them in a list
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
            // Movie movieEleven = new Movie("Star Trek", Category.Scifi);

            // Add all the movies to the list
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
        public static Category GetCategory(bool isValidInput)
        {
            Category category;
            do
            {
                // Ask the user what category they are interested in
                Console.Write("What category are you interested in?\n(Animated = 1, Drama = 2, Horror = 3, Scifi = 4) ");
                string userInput = Console.ReadLine();

                // Assign an int value, determined by the users input. 
                switch (userInput.ToLower().Trim())
                {
                    case "animated":
                    case "1":
                        category = Category.Animated;
                        break;
                    case "drama":
                    case "2":
                        category = Category.Drama;
                        break;
                    case "horror":
                    case "3":
                        category = Category.Horror;
                        break;
                    case "scifi":
                    case "4":
                        category = Category.Scifi;
                        break;
                    default:
                        category = Category.Invalid;
                        break;
                }

                // Do validation on the users input
                switch (category)
                {
                    case Category.Animated:
                    case Category.Drama:
                    case Category.Horror:
                    case Category.Scifi:
                        isValidInput = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid category.\n");
                        break;
                }
            } while (isValidInput == false);
            return category;
        }

        public static string ListOfMoviesByCategory(Category getCategory, List<Movie> movieList)
        {
            string message = "";
            // update the message, depending on whether the movie category is equal to getCategory
            foreach (Movie movie in movieList.Where(x => x.Category == getCategory))
            {
                message += $"{movie.Title}\n";
            }

            return message;
        }
        
    }
}
