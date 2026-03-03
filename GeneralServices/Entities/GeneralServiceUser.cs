using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeneralServices.Entities
{
    [Table("GeneralServiceUsers", Schema = "dbo")]
    public class GeneralServiceUser
    {
        [Key]
        public string Id { get; set; }

        [Column("UserName")]
        [Required]
        public string UserName { get; set; }

        [Column("Password")]
        [Required]
        public string Password { get; set; }

        [Column("Status")]
        public bool Status { get; set; }

        [Column("LastLogin")]
        public DateTime LastLogin { get; set; }
    }
}