using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace freak_store.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public required string first_name { get; set; }

        [Required]
        public required string Password { get; set; }

        [Required]
        public required int phone { get; set; }

        [Required]
        public required string last_name { get; set; }
        [Required]
        public required string username { get; set; }

        [Required]
        public required string email { get; set; }

        public DateTime create_at { get; set; } = DateTime.Now;

        [Required]
        public DateTime update_at { get; set; }

       [Required]
        public DateTime deleted_at { get; set; }

        public ICollection<UserPayments>? Payments { get; set; }
        public ICollection<UserAddresses>? Addresses { get; set; }
    }
}
