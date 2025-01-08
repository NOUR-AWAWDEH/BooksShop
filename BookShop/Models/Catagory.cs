using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class Catagory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = "";

        public int DisplayOrder { get; set; }

    }
}
