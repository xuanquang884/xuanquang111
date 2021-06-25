namespace BaiTap_3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(100, ErrorMessage = "Không quá 100 kí tự")]
        public string title { get; set; }
        [Display(Name = "Tiêu Đề")]

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(255,ErrorMessage ="Không được để trống")]
        public string description { get; set; }
        [Display(Name = "Mô Tả")]

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(30,ErrorMessage ="Không quá 30 kí tự")]
        public string author { get; set; }
        [Display(Name = "Tác Giả")]

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(255)]
        public string image { get; set; }
        [Display(Name = "Hình Ảnh")]

        [Required(ErrorMessage = "Không được để trống")]
        [Range(1000, 1000000, ErrorMessage = "Giá không thể vượt quá 100000 và không thể thấp hơn 1000")]
        public int price { get; set; }
        [Display(Name = "Giá")]
    }
}
