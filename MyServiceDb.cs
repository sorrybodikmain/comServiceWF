using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace comServiceWF
{
    //base person-------start
    abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Phone { get; set; }
        public Person(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }
    }
    //base person---------end
    internal class Client : Person
    {
        //properties
        public string Region { get; set; }
        public string City { get; set; }
        public string StreetFull { get; set; }
        public string Password { get; set; }
        //navigation---------
        public ICollection<Order> Orders { get; set; }
        //constructors
        public Client(string firstName, string lastName, string phone, string city, 
            string street,string region, string pass)
            : base(firstName, lastName, phone)
        {
            this.Password = pass;
            this.Region = region;
            this.City = city;
            this.StreetFull = street;
        }
    }
    //one to many(One client has many orders)
    internal class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public Team? Team { get; set; }
        public DateTime dateOfWorks { get; set; }

    }
    //one to one(One client has one team)
    internal class Team
    {
        //properties
        public int Id { get; set; }
        public bool status { get; set; }
        public string Status { get => status ? "working" : "not working"; }
        //navigation properties
        public ICollection<Worker> workers { get; set; }
        public Order order { get; set; }
        public void show_team()
        {
            Console.WriteLine($"team id: {Id} and status: {Status}");
        }
        public Team() { status = false; }

    }
    //one to many(One team has many workers)
    internal class Worker : Person
    {
        private int salary;
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
        public Team Team { get; set; }
        public Worker(string firstName, string lastName, string phone, int salary)
            : base(firstName, lastName, phone)
        {
            Salary = salary;
        }
        public void updateSalary(int s)
        {
            Salary = s;
        }
    }

    internal class MyServiceDb : DbContext
    {
        public MyServiceDb()
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=CommunalServiceDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region FluentAPI
            //client
            modelBuilder.Entity<Client>().HasKey(x => x.Id);
            //order
            modelBuilder.Entity<Order>().HasKey(o => o.Id);
            //team
            modelBuilder.Entity<Team>().HasKey(t => t.Id);
            //worker
            modelBuilder.Entity<Worker>().HasKey(w => w.Id);
            #endregion
        }

    }
}
