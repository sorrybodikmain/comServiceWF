using System;

namespace comServiceWF
{
    public class Order
    {
        public int Id { get; set; }
        public bool status { get; set; }
        public string TypeOfWork { get; set; }
        public DateTime DateOfWorks { get; set; }
        public DateTime DataCreate { get; set; }
        // navigation properties
        #region navigation properties
        public int ClientId { get; set; }
        public int? TeamId { get; set; }
        public virtual Client Client { get; set; }
        public virtual Team? Team { get; set; }
        #endregion
        //readonly prop
        public string Status { get => status ? "Accepted" : "Rejected"; }
        //delegates
        public void updateStatus() => status = !status;
        public string toComplate() => (DateOfWorks - DateTime.Now).ToString();
        //class constructors
        public Order()
        {
            this.updateStatus();
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
