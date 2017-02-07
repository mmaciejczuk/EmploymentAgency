using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
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

            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            EntityTypeConfiguration<User> userEntityConfig = modelBuilder.Entity<User>();
            userEntityConfig.HasRequired<Role>(s => s.Role).WithMany(s => s.Users);            

            EntityTypeConfiguration<JobOffer> jobOfferEntityConfig = modelBuilder.Entity<JobOffer>();
            jobOfferEntityConfig.HasRequired<Company>(s => s.Company).WithMany(s => s.JobOffers);

            jobOfferEntityConfig.HasRequired<User>(s => s.Users).WithMany(s => s.JobOffers);

            modelBuilder.Entity<Role>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}