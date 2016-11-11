using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Models
{
   public class ProjectDbContext:DbContext
    {
        public DbSet<Animal> Animals { get; set; }
    }
}
