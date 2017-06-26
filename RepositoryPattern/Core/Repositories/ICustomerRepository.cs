using RepositoryPattern.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Repositories
{
    /// <summary>
    /// This interface is a contract to our CustomerRepo
    /// </summary>
    interface ICustomerRepository :IRepository<Customer>
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
    }
}
