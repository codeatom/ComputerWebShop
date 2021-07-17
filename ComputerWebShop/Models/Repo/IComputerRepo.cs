using ComputerWebShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerWebShop.Models.Repo
{
    public interface IComputerRepo
    {
        public Computer Create(Computer computer);

        public List<Computer> Read();

        public Computer Read(int id);

        public Computer Update(Computer computer);

        public bool Delete(Computer computer);

    }
}
