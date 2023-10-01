using Vending.Models;

namespace Vending.Services {
  public interface IOrderService
  {
    long GetOrderCount();
    List<OrderDto> GetOrderList(int start);
  }
}