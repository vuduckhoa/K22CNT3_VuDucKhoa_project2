using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace K22CNT2_VuDucKhoa_project2.Models.EF
{
    [Table("tb_Product")]
    public class Product:CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Title { get; set; }
        public int ProductcategorID { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string Imaga { get; set; }
        public decimal Price { get; set; }
        public decimal PriceSale { get; set; }
        public bool IsHome { get; set; } 
        public bool IsHot { get; set; }
        public bool IsSale { get; set; }
        public bool IsFeature { get; set; }
        public int Quantity { get; set; }
        public string SeoKeyWords { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public virtual Productcategor Productcategor { get; set; }

    }
}