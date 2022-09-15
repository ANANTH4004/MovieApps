using System;
using System.Collections.Generic;
using System.IO;
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
            WriteMovies(MovieName + "-" + Language + "-" + genre + "-" + Cost);
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
			WriteMovies(MovieName + "-" + Language + "-" + genres + "-" + Cost);
			MoviesCount++;
        }
		public static void PrintAllMovies()
		{
			foreach (var item in MoviesList)
			{
				Console.WriteLine(item.MovieName);
			}
		}
		public void WriteMovies(string data)
		{
			FileStream fs = new FileStream("D:\\c#\\MovieApps\\AdminModule\\bin\\Debug\\MoviesList.txt", FileMode.Append, FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs);
			sw.WriteLine(data);
			sw.Close();
			fs.Close();
			fs.Dispose();
		}
		public static void Read()
		{
			FileStream fs = new FileStream("D:\\c#\\MovieApps\\AdminModule\\bin\\Debug\\MoviesList.txt", FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs);
			while (!sr.EndOfStream)
			{
                var data = sr.ReadLine().Split('-');
				Movie m = new Movie();
				m.MovieName = data[0];
				m.Language = data[1];
				m.genres = data[2];
				m.Cost = double.Parse(data[3]);
				MoviesList.Add(m);
            }
			sr.Close();
			fs.Close();
			fs.Dispose();
        }
		

	}
}
