using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace examdmaws.Models
{
    // Models/Order.cs
    public class Order
    {
        public int OrderId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int ItemQty { get; set; }
        public DateTime OrderDelivery { get; set; }
        public string OrderAddress { get; set; }
        public string PhoneNumber { get; set; }
    }



}