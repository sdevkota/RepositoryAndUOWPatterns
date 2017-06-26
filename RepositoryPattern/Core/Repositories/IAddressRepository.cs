using RepositoryPattern.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Repositories
{
    /// <summary>
    /// This interface is a contract to our AddressRepo
    /// </summary>
    interface IAddressRepository:IRepository<Address>
    {
       Address GetAddressByAddressId(int id);
    }
}
