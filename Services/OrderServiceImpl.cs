using System.Collections;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Vending.Data;
using Vending.Models;

namespace Vending.Services
{

  public class OrderServiceImpl : IOrderService
  {
    private readonly VendingContext ctx;

    public OrderServiceImpl(VendingContext vendingContext)
    {
      this.ctx = vendingContext;
    }

    public long GetOrderCount() {
      return (from o in ctx.OmOrders
              join b in ctx.OmBuyProductInfos on o.OrderId equals b.OrderId
              join p in ctx.OmPayInfos on o.OrderId equals p.OrderId
              where p.PayDir == "ACC" && o.CreateTime >= DateTime.Parse("2023-07-25 00:00:00")
              orderby o.CreateTime descending
              select new OrderDto()
              {
                OrderId = o.OrderId,
                OrderCode = o.OrderCode,
                GoodsVerId = b.GoodsVerId,
                DeviceId = b.DeviceId,
                Quantity = b.Numbers.HasValue ? Convert.ToInt32(b.Numbers) : 0,
                DeliverQuantity = b.ActNum.HasValue ? Convert.ToInt32(b.ActNum) : 0,
                PayWay = p.PayWay ?? "",
                TradeOrderCode = p.TradeOrderCode ?? "",
                CreateTime = o.CreateTime,
                PaidTime = p.StateTime
              }
      ).Count();
    }

    public List<OrderDto> GetOrderList(int start)
    {
      return (from o in ctx.OmOrders
              join b in ctx.OmBuyProductInfos on o.OrderId equals b.OrderId
              join p in ctx.OmPayInfos on o.OrderId equals p.OrderId
              where p.PayDir == "ACC" && o.CreateTime >= DateTime.Parse("2023-07-25 00:00:00")
              orderby o.CreateTime descending
              select new OrderDto()
              {
                OrderId = o.OrderId,
                OrderCode = o.OrderCode,
                GoodsVerId = b.GoodsVerId,
                DeviceId = b.DeviceId,
                Quantity = b.Numbers.HasValue ? Convert.ToInt32(b.Numbers) : 0,
                DeliverQuantity = b.ActNum.HasValue ? Convert.ToInt32(b.ActNum) : 0,
                PayWay = p.PayWay ?? "",
                TradeOrderCode = p.TradeOrderCode ?? "",
                CreateTime = o.CreateTime,
                PaidTime = p.StateTime
              }
      ).Skip(start).Take(10).ToList();
    }
  }

}