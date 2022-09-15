using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies;
using System.IO;
using AdminModule;

namespace MovieApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // File.Create("D:\\c#\\MovieApps\\AdminModule\\bin\\Debug\\User.txt");
            Movie m1 = new Movie();
            m1.AddMovieDetails("SK", "Tamil", "Action", 50);
            Movie m2 = new Movie();
            m2.AddMovieDetails("KRK", "Tamil", "Romance", 60);
            Movie m3 = new Movie();
            m3.AddMovieDetails("DS", "English", "Mystery", 100);
            Movie m4 = new Movie();
            m4.AddMovieDetails("NEPV", "Tamil", "Romance", 60);
            Movie m5 = new Movie();
            m5.AddMovieDetails("SMS", "Tamil", "Comedy", 110);
            Movie m6 = new Movie();
            m6.AddMovieDetails("Don't Brethe", "English", "Thriller", 100);
            Movie m7 = new Movie();
            m7.AddMovieDetails("Deadpool", "English", "Action", 50);
            Movie m8 = new Movie();
            m8.AddMovieDetails("24", "Tamil", "Sci-fi", 120);
            Movie m9 = new Movie();
            m9.AddMovieDetails("MIB", "English", "Sci-fi", 120);
            Movie m10 = new Movie();
            m10.AddMovieDetails("West World", "English", "Sci-fi", 120);
            Movie m11 = new Movie("SMS", "Tamil", "Comedy", 110);
            User u1 = new User();
            User u2 = new User();
            User u3 = new User();
            User u4 = new User();
            User u5 = new User();
            User u6 = new User();
            User u7 = new User();
            User u8 = new User();
            User u9 = new User();
            User u10 = new User();
            User u11 = new User();
            User u12 = new User();
            User u13 = new User();
            
            u2.AddUser("Anand",1234, "1234password","Silver");
            u3.AddUser("Nithya",234, "234password", "Gold");
            u4.AddUser("SK", 89, "89password", "Silver");
            u5.AddUser("Kanmani", 45, "45password", "Silver");
            u6.AddUser("Kathija", 534, "534password", "Platinum");
            u7.AddUser("Varun", 90, "90password", "Silver");
            u8.AddUser("Karthi", 23, "23password", "Silver");
            u9.AddUser("Vikram", 12, "12password", "Silver");
            u10.AddUser("Balamurugan", 53, "53password", "Silver");
            u12.AddUser("Bindhu", 998, "998password", "Silver");
            u13.AddUser("Ananth", 11, "11password", "Silver");
            Admin a = new Admin();
            //u14.AddUser("Anand", "Varun", "Silver");
            //u15.AddUser("Anand", "Varun", "Silver");
            u1.BorrowMovie(m7);
            u3.BorrowMovie(m1);
           // u2.BorrowMovie(m3);
            u3.BorrowMovie(m3);
            u3.BorrowMovie(m4);
           // u1.BorrowMovie(m2);
           // u1.BorrowMovie(m3);
            //  u2.BorrowMovie(m1);
            //  u4.BorrowMovie(m1);
            //  Console.WriteLine($"Movie {m1.MovieName} Availability " + m1.Availability);
            //  u2.RetrunMovie(m1,4);
            //  Console.WriteLine("Movie 1 Availability " + m1.Availability);
            //  u3.BorrowMovie(m1);
            //  u6.BorrowMovie(m1);
            //  u5.BorrowMovie(m1);
            //  u7.BorrowMovie(m1);
            //  u8.BorrowMovie(m1);
            //  u9.BorrowMovie(m1);
            //  u10.BorrowMovie(m1);
            //  u12.BorrowMovie(m1);
            //  u11.BorrowMovie(m1);
            //  u13.BorrowMovie(m1);
            //  u1.BorrowMovie(m2);
            //  u1.RetrunMovie(m2,5);
            //  u1.BorrowMovie(m3);

            ////  u1.ShowMyList();

            ////  u1.SearchByLanguage("Tamil");

            // u1.SearchByGenre("Sci-fi");
            // m1.PrintAllMovies();
            u3.ShowMyList();
            u1.ShowMyList();
            //u2.ShowMyList();
        }
    }
}
