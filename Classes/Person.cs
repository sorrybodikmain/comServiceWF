using System;

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
}
