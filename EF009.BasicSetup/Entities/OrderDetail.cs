﻿namespace EF009.BasicSetup.Entities
{

    public class OrderDetail
    {
        public int ProductId { get; set; }
        public int OrderId {  get; set; } 
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
