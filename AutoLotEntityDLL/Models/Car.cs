
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoLotEntityDLL.Repository;

namespace AutoLotEntityDLL.Models
{
    [Table("Inventory")]
   public partial class Car
    {
        [Key]
        public int CarID { get; set; }
        [StringLength(50)]
        public string CarMake { get; set; }

        [StringLength(50)]
        public string CarOwner { get; set; }

        [StringLength(50)]
        public string CarColour { get; set; }


        // exposing a 1 Car ------> 1-* Order relationship
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
