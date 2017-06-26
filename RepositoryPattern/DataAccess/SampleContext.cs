using RepositoryPattern.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DataAccess
{
    /// <summary>
    /// This is the db contect specific to our application
    /// </summary>
  class SampleContext:DbContext
    {
        /// <summary>
        /// Implements the base class constuctor that takes a connection string param
        /// </summary>
        public SampleContext() : 
            base("name=test")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        /// <summary>
        /// Fluent API configuration
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new System.Data.Entity.Infrastructure.UnintentionalCodeFirstException();
        }
    }
}
