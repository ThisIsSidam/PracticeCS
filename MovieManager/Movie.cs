// Purpose- Class file used in Movie Manager

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieManager {

    public class Movie
    {
        public string name {
            get; 
        }
        private double rating {
            get; 
        }
        private short watched_times {
            get; 
        }

        public Movie (string movie_name, double rate, short num) {
            name = movie_name;
            rating = rate;
            watched_times = num;
        }

        public Movie (Movie obj) {
            name = obj.name;
            rating = obj.rating;
            watched_times = obj.watched_times;
        }

        public void Display () {
            Console.WriteLine($"[ {name} - {rating} - {watched_times} ]");
        }
            
    }
}   