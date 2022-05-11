using comServiceWF.Interfaces;
using System;

namespace comServiceWF
{
    public abstract class Person : IGetFullName
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
        public int getId()
        {
            return Id;
        }
    }
}
