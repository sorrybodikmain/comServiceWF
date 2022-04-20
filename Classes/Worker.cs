using System;

namespace comServiceWF
{
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
}
