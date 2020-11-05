using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models
{
    public class Project
    {
        /// <summary>
        /// A blue print of a project
        /// with different properties
        /// </summary>
        /// [
        /// 
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]

        public string ProjectTitle { get; set; }
        [MaxLength(50)]

        public string ProjectSummary { get; set; }
        [MaxLength(50)]
        public string ProjectLink { get; set; }
        [ForeignKey("Id")]
        public int PersonId { get; set; }
    }
}
