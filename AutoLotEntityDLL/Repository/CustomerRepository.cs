using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotEntityDLL.Models;

namespace AutoLotEntityDLL.Repository
{
   public class CustomerRepository : BaseRepository<Customer> , IDisposable
    {
        public CustomerRepository()
        {
            Table = context.Customers;
        }
        public int DeleteCustomer(int? id)
        {
            context.Entry(new Customer() { CustomerID = id ?? 0 }).State = System.Data.Entity.EntityState.Deleted;
            return Save();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
