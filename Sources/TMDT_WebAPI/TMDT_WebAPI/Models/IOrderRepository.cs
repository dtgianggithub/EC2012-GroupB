using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDT_WebAPI.Models
{
    interface IOrderRepository
    {
        IEnumerable<OrderModel> GetAll(string supplier_key);

        void Add(OrderShipping item);
    }
}
