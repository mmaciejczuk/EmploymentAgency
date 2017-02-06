using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class EAContext : DbContext
    {
        public EAContext()
            : base()
        { 
                           
        }

        public DbSet<Email> Email { get; set; }
        public DbSet<JobCategory> JobCategory { get; set; }
        public DbSet<JobOffer> JobOffer { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}