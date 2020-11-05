using System.Linq;

namespace Portfolio.Models
{
    public class PersonRepository : IPersonRepository
    {



        /// <summary>
        /// Returns the data of the user based
        /// on the ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Person GetPerson(int id)
        {
            var personData = Database.DB.Persons.FirstOrDefault(x => x.Id == id);
            var accounts = Database.DB.Accounts.Where(x => x.PersonId == personData.Id);
            var skills = Database.DB.Skills.Where(x => x.PersonId == personData.Id);
            var projects = Database.DB.userProjects.Where(x => x.PersonId == personData.Id);


            Person data = new Person();

            data.Id = personData.Id;
            data.FirstName = personData.FirstName;
            data.LastName = personData.LastName;
            data.BriefIntroduction = personData.BriefIntroduction;
            data.PersonalSummary = personData.PersonalSummary;
            data.userProjects = projects.ToList();
            data.userSkills = skills.ToList();
            data.userSocialMediaAccounts = accounts.ToList();


            return data;



        }
    }
}
