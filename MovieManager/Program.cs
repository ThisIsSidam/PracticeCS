// Name- Anshu Kumar Singh a.k.a. Sidam
// Date- 25/04/2023
// Purpose- C# Practice Programs
// Name of Program- Movie Manager

/*
* Here, we'll making a movie manager program, where there will be a class called
* "Movies", that will be like a folder/section/family of movies. So, it's only
* attribute will be a list of another class, and that class will 
* be "Movie" class. It's a class with details about a specific movie. It's must 
* attributes will be it's name, rating, and the no. of times you have watched the
* movie. You can add more data members as you want. And yeah make the
* classes and else in different files.  
*
* What you have to do in main is make an object of Movies class and add rvalue movie 
* objects to it. You do not have to create variables of those Movie objects. And then you 
* just display the whole Movies object, meaning all movies in it.
*/

using System;

namespace MovieManager {
    class Program
    {
        static void Main(string[] args)
        {   
            var irontrilogy = new Movies(new Movie("Iron Man", 8, 10));

            irontrilogy.addMovie(new Movie("Iron Man 2", 7, 7));
            irontrilogy.addMovie(new Movie("Iron Man 3", 6.5, 10));

            irontrilogy.DisplayMovies();  

            irontrilogy.addMovie(new Movie("Thor: The Dark World", 4, 2));

            irontrilogy.DisplayMovies();

            irontrilogy.RemoveMovie("Man of Steel");
            irontrilogy.RemoveMovie("Thor: The Dark World");

            irontrilogy.DisplayMovies();
        }
    }

}
