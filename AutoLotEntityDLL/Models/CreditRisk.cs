using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoLotEntityDLL.Models
{
    [Table("CreditRisk")]
   public partial class CreditRisk
    {
        [Key]
        public int CustomerID { get; set; }

        [StringLength(50)]
        public string CustomerFirstName { get; set; }

        [StringLength(50)]
        public string CustomerLastName { get; set; }

        [StringLength(50)]
        public string CustomerPhone { get; set; }

    }
}
