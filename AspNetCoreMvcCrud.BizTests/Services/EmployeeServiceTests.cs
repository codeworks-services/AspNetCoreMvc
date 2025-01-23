using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspNetCoreMvcCrud.Biz.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreMvcCrud.Data.Models;
using AspNetCoreMvcCrud.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace AspNetCoreMvcCrud.Biz.Service.Tests
{
  

    namespace EmployeeServiceTests
    {
        [TestClass]
        public class EmployeeServiceTests
        {
            private Mock<IEmployeeRepository> _repositoryMock;
            private EmployeeService _employeeService;

            [TestInitialize]
            public void Setup()
            {
                _repositoryMock = new Mock<IEmployeeRepository>();
                _employeeService = new EmployeeService(_repositoryMock.Object);
            }

            [TestMethod]
            public void GetAllEmployees_ShouldReturnAllEmployees()
            {
                // Arrange
                var employees = new List<Employee>
                {
                    new Employee { EmployeeId = 1, EmpName = "John Doe", Office = "Bend", Position = "Developer", Salary = 10000 },
                    new Employee { EmployeeId = 1, EmpName = "Jane Doe", Office = "Portland", Position = "Tester", Salary = 5000 },
                };
                _repositoryMock.Setup(repo => repo.GetAllEmployees()).Returns(employees);

                // Act
                var result = _employeeService.GetAllEmployees();

                // Assert
                Assert.AreEqual(employees, result);
                _repositoryMock.Verify(repo => repo.GetAllEmployees(), Times.Once);
            }

            [TestMethod]
            public void GetEmployeeById_ShouldReturnCorrectEmployee()
            {
                // Arrange
                var employee = new Employee { EmployeeId = 1, EmpName = "John Doe", Office = "Bend", Position = "Developer", Salary = 10000 };
                _repositoryMock.Setup(repo => repo.GetEmployeeById(1)).Returns(employee);

                // Act
                var result = _employeeService.GetEmployeeById(1);

                // Assert
                Assert.AreEqual(employee, result);
                _repositoryMock.Verify(repo => repo.GetEmployeeById(1), Times.Once);
            }

            [TestMethod]
            public void AddEmployee_ShouldCallRepositoryToAddAndSave()
            {
                // Arrange
                var employee = new Employee { EmployeeId = 1, EmpName = "John Doe", Office = "Bend", Position = "Developer", Salary = 10000 };

                // Act
                _employeeService.AddEmployee(employee);

                // Assert
                _repositoryMock.Verify(repo => repo.AddEmployee(employee), Times.Once);
                _repositoryMock.Verify(repo => repo.Save(), Times.Once);
            }

            [TestMethod]
            public void UpdateEmployee_ShouldCallRepositoryToUpdateAndSave()
            {
                // Arrange
                var employee = new Employee { EmployeeId = 1, EmpName = "John Doe", Office = "Bend", Position = "Developer", Salary = 10000 };

                // Act
                _employeeService.UpdateEmployee(employee);

                // Assert
                _repositoryMock.Verify(repo => repo.UpdateEmployee(employee), Times.Once);
                _repositoryMock.Verify(repo => repo.Save(), Times.Once);
            }

            [TestMethod]
            public void DeleteEmployee_ShouldCallRepositoryToDeleteAndSave()
            {
                // Arrange
                var employeeId = 1;

                // Act
                _employeeService.DeleteEmployee(employeeId);

                // Assert
                _repositoryMock.Verify(repo => repo.DeleteEmployee(employeeId), Times.Once);
                _repositoryMock.Verify(repo => repo.Save(), Times.Once);
            }
        }
    }

}