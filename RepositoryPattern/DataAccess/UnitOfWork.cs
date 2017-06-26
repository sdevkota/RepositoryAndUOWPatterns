using RepositoryPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.Core.Repositories;
using RepositoryPattern.DataAccess.Repositories;

namespace RepositoryPattern.DataAccess
{
    /// <summary>
    /// UnitOfWork Implementation
    /// </summary>
    class UnitOfWork : IUnitOfWork

    {
        private readonly SampleContext _context;
        public IAddressRepository Addresses { get; private set; }
        public ICustomerRepository Customers { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public UnitOfWork(SampleContext context)
        {
            _context = context;
            Addresses = new AddressRepository(_context);
            Customers = new CustomerRepository(_context);
            Orders = new OrderRepository(_context);

        }

        /// <summary>
        /// Saving the changes implementation 
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }
        /// <summary>
        /// To dispose the context object after the transaction
        /// </summary>

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
