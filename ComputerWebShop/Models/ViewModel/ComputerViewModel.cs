using ComputerWebShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerWebShop.Models.ViewModel
{
    public class ComputerViewModel
    {
        public Computer Computer { get; set; }

        public List<Computer> ComputerList { get; set; }

        public string CategoryName { get; set; }
    }
}