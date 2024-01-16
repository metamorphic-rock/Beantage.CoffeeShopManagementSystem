using Beantage.CoffeeShopManagementSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Application.Interfaces.Repository;

public interface IEmployeeRepository
{
    public Task<Employee> CreateEmployee(Employee employee);
    public Task<Employee> UpdateEmployee(int employeeId, Employee employee);
    public Task<IEnumerable<Employee>> GetAllEmployees();
    public Task<Employee> GetEmplopyeeById (int id);
    public Task DeleteEmployee(int employeeId);
}
