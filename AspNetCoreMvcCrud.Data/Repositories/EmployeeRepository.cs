using AspNetCoreMvcCrud.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMvcCrud.Data.Repository;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly AspNetCoreMvcCrudContext _context;

    public EmployeeRepository(AspNetCoreMvcCrudContext context)
    {
        _context = context;
    }

    public IEnumerable<Employee> GetAllEmployees()
    {
        return _context.Employees.ToList();
    }

    public Employee GetEmployeeById(int id)
    {
        return _context.Employees.Find(id);
    }

    public void AddEmployee(Employee employee)
    {
        _context.Employees.Add(employee);
    }

    public void UpdateEmployee(Employee employee)
    {
        _context.Entry(employee).State = EntityState.Modified;
    }

    public void DeleteEmployee(int id)
    {
        var employee = _context.Employees.Find(id);
        if (employee != null)
        {
            _context.Employees.Remove(employee);
        }
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}