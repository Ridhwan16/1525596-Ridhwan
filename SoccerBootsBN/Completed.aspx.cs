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
    public partial class Completed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<BootCart> carts = (List<BootCart>)Session[User.Identity.GetUserId()];

            CartModel model = new CartModel();
            model.MarkBootsAsPaid(carts);

            Session[User.Identity.GetUserId()] = null;
        }
    }
}