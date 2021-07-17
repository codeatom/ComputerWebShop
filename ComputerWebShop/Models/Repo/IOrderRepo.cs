using ComputerWebShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerWebShop.Models.Repo
{
    public interface IOrderRepo
    {
        public Order Create(Order order);
    }
}
