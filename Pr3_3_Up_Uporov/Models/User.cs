using System;
using System.Collections.Generic;

namespace Pr3_3_Up_Uporov.Models;

public partial class User
{
    public int Id { get; set; }

    public int IdRole { get; set; }

    public string UserFio { get; set; } = null!;

    public string UserLogin { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public virtual Role IdRoleNavigation { get; set; } = null!;

    public virtual ICollection<OrdersHistory> OrdersHistories { get; set; } = new List<OrdersHistory>();
}
