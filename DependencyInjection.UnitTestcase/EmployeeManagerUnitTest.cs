using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DependencyInjection.UnitTestcase
{
    [TestClass]
    public class EmployeeManagerUnitTest
    {
        public Mock<EmployeeOperations> _MockObj;

        [TestInitialize]
        public void SetUp()
        {
            _MockObj = new Mock<EmployeeOperations>();
        }

        [TestMethod]
        public void EmployeeDetails_Always_ReturnEmployees()
        {
            EmployeeOperations emp = new EmployeeOperations();
            emp.ProcessEmployeeDetails();
        }
    }
}
