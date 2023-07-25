using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PHAMHUYNHANHTUAN_21DH114269.Models
{
    public class Customers
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public DateTime Date { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}
