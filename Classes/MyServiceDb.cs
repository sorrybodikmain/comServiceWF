using Microsoft.EntityFrameworkCore;
using System;

namespace comServiceWF
{
    public class MyServiceDb : DbContext
    {
        public MyServiceDb() { 
            //this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=CommunalServiceDb;Integrated Security=True;");
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=;database=MyComService;",
                new MySqlServerVersion(new Version(8, 0, 11))
            );
        }
        #region FluentAPI
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //client
            modelBuilder.Entity<Client>().HasKey(x => x.Id);
            modelBuilder.Entity<Client>().Ignore(x => x.FullName);
            modelBuilder.Entity<Client>().Property(x => x.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Client>().Property(x => x.LastName).HasMaxLength(50);
            modelBuilder.Entity<Client>().Property(x => x.Phone).HasMaxLength(20);
            modelBuilder.Entity<Client>().Property(x => x.Password).HasMaxLength(20);
            modelBuilder.Entity<Client>().Property(x => x.City).HasMaxLength(30);
            modelBuilder.Entity<Client>().Property(x => x.Region).HasMaxLength(30);
            modelBuilder.Entity<Client>().Property(x => x.StreetFull).HasMaxLength(150);
            //order
            modelBuilder.Entity<Order>().HasKey(o => o.Id);
            //team
            modelBuilder.Entity<Team>().HasKey(t => t.Id);
            modelBuilder.Entity<Team>().Ignore(w => w.Status);
            //worker
            modelBuilder.Entity<Worker>().HasKey(w => w.Id);
            modelBuilder.Entity<Worker>().Property(w => w.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Worker>().Property(w => w.LastName).HasMaxLength(50);
            modelBuilder.Entity<Worker>().Property(w => w.Phone).HasMaxLength(20);
            modelBuilder.Entity<Worker>().Ignore(w => w.FullName);

            
        }
        #endregion
        #region database collection
        public virtual DbSet<Worker> Workers { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        #endregion

    }
}
