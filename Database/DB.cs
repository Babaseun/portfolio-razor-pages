using Portfolio.Models;
using System.Collections.Generic;

namespace Portfolio.Database
{
    public class DB
    {/// <summary>
     /// Database Information of users
     /// </summary>
        public static IEnumerable<SocialMediaAccount> Accounts => new List<SocialMediaAccount>
        {
           new SocialMediaAccount
           {
               Id = 1,
               AccountType = "Twitter",
               AccountLink = "https://twitter.com/adeyemi_dev",
               PersonId = 1
           },
            new SocialMediaAccount
           {
               Id = 2,
               AccountType = "Github",
               AccountLink = "https://github.com/Babaseun",
               PersonId = 1
           },

              new SocialMediaAccount
           {
               Id = 3,
               AccountType = "Linkedin",
               AccountLink = "https://github.com/Babaseun",
               PersonId = 1
           },
                new SocialMediaAccount
           {
               Id = 4,
               AccountType = "Facebook",
               AccountLink = "https://github.com/Babaseun",
               PersonId = 1
           }


        };
        public static IEnumerable<Skills> Skills => new List<Skills>
        {
            new Skills{Id= 1,
                      Skill= "Javascript",
                      PersonId= 1},
             new Skills{Id= 2,
                      Skill= "Node js",
                      PersonId= 1},
              new Skills{Id= 3,
                      Skill= "Express Js",
                      PersonId= 1},
               new Skills{Id= 4,
                      Skill= "Flask",
                      PersonId= 1},
                new Skills{Id= 5,
                      Skill= ".Net/C#",
                      PersonId= 1}
        };

        public static IEnumerable<Project> userProjects => new List<Project>
        {
            new Project
            {
                Id= 1,
                ProjectTitle = "A News Website Using React",
                ProjectLink = "https://github.com/Babaseun/news-website",
                ProjectSummary = "These project uses an API which then counsumed using react",
                PersonId = 1
            },
            new Project
            {
                Id= 2,
                ProjectTitle = "A Todo App",
                ProjectLink = "https://github.com/Babaseun/news-website",
                ProjectSummary = "A simple todo app",
                PersonId = 1
            },
            new Project
            {
                Id= 3,
                ProjectTitle = "A Backend using Flask and JWT",
                ProjectLink = "https://github.com/Babaseun/news-website",
                ProjectSummary = "A simple flask app",
                PersonId = 1
            },
            new Project
            {
                Id= 4,
                ProjectTitle = "A News Website Using React",
                ProjectLink = "https://github.com/Babaseun/news-website",
                ProjectSummary = "These project uses an API which then counsumed using react",
                PersonId = 1
            },
            new Project
            {
                Id= 4,
                ProjectTitle = "A Bank App",
                ProjectLink = "https://github.com/Babaseun/news-website",
                ProjectSummary = "A simple ban",
                PersonId = 1
            },
            new Project
            {
                Id= 4,
                ProjectTitle = "A Bank App",
                ProjectLink = "https://github.com/Babaseun/news-website",
                ProjectSummary = "A simple ban",
                PersonId = 1
            }

        };




        public static IEnumerable<Person> Persons => new List<Person> {
               new Person{Id = 1,
                FirstName= "Adeyemi",
                LastName="Onibokun",
                BriefIntroduction= "I am a passionate and creative software engineer.",
                PersonalSummary =@"I am a Software Developer, exceptionally well organized, resourceful,
                professional and highly motivated with more than two years experience and
                a solid background in data structures and algorithms, and excellent
                analytical and problem solving skills; able to handle multiple projects
                while producing high quality work in a fast-paced, deadline-oriented
                environment."


               }
            };
    }
}