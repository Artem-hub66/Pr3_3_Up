using System;
using System.Collections.Generic;

namespace Pr3_3_Up_Uporov.Models;

public partial class PickUpPoint
{
    public int Id { get; set; }

    public string Address { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public virtual ICollection<OrdersHistory> OrdersHistories { get; set; } = new List<OrdersHistory>();
}
