using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoldyPotatoes.Repository
{
    public class MovieRepository
    {
        // Empty Constructor
        public MovieRepository() {}

        // Fake DB
        List<Movie> _movieDB = new List<Movie>();

        // Create
        public void AddMovieToDatabase(Movie movie)
        {
            _movieDB.Add(movie);
        }

        // Read
        public List<Movie> GetAllMovies()
        {
            return _movieDB;
        }

        public Movie GetMovieByTitle(string movieTitle)
        {
            foreach (Movie x in _movieDB)
            {
                if(movieTitle.ToUpper() == x.Title.ToUpper())
                {
                    return x;
                }
            }

            return null;
        }

        public List<Movie> GetMoviesByTitleSearch(String movieTitle)
        {
            List<Movie> movieList = new List<Movie>();

            foreach (Movie x in _movieDB) 
            {
                if (x.Title.ToUpper().Contains(movieTitle.ToUpper()))
                {
                    movieList.Add(x);
                }
            }
            return movieList;
        }

        // Update

        // Delete
        public bool DeleteMovieFromDatabase(Movie movie)
        {
            int totalMoviesInDB = _movieDB.Count();
            _movieDB.Remove(movie);
            if(totalMoviesInDB == _movieDB.Count())
            {
                return false;
            }
            return true;
        }

        // Seed data method
        public void SeedMovieData()
        {
            Movie up = new Movie("UP", "Ben Caplan", Genre.Comedy, Rating.G, 9);
            Movie avengers = new Movie("Avengers", "Nate Humphries", Genre.Action, Rating.PG_13, 8);
            Movie deathToSmoochie = new Movie("DeathToSmoochie", "Twila Chandler", Genre.Comedy, Rating.R, 8);
            Movie forrestGump = new Movie("Forrest Gump", "Darryl James", Genre.Drama, Rating.PG_13, 9);

            Movie[] movieArr = { up, avengers, deathToSmoochie, forrestGump };

            foreach (Movie movie in movieArr)
            {
                AddMovieToDatabase(movie);
            }
        }
    }
}