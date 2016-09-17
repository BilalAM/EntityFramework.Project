using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotEntityDLL.Models;
namespace AutoLotEntityDLL.Repository
{
    public class OrderRepository : BaseRepository<Order>, IDisposable
    {
        public OrderRepository()
        {
            Table = context.Orders;
        }
        public int DeleteOrder(int? id)
        {
            context.Entry(new Order() { OrderID = id ?? 0 }).State = System.Data.Entity.EntityState.Deleted;
            return Save();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
