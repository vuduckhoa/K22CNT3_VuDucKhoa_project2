using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace K22CNT2_VuDucKhoa_project2.Models.EF
{
    [Table("tb_Categor")]
    public class Categor: CommonAbstract
    {
        public Categor() 
        {
            this.News = new HashSet<New>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="ten k dc de trong")]
        [StringLength(150)]
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Descriptio { get; set; }
        [StringLength(150)]

        public string SeoTitle { get; set; }
        [StringLength(250)]

        public string SeoDescriptio { get; set; }
        public int Position { get; set; }
        [StringLength(150)]

        public string SeoKeyWords { get; set; }
        public ICollection<New>News { get; set; }
        public ICollection<Post> Posts { get; set; }

    }
}