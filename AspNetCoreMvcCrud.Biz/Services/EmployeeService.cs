using AspNetCoreMvcCrud.Data.Models;
using AspNetCoreMvcCrud.Data.Repository;

namespace AspNetCoreMvcCrud.Biz.Service;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repository;

    public EmployeeService(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Employee> GetAllEmployees()
    {
        return _repository.GetAllEmployees();
    }

    public Employee GetEmployeeById(int id)
    {
        return _repository.GetEmployeeById(id);
    }

    public void AddEmployee(Employee employee)
    {
        _repository.AddEmployee(employee);
        _repository.Save();
    }

    public void UpdateEmployee(Employee employee)
    {
        _repository.UpdateEmployee(employee);
        _repository.Save();
    }

    public void DeleteEmployee(int id)
    {
        _repository.DeleteEmployee(id);
        _repository.Save();
    }
}