using System;
using System.Collections;


namespace HW._10.Task3
{
    class TeamLeader : Engineer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="experience"></param>
        /// <param name="gitHub"></param>
        /// <param name="company"></param>
        internal TeamLeader(string firstName, string lastName, int experience, string gitHub, string company)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.experience = experience;
            this.gitHub = gitHub;
            this.company = company;
            this.id = Guid.NewGuid();
            this.salary = base.salary * 8 + 500;
            this.responsibilities = new ArrayList {"Manage the operation and admin.",
                                                    "Lead and motivate the team.",
                                                    "Manage performance.",
                                                    "Solve problems.",
                                                    "Care for the health, safety and welfare of your people."};
            this.technologies = new ArrayList {"5+ years of C# Application development(.Net Core, ASP.Net WebAPI)",
                                                "Strong knowledge of Software design patterns and Practices",
                                                "Experience writing Unit tests and using Unit Test coverage tools",
                                                "Good knowledge of source control management such as Git or SVN TFS",
                                                "Experience working within an Agile environment"};
        }

        internal override void ShowResponsibilities()
        {
            Console.WriteLine("Responsibilitie for team leader developer: ");
            foreach (var item in responsibilities)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        internal override void Display()
        {
            Console.WriteLine($"Company: {company}, Full name: {firstName} {lastName}, Expirience: {experience}, Title: Team Leader, Salary: {salary}, GitHub: {gitHub}");
        }
    }
}
