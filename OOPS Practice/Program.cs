using PointsAndLines;
using System;

namespace OOPS_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Vishal", Race.Earthling);           
  
            User secondUser = new User();          

            User thirdUser = new User();

            Utilities.ColorfulWriteLine(user.Username, ConsoleColor.DarkRed);
            

            Console.WriteLine(user.ID);
            Console.WriteLine(secondUser.ID);
            Console.WriteLine(thirdUser.ID);
            Console.WriteLine(User.currentID);

            user.Password = 4;
            Console.WriteLine(user.Username);

            Console.ReadLine();
        }
    }
}
