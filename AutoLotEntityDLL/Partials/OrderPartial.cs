using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLotEntityDLL.Models
{
   public partial class Order
    {
        public override string ToString()
        {
            return string.Format($"Order ID {OrderID} pending --> Customer ID {CustomerID} on  --> CarID {CarID}");
        }
    }
}
