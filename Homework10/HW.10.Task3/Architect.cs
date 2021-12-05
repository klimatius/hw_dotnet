using System;
using System.Collections;


namespace HW._10.Task3
{
    class Architect : Engineer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="experience"></param>
        /// <param name="gitHub"></param>
        /// <param name="company"></param>
        internal Architect(string firstName, string lastName, int experience, string gitHub, string company)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.experience = experience;
            this.gitHub = gitHub;
            this.company = company;
            this.salary = base.salary * 12 + 1000;
            this.responsibilities = new ArrayList {"Identify and develop appropriate software architecture based on requirements and design elements contained " +
                                                    "in a system specification.",
                                                    "Participate in the system specification review process to ensure that system requirements can be translated " +
                                                    "into valid software architecture.",
                                                    "Maintain and evolve software architecture documents based on evolving system requirements, industry trends, and technologies.",
                                                    "Create detailed software design and implement and/or maintain code according to assigned responsibilities.",
                                                    "Assist Software Designer/Implementers in creating detailed software design specifications.",
                                                    "Lead software architecture documents review process. "};
            this.technologies = new ArrayList {"Mastery in Object-Oriented Design, Data Structures, Algorithms, and Programming including full software development life cycle.",
                                                "Good understanding of Data Structures & Algorithms, Database Normalization and Data Integrity, and OOPs",
                                                "Expertise in developing high-performance, dependable and secure client/server applications for MS Windows and/or UNIX platforms.",
                                                "Strong experience in SOA, microservices, and No SQL databases",
                                                "Experience in ADO.Net, SQL, and relational database management systems such as Oracle or MS SQL Server is required.",
                                                "Hands-on experience with .NET/C#, ASP.Net, MVC, WCF, Rest Service, and Web API.",
                                                "Working knowledge of multiple programming languages, client-side. technologies, various design patterns, implementation, and testing tools.",
                                                "Exposure to version control management tools such as TFS, Git, etc. "};
        }

        internal override void ShowResponsibilities()
        {
            Console.WriteLine("Responsibilitie for architect developer: ");
            foreach (var item in responsibilities)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        internal override void Display()
        {
            Console.WriteLine($"Company: {company}, Full name: {firstName} {lastName}, Expirience: {experience}, Title: Architect, Salary: {salary}, GitHub: {gitHub}");
        }
    }
}
