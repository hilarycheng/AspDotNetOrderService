using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vending.Models;

[Table("OM_ORDER")]
public partial class OmOrder
{
    /// <summary>
    /// ORDER_ID
    /// </summary>
    [Key]
    [Column("ORDER_ID")]
    public decimal OrderId { get; set; }

    /// <summary>
    /// 父订单标识
    /// </summary>
    [Column("PARENT_ID")]
    public decimal? ParentId { get; set; }

    /// <summary>
    /// 客户ID
    /// </summary>
    [Column("USER_ID")]
    public decimal? UserId { get; set; }

    [Column("ORDER_CODE")]
    public string? OrderCode { get; set; }

    /// <summary>
    /// 订单状态
    /// </summary>
    [Column("ORDER_STATE")]
    public string? OrderState { get; set; }

    [Column("STATE_TIME")]
    public DateTime? StateTime { get; set; }

    [Column("CREATE_TIME")]
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 微信openId
    /// </summary>
    [Column("WX_OPEN_ID")]
    public string? WxOpenId { get; set; }

    /// <summary>
    /// 订单类型
    /// </summary>
    [Column("ORDER_TYPE")]
    public string? OrderType { get; set; }

    /// <summary>
    /// 失效时间
    /// </summary>
    [Column("INVALID_TIME")]
    public DateTime? InvalidTime { get; set; }

    /// <summary>
    /// 客户留言
    /// </summary>
    [Column("CUST_MSG")]
    public string? CustMsg { get; set; }

    [Column("DEAL_TOTAL")]
    public decimal? DealTotal { get; set; }

    [Column("TM_P_ID")]
    public decimal? TmPId { get; set; }

    [Column("POINT_CODE")]
    public decimal? PointCode { get; set; }
}
