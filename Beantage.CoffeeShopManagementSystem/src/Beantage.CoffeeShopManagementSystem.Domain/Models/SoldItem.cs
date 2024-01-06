using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Domain.Models;

public class SoldItem
{
    [Key]
    public int Id { get; set; }
}
