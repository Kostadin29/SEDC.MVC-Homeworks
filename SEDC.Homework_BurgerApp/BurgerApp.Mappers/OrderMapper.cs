
using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.OrderViewModels;

namespace BurgerApp.Mappers
{

    public static class OrderMapper
    {
        public static OrderListViewModel ToOrderListViewModel(this Order order)
        {
            return new OrderListViewModel()
            {
                Id = order.Id,
                FullName = order.FullName,
                Address = order.Address,
                IsDelivered = order.IsDelivered,
            };
        }

        public static Order ToOrder(this OrderViewModel orderViewModel)
        {
            var orderBurgers = orderViewModel.BurgerId.Select(burgerId => new BurgerOrder { BurgerId = burgerId }).ToList();

            return new Order()
            {
                Id = orderViewModel.Id,
                FullName = orderViewModel.FullName,
                Address = orderViewModel.Address,
                IsDelivered = orderViewModel.IsDelivered,
            };
        }

        public static OrderViewModel ToOrderViewModel(this Order order) {
            return new OrderViewModel()
            {
                Id = order.Id,
                FullName = order.FullName,
                Address = order.Address,
                IsDelivered = order.IsDelivered,
                LocationId = order.LocationId,
                BurgerId = order.BurgerOrders.Select(x => x.BurgerId).ToList()
            };
          }

    }
}
