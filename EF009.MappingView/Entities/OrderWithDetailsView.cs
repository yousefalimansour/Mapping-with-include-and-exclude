﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF009.MappingView.Entities
{
    public class OrderWithDetailsView
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerEmail { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return $"#{OrderId}: {OrderDate},{ProductName} " +
                $"X {Quantity} @ {UnitPrice.ToString("C")}";
        }

    }
}
