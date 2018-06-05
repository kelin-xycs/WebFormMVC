using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormMVC
{
    //  权限验证类
    public class Authority
    {
        public static void Check()
        {

            //  这里写 权限验证 的 代码

            bool isAuthorized = true;


            HttpResponse response = HttpContext.Current.Response;

            if (!isAuthorized)
            {
                response.Write("没有权限。");
                response.End();
            }

        }
    }
}