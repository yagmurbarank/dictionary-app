﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sozluk
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userinfo"] != null)
                {
                    // getUserInfo();
                    lblAdSoyad.Text = Session["userinfo"].ToString();
                }
                else
                {
                    Response.Redirect("~/login.aspx");
                }

            }
        }
    }
}