using Microsoft.EntityFrameworkCore;
using System;

namespace comServiceWF
{

    public class MyServiceDb : DbContext
    {
        public MyServiceDb() { 
            //this.Database.EnsureDeleted();
            //this.Database.EnsureCreated();
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

        #region FluentAPI settings
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //client
            modelBuilder.Entity<Client>().HasKey(x => x.Id);
            modelBuilder.Entity<Client>().HasIndex(x=>x.Phone).IsUnique();
            modelBuilder.Entity<Client>().Ignore(x => x.FullName);
            modelBuilder.Entity<Client>().Property(x => x.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Client>().Property(x => x.LastName).HasMaxLength(50);
            modelBuilder.Entity<Client>().Property(x => x.Phone).HasMaxLength(20);
            modelBuilder.Entity<Client>().Property(x => x.City).HasMaxLength(40);
            modelBuilder.Entity<Client>().Property(x => x.Region).HasMaxLength(40);
            modelBuilder.Entity<Client>().Property(x => x.StreetFull).HasMaxLength(140);
            //Credentials
            modelBuilder.Entity<Credential>().HasKey(c => c.ClientId);
            modelBuilder.Entity<Credential>().HasIndex(c => c.Login).IsUnique();
            modelBuilder.Entity<Credential>().HasOne(c => c.Client).WithOne(x => x.Credential)
                                                                    .HasForeignKey<Credential>(c => c.ClientId)
                                                                    .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Credential>().Property(c => c.Login).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Credential>().Property(c => c.Password).IsRequired().HasMaxLength(20);
            //order
            modelBuilder.Entity<Order>().HasKey(o => o.Id);
            //modelBuilder.Entity<Order>().Property(o => o.DateOfWorks).HasColumnType("TIMESTAMP");
            //modelBuilder.Entity<Order>().Property(o => o.DataCreate).HasColumnType("TIMESTAMP").HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<Order>().Property(o=>o.TypeOfWork).HasMaxLength(20);
            modelBuilder.Entity<Order>().HasOne(c=>c.Client).WithMany(o => o.Orders)
                                                                .OnDelete(DeleteBehavior.Cascade);
            //team
            modelBuilder.Entity<Team>().HasKey(t => t.Id);
            modelBuilder.Entity<Team>().HasMany(t=>t.Workers).WithOne(w=>w.Team)
                                                                    .OnDelete(DeleteBehavior.Cascade);
            //worker
            modelBuilder.Entity<Worker>().HasKey(w => w.Id);
            modelBuilder.Entity<Worker>().Property(w => w.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Worker>().Property(w => w.LastName).HasMaxLength(50);
            modelBuilder.Entity<Worker>().Property(w => w.Phone).HasMaxLength(20);
            modelBuilder.Entity<Worker>().Ignore(w => w.FullName);
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region database collection
        public virtual DbSet<Worker> Workers { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Credential> Credentials { get; set; }
        #endregion

    }
}
