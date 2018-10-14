using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Employee
    {
        public Guid EmpId { get; set; }

        public string FullName { get; set; }

        public int Department { get; set; }
    }
}
