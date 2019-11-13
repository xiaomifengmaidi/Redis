using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SeckillPro.Com.Tool
{
    public class HttpTool
    {
        /// <summary>
        /// 异步post请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static async Task<string> HttpPostAsync(string url, HttpContent content, int timeOut = 30)
        {
            var strRp = string.Empty;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    client.Timeout = TimeSpan.FromSeconds(timeOut);
                    var result = await client.PostAsync(url, content);
                    if (!result.IsSuccessStatusCode) { return strRp; }

                    strRp = await result.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                strRp = ex.Message;
            }
            return strRp;
        }

    }
}
