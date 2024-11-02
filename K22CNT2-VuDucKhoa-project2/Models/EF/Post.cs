using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace K22CNT2_VuDucKhoa_project2.Models.EF
{
    [Table("tb_Post")]
    public class Post:CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Titel { get; set; }
        public int Categorid { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string Imaga { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescriptio { get; set; }
        public string SeoKeyWords { get; set; }
        public virtual Post Posts { get; set; }

    }
}