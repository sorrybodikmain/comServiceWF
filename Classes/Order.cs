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
        public DateTime dateOfWorks { get; set; }
        public bool status { get; set; }
        public string Status { get => status ? "accepted" : "rejected"; }
        public void changeStatus()
        {
            status = !status;
        }
        public Order()
        {
            status = true;
        }
        public Order(int clientId, int teamId, DateTime dateTime) : this()
        {
            this.ClientId = clientId;
            this.TeamId = teamId;
            this.dateOfWorks = dateTime;
        }

    }
}
