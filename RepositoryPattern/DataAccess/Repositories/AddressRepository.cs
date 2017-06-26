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
    /// Address Repository Implemenation
    /// </summary>
    class AddressRepository : Repository<Address>,IAddressRepository
    {
        public AddressRepository(SampleContext context):base(context)
        {
            
        }
        /// <summary>
        /// Getting Unique address by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Address GetAddressByAddressId(int id)
        {
            return sampleContext.Addresses.Single(a => a.Id == id);
        }
        /// <summary>
        /// Cast Base class context 
        /// </summary>
        public SampleContext sampleContext
        {
            get { return _context as SampleContext; }
        }
    }
}
