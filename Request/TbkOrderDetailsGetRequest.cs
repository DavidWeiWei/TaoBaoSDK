using System;
using System.Collections.Generic;
using System.Text;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// 淘宝客-推广者-所有订单查询
    /// </summary>
    public class TbkOrderDetailsGetRequest : BaseTopRequest<Top.Api.Response.TbkOrderDetailsGetResponse>
    {
        /// <summary>
        /// 查询时间类型，1：按照订单淘客创建时间查询，2:按照订单淘客付款时间查询，3:按照订单淘客结算时间查询
        /// </summary>
        public long? QueryType { get; set; }

        /// <summary>
        /// 位点，除第一页之外，都需要传递；前端原样返回。
        /// </summary>
        public string PositionIndex { get; set; }

        /// <summary>
        /// 页大小，默认20，1~100
        /// </summary>
        public long PageSize { get; set; }

        /// <summary>
        /// 推广者角色类型,2:二方，3:三方，不传，表示所有角色
        /// </summary>
        public Nullable<long> MemberType { get; set; }

        /// <summary>
        /// 淘客订单状态，12-付款，13-关闭，14-确认收货，3-结算成功;不传，表示所有状态
        /// </summary>
        public long? TkStatus { get; set; }

        /// <summary>
        /// 订单查询开始时间
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 订单查询结束时间，订单开始时间至订单结束时间，中间时间段日常要求不超过3个小时，但如618、双11、年货节等大促期间预估时间段不可超过20分钟，超过会提示错误，调用时请务必注意时间段的选择，以保证亲能正常调用！
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 跳转类型，当向前或者向后翻页必须提供,-1: 向前翻页,1：向后翻页
        /// </summary>
        public long JumpType { get; set; }

        /// <summary>
        /// 第几页，默认1，1~100
        /// </summary>
        public long PageNo { get; set; }

        /// <summary>
        /// 场景订单场景类型，1:常规订单，2:渠道订单，3:会员运营订单，默认为1
        /// </summary>
        public long OrderScene { get; set; }

        #region ITopRequest Members
        public override string GetApiName()
        {
            return "taobao.tbk.order.details.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("query_type", this.QueryType);
            parameters.Add("position_index", this.PositionIndex);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("member_type", this.MemberType);
            parameters.Add("tk_status", this.TkStatus);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("jump_type", this.JumpType);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("order_scene", this.OrderScene);

            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("start_time", this.StartTime);
            RequestValidator.ValidateRequired("end_time", this.EndTime);
        }
        #endregion
    }
}
