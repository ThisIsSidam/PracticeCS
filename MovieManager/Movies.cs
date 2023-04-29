// Purpose- Class file used in Movie Manager

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieManager
{
    public class Movies
    {
        private List<Movie> movies = new List<Movie>();

        public Movies (Movie movie) {
            movies.Add(movie);
        }

        public void DisplayMovies () {

            foreach (Movie movie in movies) 
            {
                movie.Display();
            }

            Console.WriteLine();
        }

        public void addMovie (Movie movie) {
            movies.Add(movie);
        }

        public int SearchMovie (string name) {

            for (int i = 0; i < movies.Count; i++) 
            {
                if ( movies[i].name == name )
                {
                    return i;
                }
            }

            return -1;
        }

        public void RemoveMovie(string name) {

            int pos = SearchMovie(name);

            if ( pos == -1 ) 
            {
                Console.WriteLine($"{name} is not in the list!\n");
            }
            else 
            {
                movies.Remove(movies[pos]);
            }
        }
    }
}