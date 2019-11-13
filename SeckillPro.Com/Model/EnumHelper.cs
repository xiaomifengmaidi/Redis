using System;
using System.Collections.Generic;
using System.Text;

namespace SeckillPro.Com.Model
{
    public class EnumHelper
    {
        public enum EmDataKey
        {
            /// <summary>
            /// 订单主键key
            /// </summary>
            OrderId,
            /// <summary>
            /// 商品Id key
            /// </summary>
            ShoppingId,
            /// <summary>
            /// 用户Id key
            /// </summary>
            UserId,


            /// <summary>
            /// 商品列表
            /// </summary>
            ShoppingHash,
            /// <summary>
            /// 登录sessionkey
            /// </summary>
            SessionKey,
            /// <summary>
            /// 所有订单列表
            /// </summary>
            AllOrderList,
            /// <summary>
            /// 抢购订单队列
            /// </summary>
            QiangOrderEqueue
        }

        /// <summary>
        /// 请求端来源
        /// </summary>
        public enum EmRqSource
        {
            Web = 1,
            Android = 2,
            IOS = 3,
            WebApp = 4
        }

        /// <summary>
        /// 订单状态枚举
        /// </summary>
        public enum EmOrderStatus
        {
            排队抢购中 = 1000,
            抢购成功 = 2000,
            抢购失败 = 2001
        }
    }
}
