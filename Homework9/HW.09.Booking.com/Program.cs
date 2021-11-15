using System;
using System.Collections;

namespace HW._09.Booking.com
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList users = new();
            Users user1 = new("vasyandr", "12w23e", "vasya", "vasyk", "vvv@a.com");
            users.Add(user1);
            if(Users.Login(users, "vasyandr", "12w23e"))
                Console.WriteLine("Login succesed!");
            else Console.WriteLine("Wrong username or password");

            ArrayList apps = new();
            Appartments app1 = new("belarus", "minsk", "prityckogo 91", 33, 100, "usd", 3);
            Appartments app2 = new("belarus", "minsk", "prityckogo 99", 40, 150, "usd", 3);
            Appartments app3 = new("belarus", "grodno", "kupaly 23", 46, 120, "usd", 2);
            Appartments app4 = new("russia", "smolensk", "lenina 3", 50, 160, "usd", 3);
            Appartments app5 = new("russia", "smolensk", "prityckogo 23", 90, 250, "usd", 7);
            apps.Add(app1);
            apps.Add(app2);
            apps.Add(app3);
            apps.Add(app4);
            apps.Add(app5);

            ArrayList searchResults = new();
            searchResults = Appartments.Search(apps, "belarus", "minsk");
            if (searchResults.Count > 0)
            {
                for (int i = 0; i < searchResults.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {(searchResults[i] as Appartments).ToString()}");
                }
            }
            else Console.WriteLine("No results for this filters");

            apps = Appartments.Reservation(apps, "belarus", "minsk");
            searchResults = Appartments.Search(apps, "belarus", "minsk");
            if (searchResults.Count > 0)
            {
                for (int i = 0; i < searchResults.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {(searchResults[i] as Appartments).ToString()}");
                }
            }
            else Console.WriteLine("No results for this filters");
        }
    }
}
