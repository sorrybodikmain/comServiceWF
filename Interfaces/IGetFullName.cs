using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comServiceWF.Interfaces
{
    internal interface IGetFullName : IGetId
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; }
    }
}
