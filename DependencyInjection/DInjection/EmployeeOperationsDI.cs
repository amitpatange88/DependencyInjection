using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.DInjection
{
    public class EmployeeOperationsDI : IEmployeeOperationsDI
    {
        public IDataAccessorDI _DataAccessor;

        public EmployeeOperationsDI()
        {

        }

        public EmployeeOperationsDI(IDataAccessorDI dataAccessor)
        {
            _DataAccessor = dataAccessor;
        }

        public bool ProcessEmployeeDetails()
        {
            bool IsProcessed = false;

            //process all operations related to employee here.
            //calling a getemployeedata through a object which is initialized from 
            //paramertrized constructor which is injected from unity container.
            var emp = this._DataAccessor.GetEmployeeData();

            if (emp != null)
                IsProcessed = true;

            return IsProcessed;
        }
    }
}
