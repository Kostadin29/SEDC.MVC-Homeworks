using BurgerApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerApp.DataAccess.DataContext
{
    public class BurgerAppDbContext : DbContext
    {
        // od novata klasa zemi nesto i od starata klasa DbContext
        public BurgerAppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // zemame se od OnModelCreating i pisuvame nesto nashe
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Burger>()
                .HasMany(x => x.BurgerOrders)
                .WithOne(x => x.Burger)
                .HasForeignKey(x => x.BurgerId);

            modelBuilder.Entity<Order>()
                .HasMany(x => x.BurgerOrders)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);

            modelBuilder.Entity<Location>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.Location)
                .HasForeignKey(x => x.LocationId);
        }
    }
}

//        modelBuilder.Entity<Burger>()
//                .HasData(new Burger
//                {
//                    Id = 1,
//                    Name = "Chicken Burger",
//                    Price = 3,
//                    IsVegetarian = false,
//                    IsVegan = false,
//                    HasFries = true

//                },
//                new Burger
//                {
//                    Id = 2,
//                    Name = "Classic Veggie Burger",
//                    Price = 4,
//                    IsVegetarian = true,
//                    IsVegan = false,
//                    HasFries = false

//                },
//                new Burger
//                {
//                    Id = 3,
//                    Name = "Portobello Mushroom Burger",
//                    Price = 6,
//                    IsVegetarian = false,
//                    IsVegan = true,
//                    HasFries = false

//                },
//                new Burger
//                {
//                    Id = 4,
//                    Name = "Bacon Cheeseburger",
//                    Price = 7,
//                    IsVegetarian = false,
//                    IsVegan = false,
//                    HasFries = true

//                },
//                new Burger
//                {
//                    Id = 5,
//                    Name = "Tofu Burger",
//                    Price = 5,
//                    IsVegetarian = false,
//                    IsVegan = true,
//                    HasFries = true
//                });

//            modelBuilder.Entity<Location>()
//                .HasData(
//                new Location()
//                {
//                    Id = 1,
//                    Name = "Equilibrium",
//                    Address = "Metodija Shatorov-Sharlo 11",
//                    OpensAt = "09:00",
//                    ClosesAt = "00:00"
//                },
//                new Location()
//                {
//                    Id = 2,
//                    Name = "Equilibrium",
//                    Address = "Vidoe Smilevski Bato 8",
//                    OpensAt = "09:30",
//                    ClosesAt = "01:00"
//                });

//            modelBuilder.Entity<Order>()
//                .HasData(
//                new Order()
//                {
//                    Id = 1,
//                    FullName = "Stojadin Stojkov",
//                    Address = "Metodija Sharotov Sharlo 23/1",
//                    IsDelivered = false,
//                    LocationId = 2
//                },
//                new Order()
//                {
//                    Id = 2,
//                    FullName = "Petko Petkovski",
//                    Address = "Rilski Kongres 92",
//                    IsDelivered = false,
//                    LocationId = 1
//                },
//                new Order()
//                {
//                    Id = 3,
//                    FullName = "Trajanka Mileva",
//                    Address = "Skopska Crna Gora",
//                    IsDelivered = false,
//                    LocationId = 1

//                }) ;
//        }
//    }
//}
