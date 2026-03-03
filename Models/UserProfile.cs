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
        [MaxLength(10)]
        public string? Goal { get; set; }

        [Column("experience_level")]
        [MaxLength(12)]
        public string? ExperienceLevel{ get; set; }

        [Column("activity_level")]
        [MaxLength(8)]
        public string? ActivityLevel{ get; set; }
    }
}
