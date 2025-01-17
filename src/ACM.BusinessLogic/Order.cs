﻿namespace ACM.BusinessLogic
{
    using System;
    using System.Collections.Generic;
    public class Order : EntityBase
    {
        public Order() 
            : this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate == null)
            {
                isValid = false;
            }

            return isValid;
        }
        public override string ToString() => $"{OrderDate.Value.DateTime} ({OrderId})";
    }
}
