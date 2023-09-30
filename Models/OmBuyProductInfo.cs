using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vending.Models;

[Table("OM_BUY_PRODUCT_INFO")]
public partial class OmBuyProductInfo
{
    /// <summary>
    /// PORD_INST_ID
    /// </summary>
    [Key]
    [Column("PORD_INST_ID")]
    public decimal PordInstId { get; set; }

    /// <summary>
    /// ORDER_ID
    /// </summary>
    [Column("ORDER_ID")]
    public decimal? OrderId { get; set; }

    /// <summary>
    /// GOODS_VER_ID
    /// </summary>
    [Column("GOODS_VER_ID")]
    public decimal GoodsVerId { get; set; }

    /// <summary>
    /// 商品状态
    /// </summary>
    [Column("GOODS_STATE")]
    public string? GoodsState { get; set; }

    /// <summary>
    /// 售卖数量
    /// </summary>
    [Column("NUMBERS")]
    public decimal? Numbers { get; set; }

    /// <summary>
    /// 出货数量
    /// </summary>
    [Column("ACT_NUM")]
    public decimal? ActNum { get; set; }

    /// <summary>
    /// 单价
    /// </summary>
    [Column("PRICE")]
    public decimal? Price { get; set; }

    /// <summary>
    /// 总金额:销售总额=总额的钱-退款的钱
    /// </summary>
    [Column("TOTAL_PRICE")]
    public decimal? TotalPrice { get; set; }

    /// <summary>
    /// 折扣价
    /// </summary>
    [Column("DISCOUNT")]
    public decimal? Discount { get; set; }

    /// <summary>
    /// 终端机ID
    /// </summary>
    [Column("DEVICE_ID")]
    public decimal DeviceId { get; set; }

    /// <summary>
    /// 货到编码
    /// </summary>
    [Column("CHN_CODE")]
    public string? ChnCode { get; set; }

    /// <summary>
    /// 出货状态 10F 已完成 10N 未出货
    /// </summary>
    [Column("OUT_STATE")]
    public string? OutState { get; set; }

    /// <summary>
    /// 支付状态:10I 待支付 10F 已支付 10T 待退款(暂无用) 10R 已退款
    /// </summary>
    [Column("PAY_STATE")]
    public string? PayState { get; set; }

    /// <summary>
    /// 终端机等待状态，是否需要提示前台人员等待，每次交互都要清空
    /// </summary>
    [Column("WAIT_STATE")]
    public string? WaitState { get; set; }

    [Column("TOTAL_COST")]
    public decimal? TotalCost { get; set; }

    [Column("UNIT_COST")]
    public decimal? UnitCost { get; set; }

    [Column("REFUND_MSG_ID")]
    public decimal? RefundMsgid { get; set; }

    [Column("REFUND_MSG")]
    public string? RefundMsg { get; set; }

    [Column("UUID")]
    public string? Uuid { get; set; }

    [Column("ERR_CODE")]
    public string? ErrCode { get; set; }

    [Column("TIME_USAGE")]
    public long? TimeUsage { get; set; }
}
