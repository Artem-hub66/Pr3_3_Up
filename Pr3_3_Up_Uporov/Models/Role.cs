using System;
using System.Collections.Generic;

namespace Pr3_3_Up_Uporov.Models;

public partial class Role
{
    public int Id { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
