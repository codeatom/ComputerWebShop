using ComputerWebShop.Models.Data;
using ComputerWebShop.Models.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerWebShop.Models.Service
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepo _orderDetailRepo;

        public OrderDetailService(IOrderDetailRepo orderDetailRepo)
        {
            _orderDetailRepo = orderDetailRepo;
        }

        public OrderDetail Add(OrderDetail orderDetail)
        {
            _orderDetailRepo.Create(orderDetail);

            return orderDetail;
        }
    }
}
