using Vending.Models;

namespace Vending.Services {
  public interface IOrderService
  {
    List<OrderDto> GetOrderList();
  }
}