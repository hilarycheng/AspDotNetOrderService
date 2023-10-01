using Microsoft.AspNetCore.Mvc;
using Vending.Data;
using Vending.Models;
using Vending.Services;

namespace Vending.Controllers
{

  public class OrderController : Controller
  {

    private readonly IOrderService orderService;

    public OrderController(IOrderService orderService)
    {
      Console.WriteLine("OrderController Constructor");
      this.orderService = orderService;
    }


    [Route("/Order/{start:int}")]
    public OrderDtoResult Index(int start) {
      var orderList  = orderService.GetOrderList(start);
      var totalCount = orderService.GetOrderCount();
      Console.WriteLine($"OrderController Index {start} {orderList.Count}");

      return new OrderDtoResult {
        TotalRecords = totalCount,
        Records = orderList
      };
    }

  }


}