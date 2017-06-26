using RepositoryPattern.Core.Models;
using RepositoryPattern.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DataAccess.Repositories
{
    /// <summary>
    /// Customer Repo
    /// </summary>
  class CustomerRepository:Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SampleContext context):base(context)
        {

        }
        /// <summary>
        /// Casting the base class context to this class
        /// </summary>
        public SampleContext sampleContext
        {
            get { return _context as SampleContext; }
        }
        /// <summary>
        /// Get all the Customers from the database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customer> GetAllCustomers()
        {
            return sampleContext.Customers.ToList();
        }
        /// <summary>
        /// Get Customer by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customer GetCustomerById(int id)
        {
            return sampleContext.Customers.Single(c => c.Id == id);
        }
    }
}
