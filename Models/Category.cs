using System.ComponentModel.DataAnnotations;

namespace GemJam.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
    }
}