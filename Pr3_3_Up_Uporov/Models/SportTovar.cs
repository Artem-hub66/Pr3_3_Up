using System;
using System.Collections.Generic;

namespace Pr3_3_Up_Uporov.Models;

public partial class SportTovar
{
    public int Id { get; set; }

    public string Article { get; set; } = null!;

    public string TovarName { get; set; } = null!;

    public int? TovarCategory { get; set; }

    public int? TovarManufacture { get; set; }

    public int? TovarSupliers { get; set; }

    public decimal Price { get; set; }

    public string UnitOfMeasurement { get; set; } = null!;

    public string? Discount { get; set; }

    public int QuantityInStock { get; set; }

    public string Description { get; set; } = null!;

    public string? PhotoUrl { get; set; }

    public virtual Category? TovarCategoryNavigation { get; set; }

    public virtual Manufacture? TovarManufactureNavigation { get; set; }

    public virtual Suplier? TovarSupliersNavigation { get; set; }
}
