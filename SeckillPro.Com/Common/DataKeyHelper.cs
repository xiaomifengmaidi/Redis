using SeckillPro.Com.Model;
using SeckillPro.Com.Tool;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SeckillPro.Com.Common
{
    /// <summary>
    /// 主键编号Id Helper
    /// </summary>
    public class DataKeyHelper
    {
        private static DataKeyHelper _DataKeyHelper;
        private static object _locker_DataKeyHelper = new object();
        public static DataKeyHelper Current
        {
            get
            {
                if (_DataKeyHelper == null)
                {
                    lock (_locker_DataKeyHelper)
                    {
                        _DataKeyHelper = _DataKeyHelper ?? new DataKeyHelper();
                        return _DataKeyHelper;
                    }
                }

                return _DataKeyHelper;
            }
        }

        private StackRedis _redis = StackRedis.Current;

        /// <summary>
        /// 获取主键Id
        /// </summary>
        /// <param name="dataKey"></param>
        /// <returns></returns>
        public async Task<long> GetKeyId(EnumHelper.EmDataKey dataKey)
        {
            var keyId = 0L;
            var key = dataKey.ToString();
            var result = await _redis.Get(key);
            if (!string.IsNullOrWhiteSpace(result))
            {
                keyId = Convert.ToInt64(result);
            }
            keyId++;
            return await _redis.Set(key, keyId) ? keyId : 0;
        }
    }
}
