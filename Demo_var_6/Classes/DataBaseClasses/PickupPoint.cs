using System;
using System.Collections.Generic;

namespace Demo_var_6.Classes.DataBaseClasses;

public partial class PickupPoint
{
    public int Id { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
