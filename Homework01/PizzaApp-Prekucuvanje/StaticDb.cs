using PizzaApp_Prekucuvanje.Models;

namespace PizzaApp_Prekucuvanje
{
    public static class StaticDb
    {
        public static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza()
            {
                Id = 1,
                Name = "Capricciosa",
                Price = 300,
                IsOnPromotion = true,
                ImageUrl = @"https://360pizza.com/_next/image?q=75&url=http%3A%2F%2Fpizza360-web%2Fmedia%2Fimage%2Fb4%2F81%2Fbcedba8cf0c5e3c6821b2e3b9ccc.jpg&w=1200"
            },
            new Pizza()
            {
                Id = 2,
                Name = "Pepperoni",
                Price = 400,
                IsOnPromotion = false,
                ImageUrl = @"https://sipbitego.com/wp-content/uploads/2021/08/Pepperoni-Pizza-Recipe-Sip-Bite-Go.jpg"
            }
        };
    }
}
