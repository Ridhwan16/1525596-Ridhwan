using System;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity.EntityFramework;
using SoccerBootsBN.Models;
using Microsoft.Owin.Security;
//Source taken from https://www.youtube.com/watch?v=sXS2lX7XdOs

namespace SoccerBootsBN.Login
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();

            userStore.Context.Database.Connection.ConnectionString =
                System.Configuration.ConfigurationManager.
                ConnectionStrings["db_1525596_co5027ConnectionString"].ConnectionString;

            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

            //Make a new user and store in database
            IdentityUser user = new IdentityUser();
            user.UserName = UserNameText.Text;

            if (PasswordText.Text == ConfirmPasswordText.Text)
            {
                try
                {
                    IdentityResult answer = manager.Create(user, PasswordText.Text);
                    if(answer.Succeeded)
                    {
                        CustomerInfo info = new CustomerInfo
                        {
                            Address = AddressText.Text,
                            FirstName = FirstNameText.Text,
                            LastName = LastNameText.Text,
                            PostCode = Convert.ToInt32(PostCodeText.Text),
                            GUID = user.Id
                        };

                        CustomerInfoClass model = new CustomerInfoClass();
                        model.InsertCustomerInformation(info);


                        //keep it in database
                        var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

                        //set the user to make it available for login
                        var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                        //login the user and sent it to homepage
                        authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                        Response.Redirect("~/Default.aspx");
                    }
                    else
                    {
                        Status.Text = answer.Errors.FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {
                    Status.Text = ex.ToString();
                }

            }
            else
            {
                Status.Text = "Password Does Not Match";
            }

        }
    }
}