using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PHAMHUYNHANHTUAN_21DH114269.Models
{
    public class Order
    {
        [Key]
        public int orderID { get; set; }
        public DateTime Date { get; set; }
        public int CustomerID { get; set; }

    }
}
