using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Domain.Models;

public class SoldItem
{
    [Key]
    public int Id { get; set; }
    [Required]
    public Product Product { get; set; }
    public int ProductId { get; set; }
    [Required]
    public Sale Sale { get; set; }
    public int SaleId { get; set; }
    [Required]
    public int QuantitySold { get; set; }
    public decimal Price { get; set; }
}
