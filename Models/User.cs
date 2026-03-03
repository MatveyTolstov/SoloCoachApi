using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoloCoachApi.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [Column("id_user")]
        public int IdUser { get; set; }

        [Column("name")]
        [MaxLength(50)]
        public required string Name { get; set; }

        [Column("login")]
        [MaxLength(50)]
        [Required]
        public required string Login { get; set; }

        [Column("password")]
        [Required]
        public required string Password { get; set; }

        [Column("email")]
        [EmailAddress]
        [MaxLength(100)]
        public required string Email { get; set; }

        [ForeignKey(nameof(RoleId))]
        [Column("role_id")]
        public int RoleId { get; set; }
        public virtual Role? Role { get; set; }
    }
}
