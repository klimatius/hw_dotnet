using System;
using System.Collections;
using System.Collections.Generic;

namespace HW._10.Task3
{
    class Engineer : IComparer<Engineer>
    {
        internal string company;
        internal Guid id;
        internal string firstName;
        internal string lastName;
        internal int experience;
        internal string gitHub;
        internal int salary = 500;
        internal virtual ArrayList responsibilities { get; set; }
        internal virtual ArrayList technologies { get; set; }
        internal virtual int Salary { get { return this.salary; } set => salary = value; }

        internal virtual void Display()
        {
            Console.WriteLine($"Company: {company}, Full name: {firstName} {lastName}, Expirience: {experience}, Title: Junior, Salary: {salary}, GitHub: {gitHub}" );
        }

        internal virtual void ShowResponsibilities()
        {
            Console.WriteLine("Responsibilitie: ");
            foreach (var item in responsibilities)
            {
                Console.WriteLine(item) ;
            }
        }

        public int Compare(Engineer eng1, Engineer eng2)
        {
            if (eng1.experience > eng2.experience)
                return -1;
            else if (eng1.experience < eng2.experience)
                return 1;
            else
                return 0;
        }
    }
}


