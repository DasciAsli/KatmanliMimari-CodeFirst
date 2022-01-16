using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DenemeKatmanli_Entities.Model
{
    public class Context:DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
