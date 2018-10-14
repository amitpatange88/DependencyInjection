using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class DataAccessor 
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DataAccessor()
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
