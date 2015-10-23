using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMDT_WebAPI.Models
{
    public class OrderModel
    {
        public string order_id { get; set; }
        public string product_id { get; set; }
        public string product_name { get; set; }
        public int product_quantity { get; set; }
    }
}