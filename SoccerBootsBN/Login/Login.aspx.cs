using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoccerBootsBN.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();

            userStore.Context.Database.Connection.ConnectionString =
                System.Configuration.ConfigurationManager.
                ConnectionStrings["db_1525596_co5027ConnectionString"].ConnectionString;

            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

            var user = manager.Find(UserNameText.Text, PasswordText.Text);

            if (user != null)
            {
                //using owin function
                var authenticatinManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                //sign in
                authenticatinManager.SignIn(new AuthenticationProperties
                {
                    IsPersistent = false
                }, userIdentity);

                //go to homepage
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                Status.Text = "Incorrect Username or Password";
            }
        }
    }
}