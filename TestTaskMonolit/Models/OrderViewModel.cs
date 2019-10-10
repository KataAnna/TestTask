using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskMonolit.Models
{
    public class OrderViewModel
    {
        public int ProjectId { get; set; } // project id
        public string ProjectName { get; set; }//projects name
        public int ProgrammerId { get; set; } // programmers id
        public string LastName { get; set; } //workers Surname
        public Project Project { get; set; } // project
        public Programmer Programmer { get; set; } // Programme
    }
}
