namespace AutoLotEntityDLL.EF
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using AutoLotEntityDLL.Models;
    using System.Web;
    public class AutoLotEntity : DbContext
    {
        public AutoLotEntity()
            : base("name=AutoLotEntityConnectionString")
        {
        }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CreditRisk> CreditRisks { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
     
    }
}