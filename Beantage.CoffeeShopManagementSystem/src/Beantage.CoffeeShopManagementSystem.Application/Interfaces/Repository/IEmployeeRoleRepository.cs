using Beantage.CoffeeShopManagementSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Application.Interfaces.Repository;
public interface IEmployeeRoleRepository
{
    public Task<EmployeeRole> CreateEmployeeRole(EmployeeRole employeeRole);
    public Task<EmployeeRole> UpdateEmployeeRole(int roleId , EmployeeRole employeeRole);
    public Task<IEnumerable<EmployeeRole>> GetAllEmployeeRoles();
    public Task<EmployeeRole> GetEmployeeRoleById(int id);
    public Task DeleteEmployeeRole(int roleId);
}
