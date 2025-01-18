using System.ComponentModel.DataAnnotations;

namespace Lab2_TranVuTruongHuy_CSE422.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
