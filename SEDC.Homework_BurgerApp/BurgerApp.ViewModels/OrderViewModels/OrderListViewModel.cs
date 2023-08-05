using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.LocationViewModels;
using System.Data.Common;

namespace BurgerApp.ViewModels.OrderViewModels
{
    public class OrderListViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsDelivered { get; set; }
        //public LocationViewModel LocationInfo { get; set; }

    }
}
