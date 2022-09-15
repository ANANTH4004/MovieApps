using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies;

namespace AdminModule
{
   
    public class Admin : User
    {
       // private User user;
        //public Admin(User User1)
        //{
        //    user = User1;
           
        //}
        public Admin()
        {
           
            Read();
            User.Request += Request1;
        }
        public List<User> UserList = new List<User>();
       public void Write()
        {
            FileStream fs = new FileStream("D:\\c#\\MovieApps\\AdminModule\\bin\\Debug\\User.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(fs);
                Console.WriteLine("Enter User Name : ");
                string UserName = Console.ReadLine();
                Console.WriteLine("Enter User Id: ");
                string UserId = Console.ReadLine();
                Console.WriteLine("Enter User Password");
                string password = Console.ReadLine();
                Console.WriteLine("Enter user Level (2 or 3 or 5) : ");
                string level = Console.ReadLine();
                sw.WriteLine(UserName + "-" + UserId + "-" + password + "-" + level);
                Console.WriteLine("User Added Successfully..");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message : " + ex.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
                fs.Dispose();
            }
        }
        public void Read()
        {
            FileStream fs = new FileStream("User.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            while (!sw.EndOfStream)
            {
                var data = sw.ReadLine().Split('-');
                User u = new User();
                u.UserName = data[0];
                u.UserId = long.Parse( data[1]);
                u.Password = data[2];
                u.userLevel = Int32.Parse(data[3]);
                UserList.Add(u);
            }
            foreach (var item in UserList)
            {
                Console.WriteLine($"User Name : {item.UserName}");
            }
        }
        public static bool Request1(string s)
        {
            Console.WriteLine($"Enter yes or no to approve {s}");
            string ans = Console.ReadLine();
            if(ans == "yes" || ans == "Yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
