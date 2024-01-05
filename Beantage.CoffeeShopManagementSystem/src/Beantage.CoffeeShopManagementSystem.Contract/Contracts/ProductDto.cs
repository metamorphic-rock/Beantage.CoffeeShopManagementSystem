using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Application.Contracts;

public class ProductDto
{

    public int Id { get; set; }
    public string Name { get; set; }
    public ProductCategoryDto Category { get; set; }
    public int CategoryId { get; set; }
    public string Description { get; set; }
    public decimal UnitPrice { get; set; }
    public DateTime CreatedOn { get; set; }
    public int QuantityAvailable { get; set; }
    public bool IsDiscontinued { get; set; }

}
