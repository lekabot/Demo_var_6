using System;
using System.Collections.Generic;

namespace Demo_var_6.Classes.DataBaseClasses;

public partial class Product
{
    public string ProductArticleNumber { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string MeasuremenUnit { get; set; } = null!;

    public decimal Cost { get; set; }

    public int MaximumDiscount { get; set; }

    public string Manufacturer { get; set; } = null!;

    public string Supplier { get; set; } = null!;

    public string Category { get; set; } = null!;

    public int CurrentDiscount { get; set; }

    public int QuantityInStock { get; set; }

    public string Description { get; set; } = null!;

    public string? Photo { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
}
