using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DependencyInjection.DInjection;

namespace DependencyInjection.UnitTestcase
{
    [TestClass]
    public class EmployeeManagerDIUnitTest
    {
        public Mock<IDataAccessorDI> _MockObj;

        [TestInitialize]
        public void SetUp()
        {
            _MockObj = new Mock<IDataAccessorDI>();
        }

        [TestMethod]
        public void EmployeeDetailsDI_Always_ReturnEmployees()
        {
            Employee emp1 = new Employee() {
                FullName = "Roy Miller",
                EmpId = Guid.NewGuid(),
                Department = 999
            };

            _MockObj.Setup(x => x.GetEmployeeData()).Returns(emp1);
            EmployeeOperationsDI emp = new EmployeeOperationsDI(_MockObj.Object);
            emp.ProcessEmployeeDetails();
        }
    }
}
