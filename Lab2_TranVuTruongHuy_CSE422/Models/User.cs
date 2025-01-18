using System.ComponentModel.DataAnnotations;

namespace Lab2_TranVuTruongHuy_CSE422.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Fill in your name!")]
        public string Name { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Fill in your email!")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
