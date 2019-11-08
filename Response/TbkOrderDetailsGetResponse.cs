using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    public class TbkOrderDetailsGetResponse : TopResponse
    {
        [XmlElement("data")]
        public OrderPage Data { get; set; }
    }

    [Serializable]
    public class OrderPage : TopObject {
        [XmlArray("results")]
        [XmlArrayItem("publisher_order_dto")]
        public List<PublisherOrderDto> Results { get; set; }

        [XmlElement("has_pre")]
        public bool HasPre { get; set; }

        [XmlElement("position_index")]
        public string PositionIndex { get; set; }

        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        [XmlElement("page_no")]
        public long PageNo { get; set; }

        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }

    [Serializable]
    public  class PublisherOrderDto : TopObject
    {
        /// <summary>
        /// 订单在淘宝拍下付款的时间
        /// </summary>
        [XmlElement("tb_paid_time")]
        public string TbPaidTime { get; set; }


        /// <summary>
        /// 订单付款的时间，该时间同步淘宝，可能会略晚于买家在淘宝的订单创建时间
        /// </summary>
        [XmlElement("tk_paid_time")]
        public string TkPaidTime { get; set; }


        /// <summary>
        /// 买家确认收货的付款金额（不包含运费金额）
        /// </summary>
        [XmlElement("pay_price")]
        public string PayPrice { get; set; }


        /// <summary>
        /// 结算预估收入=结算金额*提成。以买家确认收货的付款金额为基数，预估您可能获得的收入。因买家退款、您违规推广等原因，可能与您最终收入不一致。最终收入以月结后您实际收到的为准
        /// </summary>
        [XmlElement("pub_share_fee")]
        public string PubShareFee { get; set; }


        /// <summary>
        /// 买家通过购物车购买的每个商品对应的订单编号，此订单编号并未在淘宝买家后台透出
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }


        /// <summary>
        /// 二方：佣金收益的第一归属者； 三方：从其他淘宝客佣金中进行分成的推广者
        /// </summary>
        [XmlElement("tk_order_role")]
        public long TkOrderRole { get; set; }


        /// <summary>
        /// 订单确认收货后且商家完成佣金支付的时间
        /// </summary>
        [XmlElement("tk_earning_time")]
        public string TkEarningTime { get; set; }


        /// <summary>
        /// 推广位管理下的推广位名称对应的ID，同时也是pid=mm_1_2_3中的“3”这段数字
        /// </summary>
        [XmlElement("adzone_id")]
        public long AdzoneId { get; set; }


        /// <summary>
        /// 从结算佣金中分得的收益比率
        /// </summary>
        [XmlElement("pub_share_rate")]
        public string PubShareRate { get; set; }


        /// <summary>
        /// unid
        /// </summary>
        [XmlElement("unid")]
        public long Unid { get; set; }


        /// <summary>
        /// 维权标签，0 含义为非维权 1 含义为维权订单
        /// </summary>
        [XmlElement("refund_tag")]
        public long RefundTag { get; set; }


        /// <summary>
        /// 平台给与的补贴比率，如天猫、淘宝、聚划算等
        /// </summary>
        [XmlElement("subsidy_rate")]
        public string SubsidyRate { get; set; }


        /// <summary>
        /// 提成=收入比率*分成比率。指实际获得收益的比率
        /// </summary>
        [XmlElement("tk_total_rate")]
        public string TkTotalRate { get; set; }


        /// <summary>
        /// 商品所属的根类目，即一级类目的名称
        /// </summary>
        [XmlElement("item_category_name")]
        public string ItemCategoryName { get; set; }


        /// <summary>
        /// 掌柜旺旺
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }


        /// <summary>
        /// 推广者的会员id
        /// </summary>
        [XmlElement("pub_id")]
        public long PubId { get; set; }


        /// <summary>
        /// 推广者赚取佣金后支付给阿里妈妈的技术服务费用的比率
        /// </summary>
        [XmlElement("alimama_rate")]
        public string AlimamaRate { get; set; }


        /// <summary>
        /// 平台出资方，如天猫、淘宝、或聚划算等
        /// </summary>
        [XmlElement("subsidy_type")]
        public string SubsidyType { get; set; }


        /// <summary>
        /// 商品图片
        /// </summary>
        [XmlElement("item_img")]
        public string ItemImg { get; set; }


        /// <summary>
        /// 付款预估收入=付款金额*提成。指买家付款金额为基数，预估您可能获得的收入。因买家退款等原因，可能与结算预估收入不一致
        /// </summary>
        [XmlElement("pub_share_pre_fee")]
        public string PubSharePreFee { get; set; }


        /// <summary>
        /// 买家拍下付款的金额（不包含运费金额）
        /// </summary>
        [XmlElement("alipay_total_price")]
        public string AlipayTotalPrice { get; set; }


        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }


        /// <summary>
        /// 媒体管理下的对应ID的自定义名称
        /// </summary>
        [XmlElement("site_name")]
        public string SiteName { get; set; }


        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_num")]
        public long ItemNum { get; set; }


        /// <summary>
        /// 补贴金额=结算金额*补贴比率
        /// </summary>
        [XmlElement("subsidy_fee")]
        public string SubsidyFee { get; set; }


        /// <summary>
        /// 技术服务费=结算金额*收入比率*技术服务费率。推广者赚取佣金后支付给阿里妈妈的技术服务费用
        /// </summary>
        [XmlElement("alimama_share_fee")]
        public string AlimamaShareFee { get; set; }


        /// <summary>
        /// 买家在淘宝后台显示的订单编号
        /// </summary>
        [XmlElement("trade_parent_id")]
        public string TradeParentId { get; set; }


        /// <summary>
        /// 订单所属平台类型，包括天猫、淘宝、聚划算等
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }


        /// <summary>
        /// 订单创建的时间，该时间同步淘宝，可能会略晚于买家在淘宝的订单创建时间
        /// </summary>
        [XmlElement("tk_create_time")]
        public string TkCreateTime { get; set; }


        /// <summary>
        /// 产品类型
        /// </summary>
        [XmlElement("flow_source")]
        public string FlowSource { get; set; }


        /// <summary>
        /// 成交平台
        /// </summary>
        [XmlElement("terminal_type")]
        public string TerminalType { get; set; }


        /// <summary>
        /// 通过推广链接达到商品、店铺详情页的点击时间
        /// </summary>
        [XmlElement("click_time")]
        public string ClickTime { get; set; }


        /// <summary>
        /// 已付款：指订单已付款，但还未确认收货 已收货：指订单已确认收货，但商家佣金未支付 已结算：指订单已确认收货，且商家佣金已支付成功已失效：指订单关闭/订单佣金小于0.01元，订单关闭主要有：1）买家超时未付款； 2）买家付款前，买家/卖家取消了订单；3）订单付款后发起售中退款成功；3：订单结算，12：订单付款，13：订单失效，14：订单成功
        /// </summary>
        [XmlElement("tk_status")]
        public long TkStatus { get; set; }


        /// <summary>
        /// 商品单价
        /// </summary>
        [XmlElement("item_price")]
        public string ItemPrice { get; set; }


        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }


        /// <summary>
        /// 推广位管理下的自定义推广位名称
        /// </summary>
        [XmlElement("adzone_name")]
        public string AdzoneName { get; set; }


        /// <summary>
        /// 佣金比率
        /// </summary>
        [XmlElement("total_commission_rate")]
        public string TotalCommissionRate { get; set; }


        /// <summary>
        /// 商品链接
        /// </summary>
        [XmlElement("item_link")]
        public string ItemLink { get; set; }


        /// <summary>
        /// 媒体管理下的ID，同时也是pid=mm_1_2_3中的“2”这段数字
        /// </summary>
        [XmlElement("site_id")]
        public long SiteId { get; set; }


        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("seller_shop_title")]
        public string SellerShopTitle { get; set; }


        /// <summary>
        /// 订单结算的佣金比率+平台的补贴比率
        /// </summary>
        [XmlElement("income_rate")]
        public string IncomeRate { get; set; }


        /// <summary>
        /// 佣金金额=结算金额*佣金比率
        /// </summary>
        [XmlElement("total_commission_fee")]
        public string TotalCommissionFee { get; set; }


        /// <summary>
        /// 预估专项服务费：内容场景专项技术服务费，内容推广者在内容场景进行推广需要支付给阿里妈妈专项的技术服务费用。专项服务费＝付款金额＊专项服务费率。
        /// </summary>
        [XmlElement("tk_commission_pre_fee_for_media_platform")]
        public string TkCommissionPreFeeForMediaPlatform { get; set; }


        /// <summary>
        /// 结算专项服务费：内容场景专项技术服务费，内容推广者在内容场景进行推广需要支付给阿里妈妈专项的技术服务费用。专项服务费＝结算金额＊专项服务费率。
        /// </summary>
        [XmlElement("tk_commission_fee_for_media_platform")]
        public string TkCommissionFeeForMediaPlatform { get; set; }


        /// <summary>
        /// 专项服务费率：内容场景专项技术服务费率，内容推广者在内容场景进行推广需要按结算金额支付一定比例给阿里妈妈作为内容场景专项技术服务费，用于提供与内容平台实现产品技术对接等服务。
        /// </summary>
        [XmlElement("tk_commission_rate_for_media_platform")]
        public string TkCommissionRateForMediaPlatform { get; set; }


        /// <summary>
        /// 会员运营id
        /// </summary>
        [XmlElement("special_id")]
        public long SpecialId { get; set; }


        /// <summary>
        /// 渠道关系id
        /// </summary>
        [XmlElement("relation_id")]
        public long RelationId { get; set; }


        /// <summary>
        /// 预售时期，用户对预售商品支付的定金金额
        /// </summary>
        [XmlElement("deposit_price")]
        public string DepositPrice { get; set; }


        /// <summary>
        /// 预售时期，用户对预售商品支付定金的付款时间
        /// </summary>
        [XmlElement("tb_deposit_time")]
        public string TbDepositTime { get; set; }


        /// <summary>
        /// 预售时期，用户对预售商品支付定金的付款时间，可能略晚于在淘宝付定金时间
        /// </summary>
        [XmlElement("tk_deposit_time")]
        public string TkDepositTime { get; set; }
    }
}
