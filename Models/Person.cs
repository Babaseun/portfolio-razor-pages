using System.Collections.Generic;

namespace Portfolio.Models
{
    public class Person
    {
        /// <summary>
        /// A blue print of a person with all the 
        /// properties
        /// </summary>

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BriefIntroduction { get; set; }
        public string PersonalSummary { get; set; }

        public List<SocialMediaAccount> userSocialMediaAccounts { get; set; } = new List<SocialMediaAccount>();
        public List<Project> userProjects { get; set; } = new List<Project>();
        public List<Skills> userSkills { get; set; } = new List<Skills>();




    }


}
