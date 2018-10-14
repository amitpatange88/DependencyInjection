using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.DInjection
{
    public class DataAccessorDI : IDataAccessorDI
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DataAccessorDI()
        {

        }

        public Employee GetEmployeeData()
        {
            //get employee all details. create db object here and call the actual
            //db get employee details method.
            Employee emp = new Employee() {
                FullName = "Steve Roger",
                EmpId = Guid.NewGuid(),
                Department = 100
            };

            return emp;
        }
    }
}
