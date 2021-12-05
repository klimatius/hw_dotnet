using System;
using System.Collections;
using System.Collections.Generic;
using static HW._10.Task3.Engineer;

namespace HW._10.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Engineer> developers = new List <Engineer>{ };
            Junior jun1 = new ("Junname1", "Junlastname1", 1, "jun1github", "company1");
            Middle mid1 = new("midname1", "midlastname1", 2, "mid1github", "company1");
            Senior sen1 = new("senname1", "senlastname1", 6, "sen1github", "company1");
            Senior sen2 = new("senname2", "senlastname2", 4, "sen1github", "company1");
            TeamLeader tl1 = new("tlname1", "tllastname1", 10, "tl1github", "company1");
            Architect arc1 = new("arcname1", "arclastname1", 8, "arc1github", "company1");
            developers.Add(jun1);
            developers.Add(mid1);
            developers.Add(sen1);
            developers.Add(sen2);
            developers.Add(tl1);
            developers.Add(arc1);

            developers.Sort(new Engineer());

            foreach (var item in developers)
            {
                (item as Engineer).Display();
            }
            Console.WriteLine();

            foreach (var item in developers)
            {
                (item as Engineer).ShowResponsibilities();
            }
        }
    }
}
