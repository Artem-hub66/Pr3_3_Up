using System;
using System.Collections.Generic;

namespace Pr3_3_Up_Uporov.Models;

public partial class SportTovar
{
    public int Id { get; set; }

    public string Article { get; set; } = null!;

    public string TovarName { get; set; } = null!;

    public int? IdCategory { get; set; }

    public int? IdManufacture { get; set; }

    public int? IdSupliers { get; set; }

    public decimal Price { get; set; }

    public string UnitOfMeasurement { get; set; } = null!;

    public int QuantityInStock { get; set; }

    public string Description { get; set; } = null!;

    public string? Photo { get; set; }

    public int? Discount { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Manufacture? Manufacture { get; set; }

    public virtual Suplier? Suplier { get; set; }
}
