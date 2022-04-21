using System;
using System.Collections.Generic;

namespace comServiceWF
{
    //one to many(One team has many orders)
    public class Team
    {
        //properties
        public int Id { get; set; }
        public bool status { get; set; }
        public string Status { get => status ? "working" : "not working"; }
        //navigation properties
        public virtual ICollection<Worker> Workers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public void show_team()
        {
            Console.WriteLine($"team id: {Id} and status: {Status}");
        }
        public Team() { }

    }
}
