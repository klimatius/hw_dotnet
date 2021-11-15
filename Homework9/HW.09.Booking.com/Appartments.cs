using System;
using System.Collections;

namespace HW._09.Booking.com
{
    internal class Appartments
    {
        string country;
        string city;
        string address;
        double size;
        double price;
        string currency;
        int maxPeopleSize;
        bool reserved;
        Guid id;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="address"></param>
        /// <param name="size"></param>
        /// <param name="price"></param>
        /// <param name="currency"></param>
        /// <param name="maxPeopleSize"></param>
        internal Appartments(string country, string city, string address, double size, double price, string currency, int maxPeopleSize)
        {
            this.country = country;
            this.city = city;
            this.address = address;
            this.size = size;
            this.price = price;
            this.currency = currency;
            this.maxPeopleSize = maxPeopleSize;
            this.reserved = false;
            this.id = Guid.NewGuid();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appsList"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <returns></returns>
        internal static ArrayList Search(ArrayList appsList, string country, string city)
        {
            ArrayList searchResult = new();
            foreach (var item in appsList)
            {
                if ((item as Appartments).reserved == false)
                    if ((item as Appartments).country.Equals(country))
                        if ((item as Appartments).city.Equals(city))
                            searchResult.Add(item);
            }

            return searchResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appsList"></param>
        /// <returns></returns>
        internal static ArrayList Reservation(ArrayList appsList, string country, string city)
        {
            int number = 0;
            bool flag = true;
            ArrayList flatForReserving = new ();
            flatForReserving = Search(appsList, country, city);
            int length = flatForReserving.Count;

            if (length > 0)
            {
                for (int i = 0; i < flatForReserving.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {flatForReserving[i]}");
                }

                while (flag)
                {
                    Console.WriteLine("Enter number of flat for reserving");
                    if (int.TryParse(Console.ReadLine(), out number) && number > 0 && number <= length)
                        flag = false;
                }

                for (int i = 0; i < appsList.Count; i++)
                {
                    if ((flatForReserving[number - 1] as Appartments).id == (appsList[i] as Appartments).id)
                        (appsList[i] as Appartments).reserved = true;
                }
            }
            return appsList;
        }

        public override string ToString()
        {
            return $"City: {city}, address: {address}, size: {size}m2, price: {price}{currency}, maximum people: {maxPeopleSize}" ;
        }
    }
}
