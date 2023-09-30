namespace Vending.Models
{

  public class OrderDto
  {
      public decimal OrderId { get; set; }
      public string? OrderCode { get; set; }
      public required decimal GoodsVerId { get; set; }
      public required decimal DeviceId { get; set; }
      public required int Quantity { get; set; }
      public required int DeliverQuantity { get; set; }
      public required string PayWay { get; set; }
      public required string TradeOrderCode { get; set; }
      public DateTime CreateTime { get; set; }
      public DateTime? PaidTime { get; set; }
  }

}