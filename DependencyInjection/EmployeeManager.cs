using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class EmployeeManager
    {
        public void EmployeeDetails()
        {
            EmployeeOperations eop = new EmployeeOperations();
            eop.ProcessEmployeeDetails();
        }
    }
}
