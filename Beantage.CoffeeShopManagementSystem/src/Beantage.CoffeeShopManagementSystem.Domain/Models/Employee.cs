using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Domain.Models;

public class Employee
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public EmployeeRole Role { get; set; }
    [ForeignKey("Role")]
    public int RoleId { get; set; }
    public IEnumerable<EmployeeAttendance> Attendances { get; set; }
    public string ContactNumber { get; set; }
    public string EmailAddress { get; set; }
    public string Address { get; set; }
    public double SalaryPerDay { get; set; }
    public DateTime DateHired { get; set; }
	public bool IsActive { get; set; }
}