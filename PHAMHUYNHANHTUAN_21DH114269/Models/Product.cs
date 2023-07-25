using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PHAMHUYNHANHTUAN_21DH114269.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public Categorycs Category { get; set; }
        
    }
}
