using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using websitecsharp.domain.entities;

namespace websitecsharp.domain
{
    public class scorecontext : DbContext
    {
        public DbSet<person> Person { get; set; }
        public DbSet<scoredata> HighScore { get; set; }
        public DbSet<Error> ErrorDatabase { get; set; }
    }
}
