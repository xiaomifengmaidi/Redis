using System;
using System.Collections.Generic;
using System.Text;

namespace SeckillPro.Com.Model.ApiModel
{
    #region 请求基类
    public class MoRq
    {
        public MoMemberRq MemberRq { get; set; }
    }
    /// <summary>
    /// 会员请求基本信息
    /// </summary>
    public class MoMemberRq
    {
        /// <summary>
        /// 用户身份Token
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// 用户请求Ip
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 请求端id  EnumHelper.EmRqSource
        /// </summary>
        public int RqSource { get; set; }
        //设备号
    }
    #endregion

    #region 响应基类
    public class MoRp
    {
        /// <summary>
        /// 接口响应状态  0：失败 1：成功
        /// </summary>
        public int RpStatus { get; set; }
        /// <summary>
        /// 消息信息
        /// </summary>
        public string RpMsg { get; set; }
    }
    #endregion
}
