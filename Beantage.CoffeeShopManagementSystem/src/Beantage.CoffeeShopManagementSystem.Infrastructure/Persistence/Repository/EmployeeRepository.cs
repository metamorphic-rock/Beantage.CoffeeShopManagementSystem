using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Repository;
using Beantage.CoffeeShopManagementSystem.Domain.Models;
using Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Repository;

public class EmployeeRepository : IEmployeeRepository
{
	private readonly BeantageDbContext _appDbContext;
	public EmployeeRepository(BeantageDbContext appDbContext)
	{
		_appDbContext = appDbContext;
	}
    public async Task<Employee> CreateEmployee(Employee employee)
    {
        await _appDbContext.Employees.AddAsync(employee);
		await _appDbContext.SaveChangesAsync();
		return employee;
    }

    public async Task DeleteEmployee(int EmployeeId)
    {
        var item = await _appDbContext.Employees.FirstOrDefaultAsync(x => x.Id == EmployeeId);
		if (item == null)
		{
			throw new Exception("Cannot find the item");
		}
		_appDbContext.Employees.Remove(item);
		await _appDbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Employee>> GetAllEmployees()
    {
        return await _appDbContext.Employees.ToListAsync();
    }

    public async Task<Employee> GetEmplopyeeById(int id)
    {
		var item = await _appDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
		return item;
    }

    public async Task<Employee> UpdateEmployee(int employeeId, Employee employee)
    {
        var item = await _appDbContext.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);
		if (item == null)
		{
			throw new Exception("Cannot find the item");
		}
		item.FirstName = employee.FirstName;
		item.LastName = employee.LastName;
		item.EmailAddress = employee.EmailAddress;
		item.Address = employee.Address;
		item.ContactNumber = employee.ContactNumber;
		item.Attendances = employee.Attendances;
		item.DateHired = employee.DateHired;
		item.Role = employee.Role;
		item.RoleId = employee.RoleId;
		item.SalaryPerDay = employee.SalaryPerDay;
		item.IsActive = employee.IsActive;
	
		await _appDbContext.SaveChangesAsync();
		return item;

    }
}