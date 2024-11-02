using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace K22CNT2_VuDucKhoa_project2.Models.EF
{
    [Table("tb_Adv")]
    public class Adv:CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Tile { get; set; }
        [StringLength(500)]

        public string Description { get; set; }
        [StringLength(500)]

        public string Imaga { get; set; }
        public int Type { get; set; }
        public string Link { get; set; }
    }
}