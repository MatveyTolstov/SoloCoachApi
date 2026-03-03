using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoloCoachApi.Models
{
    [Table("users_profile")]
    public class UserProfile
    {
        [Key]
        [Column("id_user_profile")]
        public int IdUserProfile { get; set; }

        [Column("height")]
        [Range(140, 230)]
        public required float Height { get; set; }

        [Column("weigth")]
        [Range(40, 180)]
        public required float Weight { get; set; }

        [Column("age")]
        public required int Age { get; set; }

        [Column("gender")]
        [MaxLength(6)]
        public required string Gender { get; set; }

        [Column("goal")]
        public required string Goal {get; set;}

        [ForeignKey(nameof(RoleId))]
        [Column("role_id")]
        public int RoleId { get; set; }
        public virtual Role? Role { get; set; }
    }
}
