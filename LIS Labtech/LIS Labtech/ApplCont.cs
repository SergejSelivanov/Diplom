using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS_Labtech
{
    class ApplCont : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplCont() : base("Connectiontring") { }
    }
}
