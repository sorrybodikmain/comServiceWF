
namespace comServiceWF
{
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
        #region navigation prop
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        #endregion
        //delegates
        public void updateSalary(int salary) => this.Salary = salary;
        public void updateTeamId(int teamId) => this.TeamId = teamId;
        
        public Worker() {}
        public Worker(string firstName, string lastName, string phone, int salary, int teamId)
            : base(firstName, lastName, phone)
        {
            TeamId = teamId;
            Salary = salary;
        }
    }
}
