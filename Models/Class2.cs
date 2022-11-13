using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace probeersel.Models
{
    internal class Class2
    { 
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string? Minit { get; set; }
        public string Lastname { get; set; }
        public int JobId { get; set; }
        public string? JobLevel { get; set; }
        public int PublisherId { get; set; }
        public DateTime HireDate { get; set; }
        public Job Job { get; set; }
        public Publisher Publisher { get; set; }
    }
}
    }
}
