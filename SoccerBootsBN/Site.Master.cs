using Microsoft.AspNet.Identity;
using SoccerBootsBN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Source taken from https://www.youtube.com/watch?v=sXS2lX7XdOs
namespace SoccerBootsBN
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = Context.User.Identity;

            if (user.IsAuthenticated)
            {

                loginlink.Visible = false;
                registerlink.Visible = false;

                logoutlink.Visible = true;
                status.Visible = true;

                CartModel model = new CartModel();
                string userId = HttpContext.Current.User.Identity.GetUserId();
                status.Text = string.Format("{0} ({1})", Context.User.Identity.Name,
                    model.GetTotalOfOrders(userId));

            }
            else
            {
                loginlink.Visible = true;
                registerlink.Visible = true;

                logoutlink.Visible = false;
                status.Visible = false;
            }
        }

        protected void logoutlink_Click(object sender, EventArgs e)
        {
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();

            Response.Redirect("~/Default.aspx"); 
        }
    }
}