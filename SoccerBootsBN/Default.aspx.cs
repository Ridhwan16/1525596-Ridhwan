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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            insertpage();
        }
        private void insertpage()
        {
            //retrieve all the product form database
            ShoeModel shoeModel = new ShoeModel();
            List<BootProduct> product = shoeModel.RetrieveAllProduct();

            //the product must exist in the database
            if (product != null)
            {
                //create an image and zoom in 
                foreach (BootProduct products in product)
                {
                    Panel bootsPanel = new Panel();
                    ImageButton zoomIn = new ImageButton();
                    Label NameLabel = new Label();
                    Label PriceLabel = new Label();

                    //set child control properties
                    zoomIn.ImageUrl = "~/img/productimage/" + products.Image;
                    zoomIn.CssClass = "BootsImage";
                    zoomIn.PostBackUrl = "~/Brands.aspx?id=" + products.ID;

                    NameLabel.Text = products.ShoeName;
                    NameLabel.CssClass = "ShoeName";

                    PriceLabel.Text = "BND " + products.Price;
                    PriceLabel.CssClass = "ShoePrice";

                    //add the child control
                    bootsPanel.Controls.Add(zoomIn);
                    bootsPanel.Controls.Add(new Literal { Text = "<br/>" });
                    bootsPanel.Controls.Add(NameLabel);
                    bootsPanel.Controls.Add(new Literal { Text = "<br/>" });
                    bootsPanel.Controls.Add(PriceLabel);

                    //add the dynamic panels
                    BootsPanel.Controls.Add(bootsPanel);


                }
            }
            else
            {
                //no products
                BootsPanel.Controls.Add(new Literal { Text = "There is no products!" });
            }
        }
    }
}