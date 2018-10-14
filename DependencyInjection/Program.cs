using DependencyInjection.DInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //WihtoutDIEmployeeCall();
            
            //This is a call using dependency injection and unity container.
            UsingDependencyInjectionCall();

            Console.ReadLine();
        }

        public static void WihtoutDIEmployeeCall()
        {
            EmployeeManager emp = new EmployeeManager();
            emp.EmployeeDetails();
        }

        public static void UsingDependencyInjectionCall()
        {
            Dependency.Register();
            EmployeeManagerDI emp = new EmployeeManagerDI();
            emp.EmployeeDetails();
        }
    }
}
