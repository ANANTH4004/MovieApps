using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies;
using static Movies.User;


namespace Movies
{
   // public delegate void RequestDelegate();
    public class User
    {
        public static event Func<string,bool> Request;
        public int moviesBorrowed = 0;
       public enum UserLevel
        {
            Silver = 2,
            Gold = 3,
            Platinum = 5
        }
        public List<Movie> BorrowedMovies;
        public User()
        {
           // this.userLevel =(int) UserLevel.Silver;
            BorrowedMovies = new List<Movie>();
            
        }
        private long _UserId;


        public long UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        public User(string UserName,long UserId ,string Password, string UserLevel1)
        {
            if(UserLevel1 == "Silver")
            {
                this.userLevel =(int) UserLevel.Silver;
            }
            if(UserLevel1 == "Gold")
            {
                this.userLevel = (int)UserLevel.Gold;
            }
            if(UserLevel1 == "Platinum")
            {
                this.userLevel = (int)UserLevel.Platinum;
            }
            this.UserName = UserName;
            this.Password = Password;
            this.UserId = UserId;
            Write(this.UserName +"-"+ this.UserId + "-"+ this.Password + "-"  + this.userLevel);
        }
        private int _UserLevel;

        public int userLevel
        {
            get { return _UserLevel; }
            set { _UserLevel = value; }
        }
        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public void AddUser(string UserName,long UserId, string Password, string UserLevel1)
        {
            if (UserLevel1 == "Silver")
            {
                this.userLevel = (int)UserLevel.Silver;
            }
            if (UserLevel1 == "Gold")
            {
                this.userLevel = (int)UserLevel.Gold;
            }
            if (UserLevel1 == "Platinum")
            {
                this.userLevel = (int)UserLevel.Platinum;
            }
            this.UserName = UserName;
            this.UserId = UserId;
            this.Password = Password;
            Write(this.UserName + "-" + this.UserId + "-" + this.Password + "-" + this.userLevel);

        }
        public void BorrowMovie(Movie m)
        {
            
            
            bool  ans = Request(m.MovieName);
            if (ans)
            {

                if (m.Availability > 0)
                {
                    if (this.moviesBorrowed <= this.userLevel)
                    {
                        m.Availability--;
                        this.moviesBorrowed++;
                        BorrowedMovies.Add(m);
                    }
                    else
                    {
                        Console.WriteLine("User Can't Borrow Anymore Movies upgrade your level");
                    }
                }
                else
                {
                    Console.WriteLine($"{m.MovieName} Movie isn't Availabale");
                }
            }
            else
            {
                Console.WriteLine("Admin Rejected....");
            }
            //Console.WriteLine("--------------------------------------------------------------------");
        }
        public void RetrunMovie(Movie m,int days)
        {
            if (this.BorrowedMovies.Contains(m))
            {

                m.Availability++;
                this.moviesBorrowed--;
                BorrowedMovies.Remove(m);
                double totalCost = days * m.Cost;
                Console.WriteLine($"You Need to Pay {totalCost}");
            }
            else
            {
                Console.WriteLine($"You didn't Borrow {m.MovieName} movie..");
            }
            Console.WriteLine("--------------------------------------------------------------------");
        }
        public void SearchByLanguage(string language)
        {
            foreach (var item in Movie.MoviesList)
            {
                if(item.Language == language)
                {
                    Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
                }
            }
            Console.WriteLine("--------------------------------------------------------------------");
        }
        public void SearchByGenre(string genre)
        {
            foreach (var item in Movie.MoviesList)
            {
                if (item.genres == genre)
                {
                    Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
                }
            }
            Console.WriteLine("--------------------------------------------------------------------");
        }
        public void ShowMyList()
        {
            foreach (var item in this.BorrowedMovies)
            {
                Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
            }
            Console.WriteLine("--------------------------------------------------------------------");
        }
        public virtual void  Write(string data)
        {
            FileStream fs = new FileStream("D:\\c#\\MovieApps\\AdminModule\\bin\\Debug\\User.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(fs);

                sw.WriteLine(data);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error Message from Write Method : " + ex.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
                fs.Dispose();
            }
        }

    }
}
