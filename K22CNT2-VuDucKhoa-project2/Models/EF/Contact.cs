using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace K22CNT2_VuDucKhoa_project2.Models.EF
{
    [Table("tb_Contact")]

    public class Contact:CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="ten k dc de trong")]
        [StringLength(150,ErrorMessage ="k dc qua 50kytu")]
       public string Name { get; set; }
        [StringLength(150, ErrorMessage = "k dc qua 50kytu")]

        public string Web { get; set; }
        [StringLength(4000)]

        public string Email { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
    }
}