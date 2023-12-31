﻿namespace BurgerApp.Domain.Models
{
    public class Burger : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }
        public bool IsOnPromotion { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public List<BurgerOrder> BurgerOrders { get; set; } = new List<BurgerOrder>();

    }
}
