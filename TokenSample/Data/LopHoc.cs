using System.ComponentModel.DataAnnotations;

namespace TokenSample.Data
{
    public class LopHoc
    {
        [Key]
        public int MaLop {  get; set; }
        [Required]
        [MaxLength(100)]
        public string? TenLop { get; set; }
        [Required]  
        [MaxLength(100)]
        public string? GiaoVienCN {  get; set; }
    }
}
