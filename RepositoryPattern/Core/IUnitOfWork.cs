using RepositoryPattern.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
   interface IUnitOfWork: IDisposable
    {
         IAddressRepository Addresses { get; }
         ICustomerRepository Customers { get; }
         IOrderRepository Orders { get; }
         void Save();
    }
}
