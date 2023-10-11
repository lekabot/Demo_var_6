using System;
using System.Collections.Generic;

namespace Demo_var_6.Classes.DataBaseClasses;

public partial class Order
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime DeliveryDate { get; set; }

    public int PickupPointId { get; set; }

    public int? UserId { get; set; }

    public int ReceivingCode { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual PickupPoint PickupPoint { get; set; } = null!;

    public virtual User? User { get; set; }
}
