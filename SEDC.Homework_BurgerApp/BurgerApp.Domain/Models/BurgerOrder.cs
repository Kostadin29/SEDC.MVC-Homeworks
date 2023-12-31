﻿


namespace BurgerApp.Domain.Models
{
    using BurgerApp.Domain.Enums;
    // This is helper table for many to many relationship
    public class BurgerOrder : BaseEntity
    {
        public Burger Burger { get; set; }
        public int BurgerId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public BurgerSizeEnum BurgerSize { get; set; }
    }
}
