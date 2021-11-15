using System;
using System.Text;
using System.Text.RegularExpressions;

namespace HW08.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string postString = "12 Main Street St. Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 564";
            string zip = string.Empty;

            do
            {
                Console.WriteLine("Enter ZIP code: \nFor exit enter empty string");
                zip = Console.ReadLine();
                if (zip != string.Empty)
                    Console.WriteLine(Program.Travel(postString, zip));
            }
            while (zip != string.Empty);
            Console.WriteLine();
        }

        static string Travel(string addresses, string zipCode)
        {
            if (!Program.CheckZip(zipCode))
                return "You enter zip code in wrong format";

            string[] addrArr = addresses.Split(',');
            int arrLength = addrArr.Length;
            int zipLength = zipCode.Length;
            int houseNumIndex = 0;
            StringBuilder zipAddresses = new StringBuilder($"{zipCode}:");
            StringBuilder houseNumbers = new StringBuilder();

            for (int i = 0; i < arrLength; i++)
            {
                if (addrArr[i].Contains(zipCode))
                {
                    houseNumIndex = addrArr[i].IndexOf(' ');
                    houseNumbers.Append(addrArr[i], 0, houseNumIndex).Append(',');
                    addrArr[i] = addrArr[i].Remove(0, houseNumIndex);
                    addrArr[i] = addrArr[i].Remove(addrArr[i].Length - zipLength).Trim();
                    zipAddresses.Append($"{addrArr[i]}").Append(',');
                   
                }
            }

            if (zipAddresses.Length == zipCode.Length + 1)
                return $"No addresses for zip: {zipCode}";

            zipAddresses.Remove(zipAddresses.Length - 1, 1);
            houseNumbers.Remove(houseNumbers.Length - 1, 1);
            zipAddresses.Append($"/{houseNumbers}");

            return zipAddresses.ToString();
        }

        static bool CheckZip(string zip)
        {
            if (!Char.IsLetter(zip[0]))
                return false;
            if (!Char.IsLetter(zip[1]))
                return false;
            if (!Char.Equals(zip[2], ' '))
                return false;

            int zipLength = zip.Length;
            for (int i = 3; i < zipLength; i++)
            {
                if (!Char.IsNumber(zip[i]))
                    return false;
            }

            return true;
        }
    }
}
