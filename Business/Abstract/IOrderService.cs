using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        List<Order> GetByCustomerId(string customerId);
        List<Order> GetByEmployeeId(int employeeId);
        Order GetByOrderId(int id);
    }
}
