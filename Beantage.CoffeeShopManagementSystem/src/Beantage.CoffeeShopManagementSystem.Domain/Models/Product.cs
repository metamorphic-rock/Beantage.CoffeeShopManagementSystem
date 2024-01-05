using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Domain.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public ProductCategory Category { get; set; }
    public string Description { get; set; }
    [Required]
    public decimal UnitPrice { get; set; }
    public DateTime CreatedOn { get; set; }
    public int QuantityAvailable { get; set; }
    public bool IsDiscontinued { get; set; }
}
