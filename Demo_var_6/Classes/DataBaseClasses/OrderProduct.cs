using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_var_6.Classes.DataBaseClasses
{
    class OrderProduct
    {
        [Required]
        public int OrderID { get; set; }

        [Required]
        [MaxLength(100)]
        public string ProductArticleNumber { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("ProductArticleNumber")]
        public virtual Product Product { get; set; }
    }
}
