using Microsoft.AspNet.Identity;
using SoccerBootsBN.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Source taken from https://www.youtube.com/watch?v=sXS2lX7XdOs
namespace SoccerBootsBN
{
    public partial class ShopCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the user ID and Display the item in cart
            string CustomerID = User.Identity.GetUserId();
            GetSelectedInCart(CustomerID); 
        }

        private void GetSelectedInCart(string CustomerID)
        {
            CartModel model = new CartModel();
            double subTotal = 0;

            //take each of the boots in the list
            List<BootCart> BoughtList = model.GetOrdersInCart(CustomerID);
            CreateShoppingTable(BoughtList, out subTotal);

            //calculate all the total amount
            double tax = subTotal * 0.21;
            double totalPrice = subTotal + tax + 33;

            //show the price on the page
            TotalLiteral.Text = "BND " + subTotal;
            TaxLiteral.Text = "BND " + tax;
            TotalPriceLiteral.Text = "BND " + totalPrice;

        }

        private void CreateShoppingTable(List<BootCart> boughtList, out double subTotal)
        {
            subTotal = new Double();
            ShoeModel model = new ShoeModel();

            foreach (BootCart cart in boughtList)
            {
                BootProduct product = model.GetProducts(cart.ProductID);

                //create the image button 
                ImageButton ImageBtn = new ImageButton
                {
                    ImageUrl = String.Format("~/img/productimage/{0}", product.Image),
                    PostBackUrl = String.Format("~/Brands.aspx?id={0}", product.ID)
                };

                //Create Delete button
                LinkButton DeleteLink = new LinkButton
                {
                    PostBackUrl = string.Format("~/ShopCart.aspx?ProductId={0}", cart.ID),
                    Text = "Delete Item",
                    ID = "delete" + cart.ID
                };

                //Add on click
                DeleteLink.Click += Delete_Item;

                //Create the dropdownlist on the quantity
                int[] amount = Enumerable.Range(1, 20).ToArray();
                DropDownList AmountDropDown = new DropDownList
                {
                    DataSource = amount,
                    AppendDataBoundItems = true,
                    AutoPostBack = true,
                    ID = cart.ID.ToString()
                };

                AmountDropDown.DataBind();
                AmountDropDown.SelectedValue = cart.Price.ToString();
                AmountDropDown.SelectedIndexChanged += AmountDropDown_SelectedIndexChanged;

                //create table with 2 rows
                Table table = new Table { CssClass = "cartTable" };
                TableRow a = new TableRow();
                TableRow b = new TableRow();

                //create 6 cells
                TableCell a11 = new TableCell { RowSpan = 2, Width = 50 };
                TableCell a12 = new TableCell
                {
                    Text = string.Format("<h4>{0}<h4><br/>{1}<br/>InStock",
                    product.ShoeName, "Item No: " + product.ID),
                    HorizontalAlign = HorizontalAlign.Left,
                    Width = 350
                };
                TableCell a13 = new TableCell { Text = "Unit Price<hr/>" };
                TableCell a14 = new TableCell { Text = "Quantity<hr/>" };
                TableCell a15 = new TableCell { Text = "Total Pairs<hr/>" };
                TableCell a16 = new TableCell { };

                //create another 6 cells

                TableCell b1 = new TableCell { };
                TableCell b2 = new TableCell { Text = "BND " + product.Price };
                TableCell b3 = new TableCell { };
                TableCell b4 = new TableCell { Text = "BND " + Math.Round((cart.Price * (double)product.Price), 2) };
                TableCell b5 = new TableCell { };
                TableCell b6 = new TableCell { };

                //set the controls 
                a11.Controls.Add(ImageBtn);
                a16.Controls.Add(DeleteLink);
                b3.Controls.Add(AmountDropDown);

                //add cells to row 
                a.Cells.Add(a11);
                a.Cells.Add(a12);
                a.Cells.Add(a13);
                a.Cells.Add(a14);
                a.Cells.Add(a15);
                a.Cells.Add(a16);

                b.Cells.Add(b1);
                b.Cells.Add(b2);
                b.Cells.Add(b3);
                b.Cells.Add(b4);
                b.Cells.Add(b5);
                b.Cells.Add(b6);

                //add rows to table
                table.Rows.Add(a);
                table.Rows.Add(b);

                //add table to shopping cart panel
                ShopCartPanel.Controls.Add(table);

                //add the total price 
                subTotal += (cart.Price * (double)product.Price);

                //add user current shopping cart
                Session[User.Identity.GetUserId()] = boughtList;
            }
        }
private void AmountDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList selectedList = (DropDownList)sender;
            int quantity = Convert.ToInt32(selectedList.SelectedValue);
            int cartId = Convert.ToInt32(selectedList.ID);

            CartModel model = new CartModel();
            model.UpdateQuantity(cartId, quantity);

            Response.Redirect("~/ShopCart.aspx");
        }

        private void Delete_Item(object sender, EventArgs e)
        {
            LinkButton selectedLink = (LinkButton)sender;
            string link = selectedLink.ID.Replace("delete", "");
            int cartId = Convert.ToInt32(link);

            CartModel model = new CartModel();
            model.DeleteCart(cartId);

            Response.Redirect("~/ShopCart.aspx");
        }

        
        }
    }
