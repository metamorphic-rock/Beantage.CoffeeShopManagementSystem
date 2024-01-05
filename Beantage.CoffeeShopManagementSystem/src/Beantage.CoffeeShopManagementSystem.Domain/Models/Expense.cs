using Beantage.CoffeeShopManagementSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Domain.Models;

public class Expense
{
    [Key]
    public int Id { get; set; }
    [Required]
    public ExpenseType ExpenseType { get; set; }
    [Required]
    public decimal Amount { get; set; }
    [Required]
    public string Description { get; set; }
    public DateTime ExpenseDate { get; set; }
}