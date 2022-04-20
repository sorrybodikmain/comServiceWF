using System;

namespace comServiceWF
{
    //one to many(One client has many orders)
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? TeamId { get; set; }
        public virtual Client Client { get; set; }
        public virtual Team? Team { get; set; }
        public DateTime DateOfWorks { get; set; }
        public DateTime DataCreate { get; set; }
        public bool status { get; set; }
        public string Status { get => status ? "accepted" : "rejected"; }
        public void changeStatus()
        {
            status = !status;
        }
        public Order()
        {
            this.changeStatus();
        }
        public Order(int clientId, int teamId, DateTime dateTime)
        {
            this.ClientId = clientId;
            this.TeamId = teamId;
            this.DateOfWorks = dateTime;
            this.DataCreate = DateTime.Now;
        }

    }
}
