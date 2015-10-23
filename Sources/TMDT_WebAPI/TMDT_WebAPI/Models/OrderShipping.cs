using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMDT_WebAPI.Models
{
    public class OrderShipping
    {
        public string supplier_key { get; set; }
        public string order_id { get; set; }
        public string product_id { get; set; }
        public string product_quantity { get; set; }
        public DateTime product_date { get; set; }
    }
}