using System;
using System.Collections;

namespace HW._10.Task3
{
    class Middle : Engineer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="experience"></param>
        /// <param name="gitHub"></param>
        /// <param name="company"></param>
        internal Middle(string firstName, string lastName, int experience, string gitHub, string company)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.experience = experience;
            this.gitHub = gitHub;
            this.company = company;
            this.id = Guid.NewGuid();
            this.salary = base.salary * 3;
            this.responsibilities = new ArrayList {"Code in such a way that other people can easily manage it.",
                                                    "Change code to make it more efficient.",
                                                    "Break major tasks down into smaller sub-tasks.",
                                                    "Compose testing plans and schedules.",
                                                    "Find major bags in code.",
                                                    "Review code in close detail.",
                                                    "Work on bigger chunks of code at once."};
            this.technologies = new ArrayList {"Languages: C#, Visual Basic . NET, F#",
                                                 "Web frameworks: ASP.NET MVC, ASP.NET API,.",
                                                 "ORM: Entity Framework, NHibernate.",
                                                 "IoC container: Castle Windsor Container, Unity, Structure Map.",
                                                 "Databases: MySQL, MS SQL.",
                                                 "Front-end technologies."};
        }

        internal override void ShowResponsibilities()
        {
            Console.WriteLine("Responsibilitie for middle developer: ");
            foreach (var item in responsibilities)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        internal override void Display()
        {
            Console.WriteLine($"Company: {company}, Full name: {firstName} {lastName}, Expirience: {experience}, Title: Middle, Salary: {salary}, GitHub: {gitHub}");
        }
    }
}
