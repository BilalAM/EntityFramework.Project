using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotEntityDLL.Models;
namespace AutoLotEntityDLL.Repository
{
    public class CarRepository : BaseRepository<Car>, IDisposable
    {
        public CarRepository()
        {
            Table = context.Cars;
        }
        public int DeleteCar(int? id)
        {
            context.Entry(new Car() { CarID = id ?? 0}).State = System.Data.Entity.EntityState.Deleted;
            return Save();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
