using PizzaApp.Models.Domain;
using PizzaApp.Models.Enums;

namespace PizzaApp
{
    public static class StaticDb
    {
        public static int UserId = 2;
        public static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza()
            {
                Id = 1,
                Name = "Carpi",
                Price = 79,
                IsOnPromotion = true,
                ImageUrl =@"https://www.allrecipes.com/thmb/iXKYAl17eIEnvhLtb4WxM7wKqTc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/240376-homemade-pepperoni-pizza-Beauty-3x4-1-6ae54059c23348b3b9a703b6a3067a44.jpg",
                Ingredients = new List<string>(){"Salami Pork/Chicken", "Cheese/Mocarella", "Mushrooms", "Ketchup"},
                PizzaSize = new List<PizzaSize>(){PizzaSize.Normal,PizzaSize.Family},
                HasExtras = false
            },

            new Pizza()
            {
                Id = 2, 
                Name = "Pepperoni",
                Price = 99,
                IsOnPromotion = false,
                ImageUrl =@"https://www.allrecipes.com/thmb/iXKYAl17eIEnvhLtb4WxM7wKqTc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/240376-homemade-pepperoni-pizza-Beauty-3x4-1-6ae54059c23348b3b9a703b6a3067a44.jpg",
                Ingredients = new List<string>(){"Pepperoni", "Cheese/Mocarella", "Ketchup"},
                PizzaSize = new List<PizzaSize>(){PizzaSize.Normal,PizzaSize.Family},
                HasExtras = true
            },

            new Pizza()
            {
                Id = 3,
                Name = "Mexicana",
                Price = 59,
                IsOnPromotion = true,
                ImageUrl = @"https://pizzafina.ca/wp-content/uploads/2021/04/mex.jpg",
                Ingredients = new List<string>(){"Pepperoni", "Kulen", "Bacon", "Beans", "Jalepanos", "Cheese/Mocarella", "Ketchup"},
                PizzaSize = new List<PizzaSize>(){PizzaSize.Normal,PizzaSize.Family},
                HasExtras = false
            }
        };

        public static List<User> Users = new List<User>()
        {
            new User()
            {
                Id = 1, 
                FirstName = "Bob",
                LastName = "Bobsky",
                PhoneNumber = "1234567890",
                Address = new Address("Partizanska", 20, "Skopje")
            },
            new User()
            {
                Id = 2,
                FirstName = "Antonio",
                LastName = "Montana",
                PhoneNumber = "079534123",
                Address = new Address("Rilski Kongres", 11, "Skopje")
            }
        };

        public static List<Order> Orders = new List<Order>()
        {
            new Order()
            {
                Id = 1,
                PizzaId = 1,
                UserId = 2,
                Pizza = Pizzas.First(x=>x.Id == 1),
                User = Users.First(x=>x.Id == 2),
                PaymentMethod = PaymentMethod.Cash,
                UserAddress = new Address("Rilski Kongres", 11, "Skopje")
            },

            new Order()
            {
                Id = 2,
                PizzaId = 2,
                UserId = 2,
                Pizza = Pizzas.First(x=>x.Id == 2),
                User = Users.First(x=>x.Id == 2),
                PaymentMethod = PaymentMethod.Cash,
                UserAddress = new Address("Partizanska", 20, "Skopje")
            }
        };

        
    }
}
