using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lab2_TranVuTruongHuy_CSE422.Models
{
    public class DeviceModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Fill in your name!")]
        public string Name { get; set; }
        [Required]
        [ForeignKey("CategoryModel")]
        public int CategoryId { get; set; }
        [Required]
        public string Status { get; set; }

        public DateTime EntryDate { get; set; }
    }
}
