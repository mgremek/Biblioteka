using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public OrderStatus OrderStatus { get; set; }
            
        public virtual Client  Client { get; set; }
        public enum OrderStatus
        {
            

        }
    }
}