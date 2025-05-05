using System.ComponentModel.DataAnnotations;

namespace TokenSample.Models
{
    public class HocSinhModel
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Address { get; set; }
        public int? Age { get; set; }
    }
}
