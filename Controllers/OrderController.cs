using Microsoft.AspNetCore.Mvc;
using Vending.Data;
using Vending.Models;
using Vending.Services;

namespace Vending.Controllers
{

  public class OrderController : Controller
  {

    private readonly VendingContext _context;

    private readonly IOrderService orderService;

    public OrderController(VendingContext context, IOrderService orderService)
    {
      Console.WriteLine("OrderController Constructor");
      _context = context;
      this.orderService = orderService;
    }


    public List<OrderDto> Index() {
      var orderList = orderService.GetOrderList();
      Console.WriteLine("OrderController Index " + orderList.Count);

      return orderList;
    }

  }


}