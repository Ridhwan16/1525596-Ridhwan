using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Source taken from https://www.youtube.com/watch?v=sXS2lX7XdOs

namespace SoccerBootsBN.Management
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridBoots_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridBoots.Rows[e.NewEditIndex];

            int rowId = Convert.ToInt32(row.Cells[1].Text);
            Response.Redirect("../Management/ManageBootProduct.aspx?id=" + rowId);

        }
    }
}