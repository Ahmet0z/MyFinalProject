using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal dal)
        {
            _orderDal = dal;
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public List<Order> GetByCustomerId(string customerId)
        {
            return _orderDal.GetAll(o => o.CustomerId == customerId);
        }

        public List<Order> GetByEmployeeId(int employeeId)
        {
            return _orderDal.GetAll(o => o.EmployeeId == employeeId);
        }

        public Order GetByOrderId(int id)
        {
            return _orderDal.Get(o => o.OrderId == id);
        }
    }
}
