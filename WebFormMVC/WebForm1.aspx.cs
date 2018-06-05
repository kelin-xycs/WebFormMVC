using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormMVC
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected string userControl1;

        protected void Page_Load(object sender, EventArgs e)
        {
            //  权限验证
            Authority.Check();


            //  UI 逻辑

            Control uc1 = LoadControl("UserControl1.ascx");

            using(System.IO.StringWriter sw = new System.IO.StringWriter())
            {
                HtmlTextWriter htmlWriter = new HtmlTextWriter(sw);
                uc1.RenderControl(htmlWriter);
                
                this.userControl1 = sw.ToString();
            }
            
            
        }
    }
}