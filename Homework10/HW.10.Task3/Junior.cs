using System;
using System.Collections;


namespace HW._10.Task3
{
    class Junior : Engineer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="experience"></param>
        /// <param name="gitHub"></param>
        /// <param name="company"></param>
        internal Junior(string firstName, string lastName, int experience, string gitHub, string company)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.experience = experience;
            this.gitHub = gitHub;
            this.company = company;
            this.id = Guid.NewGuid();
            this.salary = base.salary;
            this.responsibilities = new ArrayList {"Assisting the development manager with all aspects of software design and coding.",
                                                    "Attending and contributing to company development meetings.",
                                                    "Learning the codebase and improving your coding skills.",
                                                    "Writing and maintaining code.",
                                                    "Working on minor bug fixes."};
            this.technologies = new ArrayList {"Languages: C#, Visual Basic.",
                                                 "Web frameworks: ASP.NET MVC, ASP.NET API.",
                                                 "ORM: Entity Framework, NHibernate."};
        }
        internal override void ShowResponsibilities()
        {
            Console.WriteLine("Responsibilitie for junior developer: ");
            foreach (var item in responsibilities)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        internal override void Display()
        {
            Console.WriteLine($"Company: {company}, Full name: {firstName} {lastName}, Expirience: {experience}, Title: Junior, Salary: {salary}, GitHub: {gitHub}");
        }
    }
}
