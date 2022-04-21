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
        //navigation---------
        #region navigation props
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Credential Credential { get; set; }
        #endregion
        //constructors
        public Client() { }
        public Client(string firstName, string lastName, string phone, string city, string street, string region)
            : base(firstName, lastName, phone)
        {
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
