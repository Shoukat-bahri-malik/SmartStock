using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class Order:BaseEntity
    {
        public int UserId { get; set; }
        public OrderType OrderType { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public string PromoCode { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
        public string Description { get; set; }
    }
}

namespace SmartStock.Models
{
    public enum OrderStatus
    {
        CheckOut,Paid,Failed,Shipped,Delivered,Returned,Cancelled,
        Complete
    }
}

namespace SmartStock.Models
{
    public enum OrderType
    {
        PurchaseOrder,
        CustomerOrder
    }
}