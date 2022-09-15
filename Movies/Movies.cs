using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class Movie
    {
		public static int MoviesCount = 0;
		public Movie()
		{
			this.Availability = 10;
		}
		public Movie(string MovieName , string Language , string genre,double Cost)
		{
			this.Availability = 10;
			this.MovieName = MovieName;
			this.Language = Language;
			this.genres = genre;
			this.Cost = Cost;
			MoviesCount++;
			MoviesList.Add(this);
		}
		public static List<Movie> MoviesList = new List<Movie>();
		private string _movieName;

		public string MovieName
		{
			get { return _movieName; }
			set { _movieName = value; }
		}

		private int _availability;

		public int Availability
		{
			get { return _availability; }
			set { _availability = value; }
		}
		private string _language;

		public string Language
		{
			get { return _language; }
			set { _language = value; }
		}

		private string _genres;

		public string genres
		{
			get { return _genres; }
			set { _genres = value; }
		}
		private double _cost;

		public double Cost
		{
			get { return _cost; }
			set { _cost = value; }
		}

		//public void AddMovies(Movie s)
		//{
		//	MoviesList.Add(s);

		//}
		public void AddMovieDetails(string MovieName, string Language, string genres,double Cost)
		{
            //this.Availability = 10;
            this.MovieName = MovieName;
            this.Language = Language;
            this.genres = genres;
			this.Cost = Cost;
			MoviesList.Add(this);
			MoviesCount++;
        }
		public static void PrintAllMovies()
		{
			foreach (var item in MoviesList)
			{
				Console.WriteLine(item.MovieName);
			}
		}
		

	}
}
