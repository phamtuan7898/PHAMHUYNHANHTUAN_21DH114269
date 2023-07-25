using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PHAMHUYNHANHTUAN_21DH114269.Models
{
    public class Categorycs
    {
        [Key]
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
