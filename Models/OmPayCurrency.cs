using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vending.Models;

[Table("OM_PAY_CURRENCY")]
public partial class OmPayCurrency
{
    [Key]
    [Column("OP_C_ID")]
    public decimal OpCId { get; set; }

    [Column("PAY_ID")]
    public decimal? PayId { get; set; }

    [Column("CURRENCY")]
    public string? Currency { get; set; }

    [Column("PRICE")]
    public decimal? Price { get; set; }

    [Column("CURRENCY_TYPE")]
    public string? CurrencyType { get; set; }

    [Column("CUR_NUM")]
    public int? CurNum { get; set; }

    public virtual OmPayInfo? Pay { get; set; }
}
