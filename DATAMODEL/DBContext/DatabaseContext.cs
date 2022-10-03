using DATAMODEL.AppUserManager;
using DATAMODEL.DBModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAMODEL.DBContext
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<OrderMaster>? OrderMaster { get; set; }
        public DbSet<OrderDetail>? OrderDetail { get; set; }

    }
}
