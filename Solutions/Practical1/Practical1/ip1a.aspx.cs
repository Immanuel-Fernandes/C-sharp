using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical1
{
    public partial class ip1a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdProduct_Click(object sender, EventArgs e)
        {
            int a, b, c, d, product;
            a = System.Convert.ToInt32(txt_1.Text);
            b = System.Convert.ToInt32(txt_2.Text);
            c = System.Convert.ToInt32(txt_3.Text);
            d = System.Convert.ToInt32(txt_4.Text);
            product = (a * b * c * d);

            txt_5.Text = System.Convert.ToString(product);

        }
    }
}