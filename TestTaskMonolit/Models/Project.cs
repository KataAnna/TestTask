using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskMonolit.Models
{
    public class Project
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }
        [Display(Name ="Worker Id")]
        public int ProgrammerId { get; set; }
        [Display(Name ="Workers Surname")]
        public string LastName { get; set; }

        public ICollection<OrderViewModel> OrderViewModels { get; set; }
        public Project()
        {
            OrderViewModels = new List<OrderViewModel>();
        }
    }
}
