using CF.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CF.Factory
{
    public partial class ComputerFactory : System.Web.UI.Page
    {
        ComputerManager cm = new ComputerManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            var t = cm.GetComputerParts(0);
            GridView1.DataSource = t;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cm.AddComputerPart(txtPartName.Text, int.Parse(txtPartType.Text), double.Parse(txtPrice.Text));
        }
    }
}