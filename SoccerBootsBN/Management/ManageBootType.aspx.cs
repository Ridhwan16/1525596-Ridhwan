using SoccerBootsBN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoccerBootsBN.Management
{
    public partial class ManageBootsType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submitbtn_Click(object sender, EventArgs e)
        {
            ShoeType model = new ShoeType();
            BootType pt = createBootType();

            LabelResult.Text = model.InsertProductType(pt);
        }
        private BootType createBootType()
        {
            BootType p = new BootType();
            p.ShoeName = Nametxt.Text;

            return p; 
        }
    }
}