using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormMVC
{
    public partial class Controller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  权限验证

            Authority.Check();


            //  Controller 逻辑

            string action = Request["action"];
            string result;

            if (action == "Action1")
            {
                result = Action1();
            }
            else if (action == "Action2")
            {
                result = Action2();
            }
            else
            {
                result = "不存在的 action ：\"" + action + "\" 。";
            }
            
            Response.Write(result);
            Response.End();
        }

        private string Action1()
        {
            //  权限验证
            Authority.Check();

            //  Action 逻辑
            return "Action1";
        }

        private string Action2()
        {
            //  权限验证
            Authority.Check();

            //  Action 逻辑
            return "Action2";
        }

    }
}