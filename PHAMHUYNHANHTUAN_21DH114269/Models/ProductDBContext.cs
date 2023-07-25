using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PHAMHUYNHANHTUAN_21DH114269.Models
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions options):base (options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Categorycs> Categories { get; set; }

    }
}
