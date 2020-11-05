using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models
{
    public class SocialMediaAccount
    {/// <summary>
     /// Social media accounts 
     /// belonging to different users
     /// </summary>
     /// 
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string AccountType { get; set; }
        [MaxLength(50)]
        public string AccountLink { get; set; }
        [ForeignKey("Id")]
        public int PersonId { get; set; }
    }
}
