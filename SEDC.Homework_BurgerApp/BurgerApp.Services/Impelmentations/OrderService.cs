using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Mappers;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModels;

namespace BurgerApp.Services.Impelmentations
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepository;

        public OrderService(IRepository<Order> orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        public async Task CreateOrder(OrderViewModel orderViewModel)
        {
            await _orderRepository.Insert(orderViewModel.ToOrder());
        }

        public async Task<int> DeleteOrderById(int id)
        {
            return await _orderRepository.DeleteById(id);
        }

        public async Task EditOrder(OrderViewModel orderViewModel)
        {
            Order orderDb = await _orderRepository.GetById(orderViewModel.Id);

            if(orderDb == null)
            {
                throw new Exception("Order not found");
            }

            orderDb.FullName = orderViewModel.FullName;
            orderDb.Address = orderViewModel.Address;
            orderDb.IsDelivered = orderViewModel.IsDelivered;
            orderDb.Id = orderViewModel.Id;
            orderDb.LocationId = orderViewModel.LocationId;

            await _orderRepository.Update(orderDb);
        }

        public async Task<List<OrderListViewModel>> GetOrdersForCards()
        {
            List<Order> ordersDb = await _orderRepository.GetAll();

            return ordersDb.Select(x => x.ToOrderListViewModel()).ToList();
        }

        public async Task<OrderViewModel> GetOrdersForEditing(int id)
        {
            Order order = await _orderRepository.GetById(id);

            if( order == null)
            {
                throw new Exception("Order was not found");
            }

            OrderViewModel orderViewModel = order.ToOrderViewModel();

            return orderViewModel;
        }
    }
}
