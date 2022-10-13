using Microsoft.EntityFrameworkCore;
using pairme.API.Core.Entities;
using pairme.API.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairme.API.Core.Context
{

    public class pairme_APIContext : DbContext
    {
        public pairme_APIContext(DbContextOptions<pairme_APIContext> options) : base(options)
        {
        }

        public DbSet<Booking> Booking { get; set; }
        public DbSet<Category> Category { get; set; }
        public  DbSet<Profile> Profile { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
