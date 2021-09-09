using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<List<Order>> GetByCustomerId(string customerId);
        IDataResult<List<Order>> GetByEmployeeId(int employeeId);
        IDataResult<Order> GetByOrderId(int id);
    }
}
