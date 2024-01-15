using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Domain.Models;

public class EmployeeRole
{
    public int Id { get; set; }
    public string Role { get; set; }
    public double StartingSalaryPerDay { get; set; }
}
