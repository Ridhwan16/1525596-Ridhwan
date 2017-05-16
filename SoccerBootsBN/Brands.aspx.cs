using Microsoft.AspNet.Identity;
using SoccerBootsBN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoccerBootsBN
{
    public partial class Brands : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            insertPage();
        }
        
        private void insertPage()
        {
            //take selected product
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                ShoeModel shoeModel = new ShoeModel();
                BootProduct products = shoeModel.GetProducts(id);

                //insert the data
                BootsPrice.Text = "Price per pair: <br/>$ " + products.Price;
                BootsTitle.Text = products.ShoeName;
                BootsDescription.Text = products.Description;
                BootsID.Text = id.ToString();
                BootsImage.ImageUrl = "~/img/productimage/" + products.Image;

                //fill the dropdown list
                int[] amount = Enumerable.Range(1, 20).ToArray();
                AmountDropDown.DataSource = amount;
                AmountDropDown.AppendDataBoundItems = true;
                AmountDropDown.DataBind();
            }
        }

        protected void buttonATC_Click1(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                string customerID = Context.User.Identity.GetUserId();

                if (customerID != null)
                {

                    int ID = Convert.ToInt32(Request.QueryString["id"]);
                    int price = Convert.ToInt32(AmountDropDown.SelectedValue);

                    BootCart bootCart = new BootCart
                    {
                        Price = price,
                        CustomerID = customerID,
                        DateBought = DateTime.Now,
                        InsideCart = true,
                        ProductID = ID

                    };
                    CartModel cartModel = new CartModel();
                    BootsResult.Text = cartModel.InsertCart(bootCart);
                }
                else
                {
                    BootsResult.Text = "Please Login or Register to Order Items";
                }

            }
        }
    }
}