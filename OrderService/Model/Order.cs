﻿namespace Model
{
    public class Order
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Quantity { get; set; }
    }
}