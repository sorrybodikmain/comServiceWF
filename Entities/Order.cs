using System;

namespace comServiceWF
{
    public class Order
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string TypeOfWork { get; set; }
        public DateTime DateOfWorks { get; set; }
        public DateTime DataCreate { get; set; }
        public string toComplate()
        {
            int days = Convert.ToInt32((DateOfWorks - DateTime.Now).TotalDays);
            if (days > 0)
            {
                return $"{days} days";
            }
            else
            {
                return "Complete";
            }
        }
        // navigation properties
        #region navigation properties
        public int ClientId { get; set; }
        public int? TeamId { get; set; }
        public virtual Client Client { get; set; }
        public virtual Team? Team { get; set; }
        #endregion
        //readonly prop
        public string GetStatus { get => Status ? "Accepted" : "Rejected"; }
        //delegates
        public void UpdateStatus() => Status = !Status;
        public void changeTeamId(int id) => TeamId = id;
        //class constructors
        public Order()
        {
            this.UpdateStatus();
        }
        public Order(int clientId, int teamId, DateTime dateTime, string type) : this()
        {
            this.ClientId = clientId;
            this.TeamId = teamId;
            this.DateOfWorks = dateTime;
            this.DataCreate = DateTime.Now;
            this.TypeOfWork = type;
        }

    }
}
