using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace WebFormMVC
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //  权限验证
            Authority.Check();


            //  UI 逻辑

            gridView.DataSource = FetchPerson();
            gridView.DataBind();
            
        }

        private DataTable FetchPerson()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("age");

            DataRow dr = dt.NewRow();
            dr["id"] = "001";
            dr["name"] = "小刚";
            dr["age"] = 10;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["id"] = "002";
            dr["name"] = "小明";
            dr["age"] = 20;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["id"] = "003";
            dr["name"] = "小红";
            dr["age"] = 30;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["id"] = "004";
            dr["name"] = "小花";
            dr["age"] = 40;
            dt.Rows.Add(dr);

            return dt;
        }
    }
}