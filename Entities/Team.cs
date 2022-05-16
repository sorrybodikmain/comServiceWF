using System.Collections.Generic;

namespace comServiceWF
{
    //one to many(One team has many orders)
    public class Team
    {
        //properties
        public int Id { get; set; }
        public bool Status { get; set; }
        public string GetStatus { get => Status ? "Working" : "Not working"; }
        public void UpdateStatus() => Status = !Status;
        //navigation properties
        public ICollection<Worker> Workers { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Team() 
        { 
            Status = false;
        }

    }
}
