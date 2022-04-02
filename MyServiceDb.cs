using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace comServiceWF
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Phone { get; set; }
        public Person() { }
        public Person(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }
        public virtual void Show()
        {
            Console.WriteLine($"ID: {Id}, Fullname: {FullName}");
        }
    }
    public class Client : Person
    {
        //properties
        public string Region { get; set; }
        public string City { get; set; }
        public string StreetFull { get; set; }
        public string Password { get; set; }
        //navigation---------
        public virtual ICollection<Order> Orders { get; set; }
        //constructors
        public Client() { }
        public Client(string firstName, string lastName, string phone, string city, string street, string region, string pass)
            : base(firstName, lastName, phone)
        {
            this.Password = pass;
            this.Region = region;
            this.City = city;
            this.StreetFull = street;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("-------Adress------:");
            Console.WriteLine($"{Region}, {City}, {StreetFull}");
        }
    }
    //one to many(One client has many orders)
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? TeamId { get; set; }
        public virtual Client Client { get; set; }
        public virtual Team? Team { get; set; }
        public DateTime dateOfWorks { get; set; }
        public bool status { get; set; }
        public string Status { get => status ? "accepted" : "rejected"; }
        public void changeStatus()
        {
            status = !status;
        }
        public Order()
        {
            status = true;
        }
        public Order(int clientId, int teamId, DateTime dateTime) : this()
        {
            this.ClientId = clientId;
            this.TeamId = teamId;
            this.dateOfWorks = dateTime;
        }

    }
    //one to many(One team has many orders)
    public class Team
    {
        //properties
        public int Id { get; set; }
        public bool status { get; set; }
        public string Status { get => status ? "working" : "not working"; }
        //navigation properties
        public virtual ICollection<Worker> Workers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public void show_team()
        {
            Console.WriteLine($"team id: {Id} and status: {Status}");
        }
        public Team() { }

    }
    //one to many(One team has many workers)
    public class Worker : Person
    {
        public int salary;
        public int Salary
        {
            get => salary;
            set
            {
                if (value > 6000)
                    salary = value;
                else salary = 6000;
            }
        }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public Worker() { }
        public Worker(string firstName, string lastName, string phone, int salary, int teamId)
            : base(firstName, lastName, phone)
        {
            TeamId = teamId;
            Salary = salary;
        }
        public void updateSalary(int s)
        {
            Salary = s;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Salary: {Salary}, TeamId: {TeamId}");
        }
    }

    public class MyServiceDb : DbContext
    {
        public MyServiceDb() { 
            //this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=CommunalServiceDb;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region FluentAPI
            //client
            modelBuilder.Entity<Client>().HasKey(x => x.Id);
            modelBuilder.Entity<Client>().Ignore(x => x.FullName);
            modelBuilder.Entity<Client>().Property(x => x.Password).HasMaxLength(20);

            //order
            modelBuilder.Entity<Order>().HasKey(o => o.Id);
            //team
            modelBuilder.Entity<Team>().HasKey(t => t.Id);
            modelBuilder.Entity<Team>().Ignore(w => w.Status);
            //worker
            modelBuilder.Entity<Worker>().HasKey(w => w.Id);
            modelBuilder.Entity<Worker>().Ignore(w => w.FullName);
            #endregion
        }
        #region database collection
        public virtual DbSet<Worker> Workers { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        #endregion
    }
}
