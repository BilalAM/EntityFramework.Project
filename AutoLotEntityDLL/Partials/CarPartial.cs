using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AutoLotEntityDLL.Models
{
   public partial class Car
    {
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"[CarID: {CarID}] [Car Owner: {CarOwner}] [Car Make: {CarMake}] [Car Colour: {CarColour} ");
            return builder.ToString();
        }
       

        [NotMapped]
        public string CarMakeColour => CarMake + CarColour;
        
    }
}
