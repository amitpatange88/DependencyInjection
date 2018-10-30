using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DependencyInjection.DInjection
{
    public class Dependency
    {
        //create unity container object to store depdendecy objects in container. When require invoke them automatically.
        private static IUnityContainer _container = new UnityContainer();

        public static IUnityContainer Container
        {
            get
            {
                //if (_container == null)
                //{
                //    return new UnityContainer();
                //}

                return _container;      
            }
        }

        public static void Resolver()
        {
            Register();
        }

        public static void Register()
        {
            _container.RegisterType<IEmployeeOperationsDI, EmployeeOperationsDI>();
            _container.RegisterType<IDataAccessorDI, DataAccessorDI>();
        }
    }
}
