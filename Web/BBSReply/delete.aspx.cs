﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BBS.Web.BBSReply
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				BBS.BLL.BBSReply bll=new BBS.BLL.BBSReply();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int RID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(RID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}