using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TokenSample.Data;

namespace TokenSample.Models
{
    public class HocSinhModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Address { get; set; }
        public int? Age { get; set; }
        public int Malop { get; set; }
        [ForeignKey("Malop")]
        public LopHoc? LopHoc { get; set; }
    }
}
