using System;
using System.Collections.Generic;

namespace Pr3_3_Up_Uporov.Models;

public partial class OrdersHistory
{
    public int Id { get; set; }

    public int? PickUpPointId { get; set; }

    public string? UserFioId { get; set; }

    public int Code { get; set; }

    public string? OrderStatus { get; set; }

    public virtual OrderStatus? OrderStatusNavigation { get; set; }

    public virtual PickUpPoint? PickUpPoint { get; set; }

    public virtual User? UserFio { get; set; }
}
