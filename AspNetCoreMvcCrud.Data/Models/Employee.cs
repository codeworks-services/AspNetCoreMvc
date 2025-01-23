namespace AspNetCoreMvcCrud.Data.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmpName { get; set; } = null!;

    public string Position { get; set; } = null!;

    public string Office { get; set; } = null!;

    public decimal Salary { get; set; }
}