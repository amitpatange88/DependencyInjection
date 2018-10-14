using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class EmployeeOperations
    {
        public bool ProcessEmployeeDetails()
        {
            bool IsProcessed = false;

            //process all operations related to employee here.
            DataAccessor da = new DataAccessor();
            var emp = da.GetEmployeeData();

            if (emp != null)
                IsProcessed = true;

            return IsProcessed;
        }
    }
}
