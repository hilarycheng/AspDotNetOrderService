using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vending.Models;

[Table("OM_PAY_INFO")]
public partial class OmPayInfo
{
    [Key]
    [Column("PAY_ID")]
    public decimal PayId { get; set; }

    [Column("ORDER_ID")]
    public decimal? OrderId { get; set; }

    [Column("MONEY")]
    public decimal? Money { get; set; }

    [Column("PAY_WAY")]
    public string? PayWay { get; set; }

    [Column("RELA_BANK")]
    public string? RelaBank { get; set; }

    /// <summary>
    /// 资金交易流水
    /// </summary>
    [Column("TRADE_ORDER_CODE")]
    public string? TradeOrderCode { get; set; }

    [Column("AGIO_TYPE")]
    public string? AgioType { get; set; }

    [Column("AGIO_ID")]
    public decimal? AgioId { get; set; }

    [Column("AGIO_INST_ID")]
    public decimal? AgioInstId { get; set; }

    [Column("STATE")]
    public string? State { get; set; }

    [Column("STATE_TIME")]
    public DateTime? StateTime { get; set; }

    /// <summary>
    /// ACC 收款 ; RET退款
    /// </summary>
    [Column("PAY_DIR")]
    public string? PayDir { get; set; }

    [Column("PORD_INST_ID")]
    public decimal? PordInstId { get; set; }

    [Column("HAS_PREFIX")]
    public string? HasPrefix { get; set; }

    public virtual ICollection<OmPayCurrency> OmPayCurrencies { get; set; } = new List<OmPayCurrency>();
}
