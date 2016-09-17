using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace AutoLotEntityDLL.Models
{
   public partial class Customer
    {
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"[Customer ID: {CustomerID}] [Customer Name: {CustomerFirstName + " " + CustomerLastName}] [Customer Phone: {CustomerPhone} ]");
            return builder.ToString();
        }


        [NotMapped]
        public string CustomerFullName => CustomerFirstName + " " + CustomerLastName;
        
    }
}
