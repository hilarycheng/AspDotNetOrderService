using Microsoft.EntityFrameworkCore;
using Vending.Models;

namespace Vending.Data
{

  public class VendingContext : DbContext
  {
    public VendingContext(DbContextOptions<VendingContext> options) : base(options)
    {
    }
    public required DbSet<OmOrder> OmOrders { get; set; }
    public required DbSet<OmBuyProductInfo> OmBuyProductInfos { get; set; }
    public required DbSet<OmPayInfo> OmPayInfos { get; set; }

  }


}