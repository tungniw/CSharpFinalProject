using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Car
    {
        //Make Properties for Car
        //Full Constructor
        //Empty Constructor

        public string CarMake { get; set; }
        public int Year { get; set; }
        public int EngineMiles { get; set; }
        public string CarModel { get; set; }
        public Condition CarCondition { get; set; }
        public Transmission ShiftingType { get; set; }
    

        public Car( string carMake, int year, int engineMiles, string carModel, Condition carCondition, Transmission shiftingType)
        {
        CarMake = carMake;
        Year = year;
        EngineMiles = engineMiles;
        CarModel = carModel;
        CarCondition = carCondition;
        ShiftingType = shiftingType;
        }
        public Car() {}
    }
    public class Movie
    {
        //Class OBJECT

        public string Title { get; set; } //Property
        public string DirectorName { get; set; }
        public int Stars { get; set; }
        public Rating MovieRating { get; set; }
        public Genre MovieGenre { get; set; }

        //Full Constructor
        public Movie( string Title, string DirectorName, int Stars, Rating MovieRating, Genre MovieGenre)
        {
            Title = Title;
            DirectorName = DirectorName;
            Stars = Stars;
            MovieRating = MovieRating;
            MovieGenre = MovieGenre;
        }

        //Empty Constructor 
        public Movie() {}
    }

    public enum Rating {G, PG, PG_13, R, MA}
    public enum Genre { Action, Comedy, Drama, Horror, Romance, RomCom, Thriller, SciFi_Fantasy }
    public enum Condition {Poor, Average, Good, Pristine}
    public enum Transmission {Automatic, Manual}

}