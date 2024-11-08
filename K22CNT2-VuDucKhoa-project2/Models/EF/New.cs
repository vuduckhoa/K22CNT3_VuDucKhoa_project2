using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K22CNT2_VuDucKhoa_project2.Models.EF
{
    [Table("tb_New")]
    public class New:CommonAbstract
    {
        internal int CategorId;

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="k dc de trong")]
        [StringLength(150)]
        public string Titel { get; set; }
        public string Alias { get; set; }

        public int Categorid { get; set; }
        public string Description { get; set; }
        [AllowHtml]
        public string Detail { get; set; }
        public string Imaga { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescriptio { get; set; }
        public string SeoKeyWords { get; set; }
        public virtual Categor  Categor { get; set; }
    }
}