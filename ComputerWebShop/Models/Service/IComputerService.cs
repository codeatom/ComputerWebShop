using ComputerWebShop.Models.Data;
using ComputerWebShop.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerWebShop.Models.Service
{
    public interface IComputerService
    {
        public Computer Add(CreateComputer createComputer);

        public ComputerViewModel All();

        public Computer FindById(int id);

        public Computer Edit(int id, CreateComputer createComputer);

        public CreateComputer ComputerToCreateComputer(Computer computer);

        public bool Remove(int id);
    }
}