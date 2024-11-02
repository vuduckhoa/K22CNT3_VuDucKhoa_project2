using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace K22CNT2_VuDucKhoa_project2.Models.EF
{
    [Table("tb_Order")]
    public class Order:CommonAbstract
    {
        public Order() 
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]

        public string CustomerName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]

        public string Address { get; set; }
        public decimal TotalAmounts { get; set; }
        public int Quantity { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}