using Business.Abstract;
using Core.Utilities.Results;
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

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll());
        }

        public IDataResult<List<Order>> GetByCustomerId(string customerId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(o => o.CustomerId == customerId));
        }

        public IDataResult<List<Order>> GetByEmployeeId(int employeeId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(o => o.EmployeeId == employeeId));
        }

        public IDataResult<Order> GetByOrderId(int id)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(o => o.OrderId == id));
        }
    }
}
