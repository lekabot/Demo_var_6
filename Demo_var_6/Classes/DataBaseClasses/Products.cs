using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_var_6.Classes.DataBaseClasses
{
    public class Product
    {
        [Key]
        [MaxLength(100)]
        public string ProductArticleNumber { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string MeasuremenUnit { get; set; }

        [Required]
        [Column(TypeName = "decimal(19,4)")]
        public decimal Cost { get; set; }

        [Required]
        public int MaximumDiscount { get; set; }

        [Required]
        [MaxLength(150)]
        public string Manufacturer { get; set; }

        [Required]
        [MaxLength(150)]
        public string Supplier { get; set; }

        [Required]
        [MaxLength(200)]
        public string Category { get; set; }

        [Required]
        public int CurrentDiscount { get; set; }

        [Required]
        public int QuantityInStock { get; set; }

        [Required]
        public string Description { get; set; }

        [MaxLength(200)]
        public string Photo { get; set; }
    }
}
