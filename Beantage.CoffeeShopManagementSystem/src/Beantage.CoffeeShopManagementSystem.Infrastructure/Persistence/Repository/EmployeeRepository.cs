﻿using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Repository;
using Beantage.CoffeeShopManagementSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Repository;

public class EmployeeRepository : IEmployeeRepository
{
    public Task<Employee> CreateEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Task DeleteEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Employee>> GetAllEmployees()
    {
        throw new NotImplementedException();
    }

    public Task<Employee> GetEmplopyeeById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Employee> UpdateEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }
}