﻿using RepositoryPattern.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Repositories
{
    /// <summary>
    /// This interface is a contract to our OrderRepo
    /// </summary>
    interface IOrderRepository :IRepository<Order>
    {
        Order GetOrderByOrderId(int id);
        IEnumerable<Order> GetAllOrders();
    }
}
