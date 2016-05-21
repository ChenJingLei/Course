using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace getOAInfo.Service
{
    public class HttpInfo
    {
        public string WebContext => _webContext;

        private string _webContext;

        public CookieCollection Do_Http_Request(string url, string formData, string cookie, string method, bool isRedirect)
        {
            CookieContainer cc = new CookieContainer();
            string FormURL = url;       //处理表单的绝对URL地址
            string FormData = formData;
            //            string FormData = "op=list&srTerm=2013%C7%EF&srTerm2:2016%B4%BA";   //表单需要提交的参数，注意改为你已注册的信息。
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] data = encoding.GetBytes(FormData);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(FormURL);
            request.Method = method;    //数据提交方式
            request.Accept = "text / html,application / xhtml + xml,application / xml; q = 0.9,*/*;q=0.8";
            request.KeepAlive = true;
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            request.UserAgent = "Mozilla / 5.0(Windows NT 10.0; WOW64; rv: 46.0) Gecko / 20100101 Firefox / 46.0";
            request.Headers["Cookie"] = "token=" + ConvertDateTimeInt(DateTime.Now) + "; " + cookie;

            //模拟一个UserAgent
            if (method == "POST")
            {
                Stream newStream = request.GetRequestStream();
                newStream.Write(data, 0, data.Length);

                newStream.Close();
            }

            request.CookieContainer = cc;

            request.AllowAutoRedirect = isRedirect;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();



            Stream stream = response.GetResponseStream();
            _webContext = new StreamReader(stream, System.Text.Encoding.Default).ReadToEnd();

            if (isRedirect)
            {
                Regex regex = new Regex("<td class=\"list\">?.*</td>");
                StringBuilder sbuilder = new StringBuilder();

                foreach (Match mch in Regex.Matches(WebContent, "<td class=\"list\">\\d\\.\\d</td>"))
                {

                    sbuilder.Append(mch.Value.Trim());

                }

                Console.WriteLine(sbuilder.ToString());

            }

            return response.Cookies;
        }


        private static int ConvertDateTimeInt(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }
    }
}