using System;
using System.Collections.Generic;

namespace NewCoffeeShop.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public double? Price { get; set; }

    public string? Photo { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }
}
