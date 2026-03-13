using System;
using System.Collections.Generic;

namespace Pr3_3_Up_Uporov.Models;

public partial class OrderStatus
{
    public int Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<OrdersHistory> OrdersHistories { get; set; } = new List<OrdersHistory>();
}
