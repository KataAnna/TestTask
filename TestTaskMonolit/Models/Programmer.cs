﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskMonolit.Models
{
    public class Programmer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Email Address")]
        public string Email { get; set; }


        public ICollection<OrderViewModel> OrderViewModels { get; set; }
        public Programmer()
        {
            OrderViewModels = new List<OrderViewModel>();
        }

    }
}
