using SoccerBootsBN.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoccerBootsBN.Management
{
    public partial class ManageBootProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GetImages();

            if(!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Fillpage(id);
            }
        }

        private void Fillpage(int id)
        {
            //get selected details  from database
            ShoeModel shoeModel = new ShoeModel();
            BootProduct product = shoeModel.GetProducts(id);

            //Fill the text
            Desctxt.Text = product.Description;
            Nametxt.Text = product.ShoeName;
            Pricetxt.Text = product.Price.ToString();

            //set the value of dropdown
            ImageDropDown.SelectedValue = product.Image;
            TypeDropDown.SelectedValue = product.ShoeType.ToString();
        }
        protected void Submitbtn_Click(object sender, EventArgs e)
        {
            ShoeModel bootProduct = new ShoeModel();
            BootProduct product = CreateProduct();

            //checck if there is an id on the websitename
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //there is an id
                int id = Convert.ToInt32(Request.QueryString["id"]);
                ResultLabel.Text = bootProduct.UpdateProduct(id, product);
            }
            else
            {
                //no id
                ResultLabel.Text = bootProduct.InsertProduct(product);
            }

        }
        private void GetImages()
        {
            try
            {
                //retrieve all the image path
                string[] images = Directory.GetFiles(Server.MapPath("~/img/productimage/"));

                //get all the files and add to the arraylist
                ArrayList imageList = new ArrayList();
                foreach (string image in images)
                {
                    string imgName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                    imageList.Add(imgName);
                }

                ImageDropDown.DataSource = imageList;
                ImageDropDown.AppendDataBoundItems = true;
                ImageDropDown.DataBind();
            }
            catch (Exception e)
            {
                ResultLabel.Text = e.ToString();
            }
        }
        private BootProduct CreateProduct()
        {
            BootProduct product = new BootProduct();

            product.ShoeName = Nametxt.Text;
            product.Price = Convert.ToInt32(Pricetxt.Text);
            product.ShoeType = Convert.ToInt32(TypeDropDown.SelectedValue);
            product.Description = Desctxt.Text;
            product.Image = ImageDropDown.SelectedValue;

            return product;

        }

        
    }
}