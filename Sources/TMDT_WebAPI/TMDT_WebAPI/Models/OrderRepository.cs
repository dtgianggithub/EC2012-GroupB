using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TMDT_WebAPI.Models
{
    public class OrderRepository : IOrderRepository
    {
        public OrderRepository()
        {
        }

        public IEnumerable<OrderModel> GetAll(string supplier_key)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDBFilename=|DataDirectory|\\TMDT_DB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from HOPDONGMUAHANG", con);
            List<OrderModel> list = new List<OrderModel>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    OrderModel temp = new OrderModel();
                    temp.order_id = reader.GetString(0);
                    temp.product_id = reader.GetString(2);
                    SqlCommand cmdproduct = new SqlCommand("Select * from SANPHAM where MA = '" + temp.product_id + "'", con);
                    using (SqlDataReader readerproduct = cmdproduct.ExecuteReader())
                    {
                        readerproduct.Read();
                        temp.product_name = readerproduct.GetString(1);
                        temp.product_quantity = Int32.Parse(readerproduct.GetString(4));
                    }
                    list.Add(temp);
                }
            }
            con.Close();
            return list;
        }

        public void Add(OrderShipping item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            //add to database
        }
    }
}