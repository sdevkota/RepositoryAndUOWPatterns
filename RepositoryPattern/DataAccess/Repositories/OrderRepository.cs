using RepositoryPattern.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.Core.Models;
using System.Linq.Expressions;

namespace RepositoryPattern.DataAccess.Repositories
{
    /// <summary>
    /// Order Repository Implementation 
    /// </summary>

   class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(SampleContext context):base(context)
        {

        }
        /// <summary>
        /// Get all the orders from the Database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Order> GetAllOrders()
        {
            return sampleContext.Orders.ToList();
        }
        /// <summary>
        /// Get Order by Order Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Order GetOrderByOrderId(int id)
        {
            throw new NotImplementedException();
        }
        public SampleContext sampleContext
        {

            get { return _context as SampleContext; }
        }
    }
}
