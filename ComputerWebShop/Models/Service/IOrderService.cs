using ComputerWebShop.Models.Data;
using ComputerWebShop.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerWebShop.Models.Service
{
    public interface IOrderService
    {
        void Add(CreateOrder createOrder);
    }
}
