using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DependencyInjection.DInjection
{
    public class EmployeeManagerDI
    {
        public void EmployeeDetails()
        {
            Dependency.Container.Resolve<IEmployeeOperationsDI>().ProcessEmployeeDetails();
        }
    }
}
