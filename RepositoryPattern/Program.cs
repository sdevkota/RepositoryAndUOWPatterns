using RepositoryPattern.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{/// <summary>
/// Entry point of the application 
/// Just for demo purposes. This client app could be a WPF, MVC, or mobile application
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            using(UnitOfWork uow =new UnitOfWork(new SampleContext))
            {
                var customers = uow.Customers;
                var myOrder = uow.Orders.GetOrderByOrderId(2);
            }
        }
    }
}
