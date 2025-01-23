using AspNetCoreMvcCrud.Data.Models;

namespace AspNetCoreMvcCrud.Data.Repository;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAllEmployees();

    Employee GetEmployeeById(int id);

    void AddEmployee(Employee employee);

    void UpdateEmployee(Employee employee);

    void DeleteEmployee(int id);

    void Save();
}