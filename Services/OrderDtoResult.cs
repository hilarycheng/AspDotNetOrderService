using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Vending.Models
{

  public class OrderDtoResult
  {
    public long TotalRecords { get; set; }

    public required List<OrderDto> Records { get; set; }
  }

}