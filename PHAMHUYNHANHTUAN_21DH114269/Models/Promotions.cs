using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PHAMHUYNHANHTUAN_21DH114269.Models
{
    public class Promotions
    {
        [Key]
        public int PromotionID { get; set; }
        public int ProductID { get; set; }
        public String Description { get; set; }
        public int Amount { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
