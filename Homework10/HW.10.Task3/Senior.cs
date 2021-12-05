using System;
using System.Collections;

namespace HW._10.Task3
{
    class Senior : Engineer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="experience"></param>
        /// <param name="gitHub"></param>
        /// <param name="company"></param>
        internal Senior(string firstName, string lastName, int experience, string gitHub, string company)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.experience = experience;
            this.gitHub = gitHub;
            this.company = company;
            this.id = Guid.NewGuid();
            this.salary = base.salary * 5 + 300;
            this.responsibilities = new ArrayList {"Performing coding assignments.",
                                                    "Reviewing code work for accuracy and functionality.",
                                                    "Creating and implementing design plans.",
                                                    "Analyzing code segments regularly.",
                                                    "Keeping up-to-date with industry trends and technology developments."};
            this.technologies = new ArrayList {"Web Services. A web service is software that is available on the internet and uses a specific messaging system.",
                                                 "SQL.Javascript",
                                                 "Procedures.",
                                                 "Jquery.CSS.Html.",
                                                 "Net MVC"};
        }

        internal override void ShowResponsibilities()
        {
            Console.WriteLine("Responsibilitie for senior developer: ");
            foreach (var item in responsibilities)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        internal override void Display()
        {
            Console.WriteLine($"Company: {company}, Full name: {firstName} {lastName}, Expirience: {experience}, Title: Senior, Salary: {salary}, GitHub: {gitHub}");
        }
    }
    
}
