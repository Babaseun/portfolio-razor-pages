using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models
{
    public class Skills
    {
        /// <summary>
        /// A blue print based
        /// on what technologies
        /// the user has used
        /// </summary>
        /// 
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Skill { get; set; }
        [ForeignKey("Id")]
        public int PersonId { get; set; }
    }
}
