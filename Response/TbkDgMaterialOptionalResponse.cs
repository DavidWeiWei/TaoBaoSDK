using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TbkDgMaterialOptionalResponse.
    /// </summary>
    public class TbkDgMaterialOptionalResponse : TopResponse
    {
        /// <summary>
        /// resultList
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("map_data")]
        public List<MapDataDomain> ResultList { get; set; }

        /// <summary>
        /// 搜索到符合条件的结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }

	/// <summary>
/// MapDataDomain Data Structure.
/// </summary>
[Serializable]

public class MapDataDomain : TopObject
{
	        /// <summary>
	        /// 商品信息-叶子类目id
	        /// </summary>
	        [XmlElement("category_id")]
	        public long CategoryId { get; set; }
	
	        /// <summary>
	        /// 商品信息-叶子类目名称
	        /// </summary>
	        [XmlElement("category_name")]
	        public string CategoryName { get; set; }
	
	        /// <summary>
	        /// 商品信息-佣金比率。1550表示15.5%
	        /// </summary>
	        [XmlElement("commission_rate")]
	        public string CommissionRate { get; set; }
	
	        /// <summary>
	        /// 商品信息-佣金类型。MKT表示营销计划，SP表示定向计划，COMMON表示通用计划
	        /// </summary>
	        [XmlElement("commission_type")]
	        public string CommissionType { get; set; }
	
	        /// <summary>
	        /// 优惠券（元） 若属于预售商品，该优惠券付尾款可用，付定金不可用
	        /// </summary>
	        [XmlElement("coupon_amount")]
	        public string CouponAmount { get; set; }
	
	        /// <summary>
	        /// 优惠券信息-优惠券结束时间
	        /// </summary>
	        [XmlElement("coupon_end_time")]
	        public string CouponEndTime { get; set; }
	
	        /// <summary>
	        /// 优惠券信息-优惠券id
	        /// </summary>
	        [XmlElement("coupon_id")]
	        public string CouponId { get; set; }
	
	        /// <summary>
	        /// 优惠券信息-优惠券满减信息
	        /// </summary>
	        [XmlElement("coupon_info")]
	        public string CouponInfo { get; set; }
	
	        /// <summary>
	        /// 优惠券信息-优惠券剩余量
	        /// </summary>
	        [XmlElement("coupon_remain_count")]
	        public long CouponRemainCount { get; set; }
	
	        /// <summary>
	        /// 链接-宝贝+券二合一页面链接
	        /// </summary>
	        [XmlElement("coupon_share_url")]
	        public string CouponShareUrl { get; set; }
	
	        /// <summary>
	        /// 优惠券信息-优惠券起用门槛，满X元可用。如：满299元减20元
	        /// </summary>
	        [XmlElement("coupon_start_fee")]
	        public string CouponStartFee { get; set; }
	
	        /// <summary>
	        /// 优惠券信息-优惠券开始时间
	        /// </summary>
	        [XmlElement("coupon_start_time")]
	        public string CouponStartTime { get; set; }
	
	        /// <summary>
	        /// 优惠券信息-优惠券总量
	        /// </summary>
	        [XmlElement("coupon_total_count")]
	        public long CouponTotalCount { get; set; }
	
	        /// <summary>
	        /// 商品信息-是否包含定向计划
	        /// </summary>
	        [XmlElement("include_dxjh")]
	        public string IncludeDxjh { get; set; }
	
	        /// <summary>
	        /// 商品信息-是否包含营销计划
	        /// </summary>
	        [XmlElement("include_mkt")]
	        public string IncludeMkt { get; set; }
	
	        /// <summary>
	        /// 商品信息-定向计划信息
	        /// </summary>
	        [XmlElement("info_dxjh")]
	        public string InfoDxjh { get; set; }
	
	        /// <summary>
	        /// 商品信息-宝贝描述(推荐理由)
	        /// </summary>
	        [XmlElement("item_description")]
	        public string ItemDescription { get; set; }
	
	        /// <summary>
	        /// 商品信息-宝贝id
	        /// </summary>
	        [XmlElement("item_id")]
	        public long ItemId { get; set; }
	
	        /// <summary>
	        /// 链接-宝贝地址
	        /// </summary>
	        [XmlElement("item_url")]
	        public string ItemUrl { get; set; }
	
	        /// <summary>
	        /// 拼团专用-拼团几人团
	        /// </summary>
	        [XmlElement("jdd_num")]
	        public long JddNum { get; set; }
	
	        /// <summary>
	        /// 拼团专用-拼团拼成价，单位元
	        /// </summary>
	        [XmlElement("jdd_price")]
	        public string JddPrice { get; set; }
	
	        /// <summary>
	        /// 商品信息-一级类目ID
	        /// </summary>
	        [XmlElement("level_one_category_id")]
	        public long LevelOneCategoryId { get; set; }
	
	        /// <summary>
	        /// 商品信息-一级类目名称
	        /// </summary>
	        [XmlElement("level_one_category_name")]
	        public string LevelOneCategoryName { get; set; }
	
	        /// <summary>
	        /// 锁住的佣金率
	        /// </summary>
	        [XmlElement("lock_rate")]
	        public string LockRate { get; set; }
	
	        /// <summary>
	        /// 锁佣结束时间
	        /// </summary>
	        [XmlElement("lock_rate_end_time")]
	        public long LockRateEndTime { get; set; }
	
	        /// <summary>
	        /// 锁佣开始时间
	        /// </summary>
	        [XmlElement("lock_rate_start_time")]
	        public long LockRateStartTime { get; set; }
	
	        /// <summary>
	        /// 店铺信息-卖家昵称
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 商品信息-宝贝id(该字段废弃，请勿再用)
	        /// </summary>
	        [XmlElement("num_iid")]
	        public long NumIid { get; set; }
	
	        /// <summary>
	        /// 拼团专用-拼团结束时间
	        /// </summary>
	        [XmlElement("oetime")]
	        public string Oetime { get; set; }
	
	        /// <summary>
	        /// 拼团专用-拼团一人价（原价)，单位元
	        /// </summary>
	        [XmlElement("orig_price")]
	        public string OrigPrice { get; set; }
	
	        /// <summary>
	        /// 拼团专用-拼团开始时间
	        /// </summary>
	        [XmlElement("ostime")]
	        public string Ostime { get; set; }
	
	        /// <summary>
	        /// 商品信息-商品主图
	        /// </summary>
	        [XmlElement("pict_url")]
	        public string PictUrl { get; set; }
	
	        /// <summary>
	        /// 预售商品-定金（元）
	        /// </summary>
	        [XmlElement("presale_deposit")]
	        public string PresaleDeposit { get; set; }
	
	        /// <summary>
	        /// 预售商品-优惠
	        /// </summary>
	        [XmlElement("presale_discount_fee_text")]
	        public string PresaleDiscountFeeText { get; set; }
	
	        /// <summary>
	        /// 预售商品-付定金结束时间（毫秒）
	        /// </summary>
	        [XmlElement("presale_end_time")]
	        public long PresaleEndTime { get; set; }
	
	        /// <summary>
	        /// 预售商品-付定金开始时间（毫秒）
	        /// </summary>
	        [XmlElement("presale_start_time")]
	        public long PresaleStartTime { get; set; }
	
	        /// <summary>
	        /// 预售商品-付尾款结束时间（毫秒）
	        /// </summary>
	        [XmlElement("presale_tail_end_time")]
	        public long PresaleTailEndTime { get; set; }
	
	        /// <summary>
	        /// 预售商品-付尾款开始时间（毫秒）
	        /// </summary>
	        [XmlElement("presale_tail_start_time")]
	        public long PresaleTailStartTime { get; set; }
	
	        /// <summary>
	        /// 商品信息-宝贝所在地
	        /// </summary>
	        [XmlElement("provcity")]
	        public string Provcity { get; set; }
	
	        /// <summary>
	        /// 商品邮费
	        /// </summary>
	        [XmlElement("real_post_fee")]
	        public string RealPostFee { get; set; }
	
	        /// <summary>
	        /// 商品信息-商品一口价格
	        /// </summary>
	        [XmlElement("reserve_price")]
	        public string ReservePrice { get; set; }
	
	        /// <summary>
	        /// 拼团专用-拼团已售数量
	        /// </summary>
	        [XmlElement("sell_num")]
	        public long SellNum { get; set; }
	
	        /// <summary>
	        /// 店铺信息-卖家id
	        /// </summary>
	        [XmlElement("seller_id")]
	        public long SellerId { get; set; }
	
	        /// <summary>
	        /// 店铺信息-店铺dsr评分
	        /// </summary>
	        [XmlElement("shop_dsr")]
	        public long ShopDsr { get; set; }
	
	        /// <summary>
	        /// 店铺信息-店铺名称
	        /// </summary>
	        [XmlElement("shop_title")]
	        public string ShopTitle { get; set; }
	
	        /// <summary>
	        /// 商品信息-商品短标题
	        /// </summary>
	        [XmlElement("short_title")]
	        public string ShortTitle { get; set; }
	
	        /// <summary>
	        /// 商品信息-商品小图列表
	        /// </summary>
	        [XmlArray("small_images")]
	        [XmlArrayItem("string")]
	        public List<string> SmallImages { get; set; }
	
	        /// <summary>
	        /// 拼团专用-拼团剩余库存
	        /// </summary>
	        [XmlElement("stock")]
	        public long Stock { get; set; }
	
	        /// <summary>
	        /// 商品信息-商品标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 商品信息-月支出佣金(该字段废弃，请勿再用)
	        /// </summary>
	        [XmlElement("tk_total_commi")]
	        public string TkTotalCommi { get; set; }
	
	        /// <summary>
	        /// 商品信息-淘客30天推广量
	        /// </summary>
	        [XmlElement("tk_total_sales")]
	        public string TkTotalSales { get; set; }
	
	        /// <summary>
	        /// 营销-天猫营销玩法
	        /// </summary>
	        [XmlElement("tmall_play_activity_info")]
	        public string TmallPlayActivityInfo { get; set; }
	
	        /// <summary>
	        /// 拼团专用-拼团库存数量
	        /// </summary>
	        [XmlElement("total_stock")]
	        public long TotalStock { get; set; }
	
	        /// <summary>
	        /// 链接-宝贝推广链接
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
	
	        /// <summary>
	        /// 店铺信息-卖家类型。0表示集市，1表示天猫
	        /// </summary>
	        [XmlElement("user_type")]
	        public long UserType { get; set; }
	
	        /// <summary>
	        /// 预售专用-预售数量
	        /// </summary>
	        [XmlElement("uv_sum_pre_sale")]
	        public long UvSumPreSale { get; set; }
	
	        /// <summary>
	        /// 商品信息-30天销量
	        /// </summary>
	        [XmlElement("volume")]
	        public long Volume { get; set; }
	
	        /// <summary>
	        /// 商品信息-商品白底图
	        /// </summary>
	        [XmlElement("white_image")]
	        public string WhiteImage { get; set; }
	
	        /// <summary>
	        /// 链接-物料块id(测试中请勿使用)
	        /// </summary>
	        [XmlElement("x_id")]
	        public string XId { get; set; }
	
	        /// <summary>
	        /// 预售有礼-推广链接
	        /// </summary>
	        [XmlElement("ysyl_click_url")]
	        public string YsylClickUrl { get; set; }
	
	        /// <summary>
	        /// 预售有礼-佣金比例（ 预售有礼活动享受的推广佣金比例，注：推广该活动有特殊分成规则，请详见：https://tbk.bbs.taobao.com/detail.html?appId=45301&postId=9334376 ）
	        /// </summary>
	        [XmlElement("ysyl_commission_rate")]
	        public string YsylCommissionRate { get; set; }
	
	        /// <summary>
	        /// 预售有礼-预估淘礼金（元）
	        /// </summary>
	        [XmlElement("ysyl_tlj_face")]
	        public string YsylTljFace { get; set; }
	
	        /// <summary>
	        /// 预售有礼-淘礼金发放时间
	        /// </summary>
	        [XmlElement("ysyl_tlj_send_time")]
	        public string YsylTljSendTime { get; set; }
	
	        /// <summary>
	        /// 预售有礼-淘礼金使用结束时间
	        /// </summary>
	        [XmlElement("ysyl_tlj_use_end_time")]
	        public string YsylTljUseEndTime { get; set; }
	
	        /// <summary>
	        /// 预售有礼-淘礼金使用开始时间
	        /// </summary>
	        [XmlElement("ysyl_tlj_use_start_time")]
	        public string YsylTljUseStartTime { get; set; }
	
	        /// <summary>
	        /// 折扣价（元） 若属于预售商品，付定金时间内，折扣价=预售价
	        /// </summary>
	        [XmlElement("zk_final_price")]
	        public string ZkFinalPrice { get; set; }
}

    }
}
