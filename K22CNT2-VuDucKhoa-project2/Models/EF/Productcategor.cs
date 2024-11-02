using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace K22CNT2_VuDucKhoa_project2.Models.EF
{
    [Table("tb_Productcategor")]
    public class Productcategor:CommonAbstract
    {
        public Productcategor() 
        {
            this.Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescriptio { get; set; }
        public string SeoKeyWords { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}