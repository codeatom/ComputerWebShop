﻿using ComputerWebShop.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerWebShop.Models.ViewModel
{
    public class CreateCategory
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Computer> ComputerList { get; set; }

        public CreateCategory()
        {
            ComputerList = new List<Computer>();
        }
    }
}