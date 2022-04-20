using System;
using System.Collections.Generic;

namespace comServiceWF
{
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
}
