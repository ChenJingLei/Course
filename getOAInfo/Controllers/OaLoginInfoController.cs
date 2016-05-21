using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Course.BLL;
using Course.Model;
using getOAInfo.Models;
using getOAInfo.Utility;

namespace getOAInfo.Controllers
{
    public class OaLoginInfoController : ApiController
    {
        public void SetOAInfo(int id)
        {
            //到数据库找到登陆信息
            OaLogininfoBLL oaLogininfoBll = new OaLogininfoBLL();
            OaLoginInfo loginInfos = oaLogininfoBll.GetModel(id);
        }

        public string PostMySQLInfo(string conString)
        {
            PubConstant.ConnectionString = conString;
            return PubConstant.ConnectionString;
        }

    }
}
