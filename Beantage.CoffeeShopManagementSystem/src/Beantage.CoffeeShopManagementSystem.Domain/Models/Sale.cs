﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Domain.Models;

public class Sale
{
    [Key]
    public int Id { get; set; }
    [Required]
    public List<SoldItem> SoldItems { get; set; }
    [Required]
    public decimal TotalPrice { get; set; }
    public DateTime TransactionDate { get; set; }
}
