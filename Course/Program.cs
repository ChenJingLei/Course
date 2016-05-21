using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = "";
            CookieCollection c1 = Do_Http_Request("http://ems.sit.edu.cn:85/login.jsp",
                "loginName=1310400404&password=950414&authtype=2&loginYzm=&Login.Token1=&Login.Token2=", "", "POST",
                false);
            foreach (Cookie cookie in c1)
            {
                user += cookie.ToString() + "; ";
            }
            CookieCollection c2 = Do_Http_Request(" http://ems.sit.edu.cn:85/student/graduate/scorepoint.jsp",
                "op=list&srTerm=&srTerm2:2016%B4%BA",user, "POST",true);
            //Cookie: token = 1463748275421; jwc_share_cookie = 1310400404; JSESSIONID = d33w0 - olni1cvrDUnt; EMS_TOKEN = dIbnLCmjALR9C1i0pJoFCd % 2FBg9mdamGZ83CwM % 2FdWRhFCkcjJREEvUNskj1M3 % 2FkIQUr1jzDIF % 2F9Cv % 0AUGKSKL0AWg % 3D % 3D % 0A
            //            user.Add(c1.GetCookies());

            Console.ReadKey();
        }

        /// <summary>
        /// DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time"> DateTime时间格式</param>
        /// <returns>Unix时间戳格式</returns>
        public static int ConvertDateTimeInt(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }

        /// <summary>
        /// 登录网站并获取Cookies
        /// </summary>
        /// <returns>成功登录的Cookie信息</returns>
        public static CookieCollection Do_Http_Request(string url,string formData, string cookie,string method,bool isRedirect)
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
            string WebContent = new StreamReader(stream, System.Text.Encoding.Default).ReadToEnd();

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
    }
}
