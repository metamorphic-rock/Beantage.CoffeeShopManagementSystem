using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Repository;
using Beantage.CoffeeShopManagementSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Repository;

public class EmployeeRoleRepository : IEmployeeRoleRepository
{
    public Task<EmployeeRole> CreateEmployeeRole(EmployeeRole employeeRole)
    {
        throw new NotImplementedException();
    }

    public Task DeleteEmployeeRole(int roleId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<EmployeeRole>> GetAllEmployeeRoles()
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeRole> GetEmployeeRoleById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeRole> UpdateEmployeeRole(int roleId, EmployeeRole employeeRole)
    {
        throw new NotImplementedException();
    }
}
